using SistemaHospitalar.Entities;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalADM : DalComandos
    {
        public string OutPut = "";
        private bool isLoginExistente = false;

        public bool isAcessoValido(ADM adm)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@usuario", adm.Usuario);
            command.Parameters.AddWithValue("@senha", adm.Senha);
            command.CommandText = "select * from ADM where Usuario = @usuario and Senha = @senha";

            try
            {
                command.Connection = conexao.Conectar();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isLoginExistente = true;
                }
                else
                {
                    OutPut = "Conta ADM não encontrada";
                }
            }
            catch (SqlException e)
            {
                OutPut = "Erro com o Banco de dados" + e.Message;
            }
            finally
            {
                conexao.Desconectar();
            }
            return isLoginExistente;
        }
    }
}
