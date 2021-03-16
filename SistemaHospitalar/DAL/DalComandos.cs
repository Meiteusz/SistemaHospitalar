using SistemaHospitalar.Models;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    public class DalComandos
    {
        public static Conexao conexao = new Conexao();
        public static SqlCommand command = new SqlCommand();
        public static DataTable dt;
        public static SqlDataAdapter adapter;

        public virtual string MostrarTipoErro(SqlException ex)
        {
            string erro = "";
            if (ex.Number == 2627)
                erro = "Já existe este CPF cadastrado!";
            else
                erro = " Erro com o banco de dados " + ex.Message;
            return erro;
        }

        public string MostrarErro(SqlException ex)
        {
            return "Erro com o Banco de Dados " + ex.Message;
        }
    }
}
