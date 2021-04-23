using SistemaHospitalar.Entities;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalQuartos : DalComandos
    {
        public string Insert(Quartos p_quarto)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@numeroQuarto", p_quarto.NumeroQuarto);
            command.Parameters.AddWithValue("@isDisponivel", p_quarto.isDisponivel);

            command.CommandText = "insert into QUARTOS values(@numeroQuarto, @isDisponivel)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Quarto cadastrado com sucesso";
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

        public void UpdateOcuparQuarto(int p_IdQuarto)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@numeroQuarto", p_IdQuarto);
            command.CommandText = "update QUARTOS set DISPONIVEL = 0 where NUMEROQUARTO = @numeroQuarto";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Conectar();
            }
        }

        public void UpdateDesocuparQuarto(int p_IdQuarto)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@numeroQuarto", p_IdQuarto);
            command.CommandText = "update QUARTOS set DISPONIVEL = 1 where NUMEROQUARTO = @numeroQuarto";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Conectar();
            }
        }

        public DataTable TodosQuartos()
        {
            command.CommandText = "select NUMEROQUARTO as Numero_Quarto, DISPONIVEL as isDisponivel from QUARTOS";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable QuartosDisponiveis()
        {
            command.CommandText = "select NUMEROQUARTO as Numero_Quarto, DISPONIVEL as isDisponivel from QUARTOS where DISPONIVEL = 1";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public ArrayList ListarQuartosDisponiveis()
        {
            ArrayList quartosDisponiveis = new ArrayList();
            adapter = new SqlDataAdapter("select NUMEROQUARTO from QUARTOS where DISPONIVEL = 1", conexao.Conectar());
            dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                quartosDisponiveis.Add(item["NUMEROQUARTO"].ToString());
            }
            conexao.Desconectar();
            return quartosDisponiveis;
        }
    }
}
