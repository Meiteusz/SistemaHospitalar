using SistemaHospitalar.Entities;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalExames : DalComandos
    {
        public string Insert(Exame p_exame)
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
    }
}
