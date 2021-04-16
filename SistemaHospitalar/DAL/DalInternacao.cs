using SistemaHospitalar.Entities;
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
                dalQuartos.Update(p_internacao.QuartoId);
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
    }
}
