using SistemaHospitalar.Entities;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalValores : DalComandos
    {
        public string CadastrarValor(Valores valor)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@valorConsulta", valor.ValorConsulta);
            command.Parameters.AddWithValue("@valorExame", valor.ValorExame);
            command.Parameters.AddWithValue("@doutor", valor.Doutor);
            command.CommandText = "insert into VALORES values (@valorConsulta, @valorExame, @doutor)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Valores Cadastrados";
            }
            catch (SqlException ex)
            {
                return MostrarErro(ex);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public string AtualizarValor(Valores valor)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@valorConsulta", valor.ValorConsulta);
            command.Parameters.AddWithValue("@valorExame", valor.ValorExame);
            command.Parameters.AddWithValue("@idDoutor", valor.Doutor);
            command.CommandText = "update VALORES set VALORCONSULTA = @valorConsulta, VALOREXAME = @valorExame where DOUTORID = @idDoutor";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Valores Atualizados";
            }
            catch (SqlException ex)
            {
                return MostrarErro(ex);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private static bool isValorExiste { get; set; }

        public static bool isValorDefinido(int id)
        {
            isValorExiste = false;
            SqlCommand command = new SqlCommand("select * from VALORES where doutorid = @id", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                isValorExiste = true;
            }
            conexao.Desconectar();
            return isValorExiste;
        }
    }
}
