using SistemaHospitalar.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalExames : DalComandos
    {
        public string InsertExame(Exame p_exame)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@CONSULTAID", p_exame.ConsultaId);
            command.Parameters.AddWithValue("@DATAEXAME", p_exame.DataExame);
            command.Parameters.AddWithValue("@PRECO", p_exame.Preco);
            command.Parameters.AddWithValue("@TIPOEXAME", p_exame.TipoExame);

            command.CommandText = "insert into EXAMES values(@CONSULTAID, @DATAEXAME, @PRECO, @TIPOEXAME)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Exame agendado com sucesso";
            }
            catch (SqlException ex)
            {
                return MostrarTipoErro(ex);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public string InsertDiagnostico(Diagnostico p_diagnostico)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@descricao", p_diagnostico.Descricao);
            command.Parameters.AddWithValue("@exameId", p_diagnostico.ExameId);
            command.Parameters.AddWithValue("@dataDiagnostico", p_diagnostico.DataDiagnostico);
            command.CommandText = "insert into DIAGNOSTICOS values(@descricao, @exameId, @dataDiagnostico)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Diagnostico feito com sucesso";
            }
            catch (SqlException ex)
            {
                return MostrarTipoErro(ex);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public string DeleteDiagnostico(int p_IdDiagnostico)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdDiagnostico", p_IdDiagnostico);
            command.CommandText = "delete DIAGNOSTICOS where ID = @IdDiagnostico";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Diagnostico deletado com sucesso";
            }
            catch (SqlException ex)
            {
                return MostrarTipoErro(ex);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public Exame GetDadosExameById(int p_IdExame)
        {
            Exame exame = new Exame();
            SqlCommand command = new SqlCommand("select * from Exames where ID = @IdExame", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdExame", p_IdExame);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                exame.Id = (int)reader["ID"];
                exame.ConsultaId = (int)reader["CONSULTAID"];
                exame.DataExame = Convert.ToDateTime(reader["DATAEXAME"]);
                exame.TipoExame = reader["TIPOEXAME"].ToString();
            }
            conexao.Desconectar();
            return exame;
        }

        public Diagnostico GetDadosDiagnosticoExameById(int p_IdDiagnostico)
        {
            Diagnostico diagnostico = new Diagnostico();
            SqlCommand command = new SqlCommand("select * from DIAGNOSTICOS where ID = @IdDiagnostico", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdDiagnostico", p_IdDiagnostico);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                diagnostico.Id = (int)reader["ID"];
                diagnostico.Descricao = reader["DESCRICAO"].ToString();
                diagnostico.ExameId = (int)reader["EXAMEID"];
                diagnostico.DataDiagnostico = Convert.ToDateTime(reader["DATADIAGNOSTICO"]);
            }
            conexao.Desconectar();
            return diagnostico;
        }

        public bool isDiagnosticoExistente(int p_IdExame)
        {
            bool isDiagnosticoExistente = false;
            SqlCommand command = new SqlCommand("select * from DIAGNOSTICOS where EXAMEID = @exameId", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@exameId", p_IdExame);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            conexao.Desconectar();
            return isDiagnosticoExistente;
        }

        public DataTable TodosExamesDoDoutor(int p_IdDoutor)
        {
            SqlCommand command = new SqlCommand("select EXAMES.ID, PACIENTES.NOME as Nome_Paciente, FORMAT(EXAMES.DATAEXAME, 'dd/MM/yyyy HH:mm') as Data_Exame, " +
                "FORMAT(EXAMES.PRECO, 'c', 'pt-br') as Preco_Exame, EXAMES.TIPOEXAME FROM CONSULTAS inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID " +
                "inner join EXAMES on EXAMES.CONSULTAID = CONSULTAS.ID where CONSULTAS.DOUTORID = @IdDoutor", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdDoutor", p_IdDoutor);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }
        
        public DataTable DiagnosticosExame(int p_IdExame)
        {
            SqlCommand command = new SqlCommand("select DIAGNOSTICOS.ID as ID_Diagnostico, EXAMES.ID as ID_Exame, DIAGNOSTICOS.DESCRICAO, " +
                "FORMAT(DIAGNOSTICOS.DATADIAGNOSTICO, 'dd/MM/yyyy HH:mm') as Data_Diagnostico from DIAGNOSTICOS inner join EXAMES on EXAMES.ID = " +
                "DIAGNOSTICOS.EXAMEID where EXAMEID = @IdExame", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdExame", p_IdExame);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }
    }
}
