using System.Data.SqlClient;

namespace SistemaHospitalar.Models
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            // MultipleActiveResultSets=true -> comando deve ser usado na connectionString
            con.ConnectionString = "Data Source=.;Initial Catalog=SistemaHospitalar;Integrated Security=True; MultipleActiveResultSets=true";
            //con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\arthu\Documents\HospitalDB2.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
