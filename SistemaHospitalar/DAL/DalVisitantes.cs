using SistemaHospitalar.Models;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    public class DalVisitantes : DalComandos
    {
        public string Insert(Visitante visitante)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", visitante.Nome);
            command.Parameters.AddWithValue("@cpf", visitante.Cpf);

            command.CommandText = "insert into VISITANTES values(@nome, @cpf)";
            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Visitante cadastrado com sucesso";
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

        public string Delete(int id)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", id);
            command.CommandText = "delete from VISITANTES where id = @ID";
            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Visitante deletado com sucesso";
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

        public string Update(Visitante visitante)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", visitante.Id);
            command.Parameters.AddWithValue("@NOME", visitante.Nome);
            command.CommandText = "update VISITANTES set NOME = @NOME where ID = @ID";
            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Informações alteradas com sucesso";
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

        public ArrayList GetCpfVisitantes()
        {
            ArrayList visitantes = new ArrayList();
            adapter = new SqlDataAdapter("select CPF from VISITANTES", conexao.Conectar());
            dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                visitantes.Add(item["CPF"].ToString());
            }
            conexao.Desconectar();
            return visitantes;
        }
    }
}
