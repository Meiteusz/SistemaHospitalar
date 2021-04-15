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

        public DataTable TodosQuartos()
        {
            command.CommandText = "select * from QUARTOS";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable QuartosDisponiveis()
        {
            command.CommandText = "select * from QUARTOS where DISPONIVEL = 1";
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
