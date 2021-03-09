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

        public static string msgErroBD = "Erro com o Banco de Dados";
    }
}
