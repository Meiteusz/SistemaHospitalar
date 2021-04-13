using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalConvenios : DalComandos
    {
        public string Insert(Convenios convenios)
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


        public string Delete(int p_id)
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
                return MostrarTipoErro(ex);
            }
            finally
            {
                conexao.Desconectar();
            }
        }


        public void GetDadosConvenio(int p_IdConvenio)
        {
            Convenios convenio = new Convenios();

            SqlCommand command = new SqlCommand("select * from CONVENIOS where ID = @IdConvenio", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdConvenio" , p_IdConvenio);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                convenio.Nome = reader["NOME"].ToString();
                convenio.Desconto = Convert.ToSingle(reader["DESCONTO"]);
            }
            conexao.Desconectar();
            FuncionarioLogado.SetConvenioSelecionado(convenio);
        }


        public static DataTable MostrarConveniosDGV()
        {
            command.CommandText = "select * from CONVENIOS";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public ArrayList ListaConvenios()
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

        public override string MostrarTipoErro(SqlException ex)
        {
            string erro = "";
            if (ex.Number == 2627)
                erro = "Já existe um Convênio com este nome Cadastrado!";
            else
                erro = " Erro com o banco de dados " + ex.Message;
            return erro;
        }
    }
}
