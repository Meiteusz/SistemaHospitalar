using SistemaHospitalar.Entities;
using System.Collections.Generic;
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

        //List<string> convenios = new List<string>();

        public static List<string> MostrarNomeConvenios()
        {
            command.CommandText = "select NOME from CONVENIOS";
            SqlDataReader reader;
            List<string> convenios = new List<string>();
            command.Connection = conexao.Conectar();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string c = reader.GetString(1);
                convenios.Add(c);
            }
            conexao.Desconectar();
            return convenios;


            //command.CommandText = "select NOME from CONVENIOS";
            //adapter = new SqlDataAdapter(command);
            //dt = new DataTable();
            //adapter.Fill(dt);
            //return dt;
        }
    }
}
