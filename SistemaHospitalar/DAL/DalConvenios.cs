using SistemaHospitalar.Entities;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalConvenios : DalComandos
    {
        public override string MostrarTipoErro(SqlException ex)
        {
            string erro = "";
            if (ex.Number == 2627)
                erro = "Já existe um Convênio com este nome Cadastrado!";
            else
                erro = " Erro com o banco de dados " + ex.Message;
            return erro;
        }


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
                return MostrarTipoErro(ex);
            }
            finally
            {
                conexao.Desconectar();
            }
        }


        public string DeletarConvenio(int p_id)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", p_id);
            command.CommandText = "delete CONVENIOS where id = @id";

            try
            {
                conexao.Conectar();
                command.ExecuteNonQuery();
                return "Convenio deletado com sucesso!";
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

        public static int IndentificarConvenio(int p_pacienteId)
        {
            int IdConvenio = 0;
            SqlCommand command = new SqlCommand("select CONVENIOID from PACIENTES where ID = @id", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", p_pacienteId);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                IdConvenio = (int)reader["CONVENIOID"];
            }
            conexao.Desconectar();
            return IdConvenio;
        }

        public static string DescontoConvenio { get; set; }
        public static string IndentificarNomeConvenio(int p_convenioId)
        {
            string NomeConvenio = "";
            SqlCommand command = new SqlCommand("select NOME, DESCONTO from CONVENIOS where ID = @id", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", p_convenioId);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                NomeConvenio = reader["NOME"].ToString();
                DescontoConvenio = reader["DESCONTO"].ToString();
            }
            conexao.Desconectar();
            return NomeConvenio;
        }

        public static DataTable MostrarConveniosDGV()
        {
            command.CommandText = "select * from CONVENIOS";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        public static ArrayList MostrarNomeConvenios()
        {
            ArrayList convenios = new ArrayList();
            adapter = new SqlDataAdapter("select NOME from CONVENIOS", conexao.Conectar());
            dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                convenios.Add(item["NOME"].ToString());
            }
            conexao.Desconectar();
            return convenios;
        }
    }
}
