using SistemaHospitalar.Entities;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalConvenios : DalComandos
    {
        public string CadastrarConvenio(Convenios convenios)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", convenios.Nome);
            command.Parameters.AddWithValue("@desconto", convenios.Desconto);

            command.CommandText = "insert into CONVENIOS values(@nome, @desconto)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Convênio cadastrado com sucesso";
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

        public static DataTable MostrarConveniosDGV()
        {
            command.CommandText = "select * from CONVENIOS";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private int ID { get; set; }
        private string Nome { get; set; }
    }
}
