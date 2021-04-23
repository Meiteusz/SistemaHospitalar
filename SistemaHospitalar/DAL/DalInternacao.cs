using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    public class DalInternacao : DalComandos
    {
        DalQuartos dalQuartos = new DalQuartos();

        public string Insert(Internacao p_internacao)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@PACIENTEID", p_internacao.PacienteId);
            command.Parameters.AddWithValue("@DOUTORID", p_internacao.DoutorId);
            command.Parameters.AddWithValue("@DESCRICAO", p_internacao.Descricao);
            command.Parameters.AddWithValue("@TIPOINTERNACAO", p_internacao.TipoInternacao);
            command.Parameters.AddWithValue("@QUARTOID", p_internacao.QuartoId);
            command.Parameters.AddWithValue("@DATAENTRADA", p_internacao.DataEntrada);
            command.Parameters.AddWithValue("@DATAULTIMAATUALIZACAO", p_internacao.DataUltimaAtualizacao);

            command.CommandText = "insert into INTERNACAO (PACIENTEID, DOUTORID, DESCRICAO, TIPOINTERNACAO, QUARTOID, DATAENTRADA, DATAULTIMAATUALIZACAO) values(@PACIENTEID, @DOUTORID, @DESCRICAO, @TIPOINTERNACAO, @QUARTOID, @DATAENTRADA, @DATAULTIMAATUALIZACAO)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                dalQuartos.UpdateOcuparQuarto(p_internacao.QuartoId);
                return "Paciente foi internado com sucesso";
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

        public string Update(Internacao p_internacao)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", p_internacao.Id);
            command.Parameters.AddWithValue("@DESCRICAO", p_internacao.Descricao);
            command.Parameters.AddWithValue("@TIPOINTERNACAO", p_internacao.TipoInternacao);
            command.Parameters.AddWithValue("@QUARTOID", p_internacao.QuartoId);
            command.Parameters.AddWithValue("@DATAULTIMAATUALIZACAO", p_internacao.DataUltimaAtualizacao);
            command.CommandText = "update INTERNACAO set DESCRICAO = @DESCRICAO, TIPOINTERNACAO = @TIPOINTERNACAO, QUARTOID = @QUARTOID, DATAULTIMAATUALIZACAO = @DATAULTIMAATUALIZACAO where ID = @ID";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                AlterarPacienteDeQuarto(p_internacao.QuartoId);
                return "Dados da internação atualizados com sucesso";
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

        public void AlterarPacienteDeQuarto(int p_IdQuarto)
        {
            if (p_IdQuarto != FuncionarioLogado.InternacaoTemp.QuartoId)
            {
                dalQuartos.UpdateDesocuparQuarto(FuncionarioLogado.InternacaoTemp.QuartoId);
                dalQuartos.UpdateOcuparQuarto(p_IdQuarto);
            }
        }

        public string UpdateAltaInternacao(Internacao p_internacao)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", p_internacao.Id);
            command.Parameters.AddWithValue("@DATASAIDA", p_internacao.DataSaida);
            command.Parameters.AddWithValue("@PRECO", p_internacao.Preco);
            command.CommandText = "update INTERNACAO set DATASAIDA = @DATASAIDA, PRECO = @PRECO where ID = @ID";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                dalQuartos.UpdateDesocuparQuarto(FuncionarioLogado.InternacaoTemp.QuartoId);
                return "Paciente recebeu Alta com sucesso";
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

        public Internacao GetDadosInternacaoById(int p_IdInternacao)
        {
            Internacao internacao = new Internacao();
            SqlCommand command = new SqlCommand("select * from INTERNACAO where ID = @IdInternacao", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdInternacao", p_IdInternacao);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Enum.TryParse(reader["TIPOINTERNACAO"].ToString(), out TipoInternacao TipoInternacaoConvertido);

                internacao.Id = (int)reader["ID"];
                internacao.PacienteId = (int)reader["PACIENTEID"];
                internacao.DoutorId = (int)reader["DOUTORID"];
                internacao.Descricao = reader["DESCRICAO"].ToString();
                internacao.TipoInternacao = TipoInternacaoConvertido;
                internacao.QuartoId = (int)reader["QUARTOID"];
                internacao.DataEntrada = Convert.ToDateTime(reader["DATAENTRADA"]);
                internacao.DataUltimaAtualizacao = Convert.ToDateTime(reader["DATAULTIMAATUALIZACAO"]);
            }
            conexao.Desconectar();
            return internacao;
        }

        public int GetIdInternacaoByIdPaciente(int p_IdPaciente)
        {
            int IdInternacao = 0;
            SqlCommand command = new SqlCommand("select ID from INTERNACAO where PACIENTEID = @IdPaciente", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdPaciente", p_IdPaciente);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                IdInternacao = (int)reader["ID"];
            }
            conexao.Desconectar();
            return IdInternacao;
        }

        public bool isDataSaidaNull(int p_IdInternacao)
        {
            string dataSaida = string.Empty;
            SqlCommand command = new SqlCommand("select DATASAIDA from INTERNACAO where ID = @IdInternacao", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdInternacao", p_IdInternacao);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataSaida = reader["DATASAIDA"].ToString();
            }
            conexao.Desconectar();
            if (dataSaida.Equals(string.Empty))
            {
                return true;
            }
            else
            { 
                return false;
            }
        }

        public DataTable MostrarTodasInternacoes()
        {
            command.CommandText = "select PACIENTES.NOME as Paciente_Nome, DOUTORES.NOME as Doutor_Nome, INTERNACAO.DESCRICAO, INTERNACAO.TIPOINTERNACAO as " +
                "Tipo_Internacao,  INTERNACAO.QUARTOID as Numero_Quarto, FORMAT(INTERNACAO.DATAENTRADA, 'dd/MM/yyyy HH:mm') as Data_Entrada, FORMAT(INTERNACAO.DATASAIDA, " +
                "'dd/MM/yyyy HH:mm') as Data_Saida, INTERNACAO.PRECO, FORMAT(INTERNACAO.DATAULTIMAATUALIZACAO, 'dd/MM/yyyy HH:mm') as Ultima_Atualizacao from " +
                "INTERNACAO inner join PACIENTES on PACIENTES.ID = PACIENTEID inner join DOUTORES on DOUTORES.ID = DOUTORID";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable MostrarInternacoesParaDoutor(int p_IdDoutor)
        {
            SqlCommand command = new SqlCommand("select INTERNACAO.ID, PACIENTES.NOME as Paciente_Nome, INTERNACAO.DESCRICAO as Descricao, INTERNACAO.TIPOINTERNACAO as " +
                "Tipo_Internacao, INTERNACAO.QUARTOID as Numero_Quarto, FORMAT(INTERNACAO.DATAENTRADA, 'dd/MM/yyyy HH:mm') as Data_Entrada, " +
                "FORMAT(INTERNACAO.DATASAIDA, 'dd/MM/yyyy HH:mm') as Data_Saida, FORMAT(INTERNACAO.PRECO, 'c', 'pt-br') as Preço_Total, " +
                "FORMAT(INTERNACAO.DATAULTIMAATUALIZACAO, 'dd/MM/yyyy HH:mm') as Ultima_Atualizacao from INTERNACAO inner join PACIENTES on " +
                "PACIENTES.ID = PACIENTEID where DOUTORID = @IdDoutor", conexao.Conectar());

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdDoutor", p_IdDoutor);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }
    }
}
