using SistemaHospitalar.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalExames : DalComandos
    {
        public bool isDataExameValido(DateTime p_dataExame, int p_idPaciente, int p_idDoutor)
        {
            bool isValido = true;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@dataExame", p_dataExame);
            command.Parameters.AddWithValue("@idPaciente", p_idPaciente);
            command.Parameters.AddWithValue("@idDoutor", p_idDoutor);

            command.CommandText = "select CONSULTAS.PACIENTEID, CONSULTAS.DOUTORID, EXAMES.DATAEXAME from CONSULTAS inner join EXAMES on EXAMES.CONSULTAID = " +
                "CONSULTAS.ID where EXAMES.DATAEXAME = @dataExame AND(CONSULTAS.PACIENTEID = @idPaciente OR CONSULTAS.DOUTORID = @idDoutor)";

            command.Connection = conexao.Conectar();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                isValido = false;
            }
            conexao.Desconectar();
            return isValido;
        }

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

        public string UpdateDataExame(DateTime p_DataExame, int p_IdExame)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@dataExame", p_DataExame);
            command.Parameters.AddWithValue("@id", p_IdExame);
            command.CommandText = "update EXAMES set DATAEXAME = @dataExame where Id = @id";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Exame reagendada com sucesso";
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

        public DataTable PesquisarExamesByData(string p_dataExame)
        {
            SqlCommand command = new SqlCommand("select DOUTORES.NOME as Doutor_Nome, FORMAT(EXAMES.DATAEXAME , 'dd/MM/yyyy HH:mm') as Exame_Data from EXAMES " +
                "inner join CONSULTAS on CONSULTAS.ID = EXAMES.CONSULTAID inner join DOUTORES on DOUTORES.ID = CONSULTAS.DOUTORID where " +
                "FORMAT(CONVERT(DATE, EXAMES.DATAEXAME), 'dd/MM/yyyy') = @DataExame", conexao.Conectar());

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@DataExame", p_dataExame);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        public DataTable MostrarExames()
        {
            command.CommandText = "select EXAMES.ID, CONSULTAS.ID as Cons_Id, PACIENTES.NOME as Paciente_Nome, DOUTORES.NOME as Doutor_Nome, FORMAT(EXAMES.DATAEXAME  , 'dd/MM/yyyy HH:mm') as Data_Horario" +
                ", FORMAT(EXAMES.PRECO, 'c', 'pt-br') as Valor, EXAMES.TIPOEXAME as Exame_Tipo from EXAMES inner join CONSULTAS on " +
                "CONSULTAS.ID = EXAMES.CONSULTAID inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID inner join DOUTORES on DOUTORES.ID = CONSULTAS.DOUTORID";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable MostrarExamesHoje()
        {
            command.CommandText = "select EXAMES.ID, CONSULTAS.ID as Cons_Id, PACIENTES.NOME as Paciente_Nome, DOUTORES.NOME as Doutor_Nome, FORMAT(EXAMES.DATAEXAME  , 'dd/MM/yyyy HH:mm') as Data_Horario" +
                    ", FORMAT(EXAMES.PRECO, 'c', 'pt-br') as Valor, EXAMES.TIPOEXAME as Exame_Tipo from EXAMES inner join CONSULTAS on " +
                    "CONSULTAS.ID = EXAMES.CONSULTAID inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID inner join DOUTORES on DOUTORES.ID = CONSULTAS.DOUTORID" +
                    " where CONVERT(DATE, EXAMES.DATAEXAME) = Convert(date, getdate())";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable TodosExamesDoDoutor(int p_IdDoutor)
        {
            SqlCommand command = new SqlCommand("select EXAMES.ID, CONSULTAS.ID as Cons_Id, PACIENTES.NOME as Paciente_Nome, FORMAT(EXAMES.DATAEXAME, 'dd/MM/yyyy HH:mm') as Data_Exame, " +
                "FORMAT(EXAMES.PRECO, 'c', 'pt-br') as Exame_Preco, EXAMES.TIPOEXAME as Tipo_Exame FROM CONSULTAS inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID " +
                "inner join EXAMES on EXAMES.CONSULTAID = CONSULTAS.ID where CONSULTAS.DOUTORID = @IdDoutor", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdDoutor", p_IdDoutor);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        public DataTable TodosExamesDoDoutorHoje(int p_IdDoutor)
        {
            SqlCommand command = new SqlCommand("select EXAMES.ID, CONSULTAS.ID as Cons_Id, PACIENTES.NOME as Paciente_Nome, FORMAT(EXAMES.DATAEXAME, 'dd/MM/yyyy HH:mm') as Data_Exame, " +
                "FORMAT(EXAMES.PRECO, 'c', 'pt-br') as Exame_Preco, EXAMES.TIPOEXAME as Tipo_Exame FROM CONSULTAS inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID " +
                "inner join EXAMES on EXAMES.CONSULTAID = CONSULTAS.ID where CONSULTAS.DOUTORID = @IdDoutor and CONVERT(DATE, EXAMES.DATAEXAME) = Convert(date, getdate()) ", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdDoutor", p_IdDoutor);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        public DataTable PesquisarExamesByNomePaciente(string p_NomePaciente)
        {
            SqlCommand command = new SqlCommand("select EXAMES.ID, CONSULTAS.ID as Cons_Id, PACIENTES.NOME as Paciente_Nome, DOUTORES.NOME as Doutor_Nome, " +
                "FORMAT(EXAMES.DATAEXAME  , 'dd/MM/yyyy HH:mm') as Data_Horario, FORMAT(EXAMES.PRECO, 'c', 'pt-br') as Valor, EXAMES.TIPOEXAME as Exame_Tipo from " +
                "EXAMES inner join CONSULTAS on CONSULTAS.ID = EXAMES.CONSULTAID inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID inner join " +
                "DOUTORES on DOUTORES.ID = CONSULTAS.DOUTORID where PACIENTES.NOME = @NomePaciente", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@NomePaciente", p_NomePaciente);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        public DataTable PesquisarExamesDoutorByNomePaciente(int p_IdDoutor, string p_NomePaciente)
        {
            SqlCommand command = new SqlCommand("select EXAMES.ID, CONSULTAS.ID as Cons_Id, PACIENTES.NOME as Paciente_Nome, FORMAT(EXAMES.DATAEXAME, 'dd/MM/yyyy HH:mm') as Data_Horario, " +
                "FORMAT(EXAMES.PRECO, 'c', 'pt-br') as Valor, EXAMES.TIPOEXAME as Tipo_Exame FROM CONSULTAS inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID " +
                "inner join EXAMES on EXAMES.CONSULTAID = CONSULTAS.ID where CONSULTAS.DOUTORID = @IdDoutor and PACIENTES.NOME = @NomePaciente", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdDoutor", p_IdDoutor);
            command.Parameters.AddWithValue("@NomePaciente", p_NomePaciente);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        public DataTable DiagnosticosExame(int p_IdExame)
        {
            SqlCommand command = new SqlCommand("select DIAGNOSTICOS.ID as ID_Diagnostico, EXAMES.ID as ID_Exame, DIAGNOSTICOS.DESCRICAO as Descricao, " +
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
