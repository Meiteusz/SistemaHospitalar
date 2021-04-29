using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using SistemaHospitalar.Utilities;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaHospitalar.DAL
{
    public class DalVisitas : DalComandos
    {
        public string InsertVisitante(Visitante visitante)
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

        public string InsertVisita(Visita visita)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@visitanteId", visita.VisitanteId);
            command.Parameters.AddWithValue("@dataVisita", visita.DataVisita);
            command.Parameters.AddWithValue("@internacaoId", visita.InternacaoId);

            command.CommandText = "insert into VISITAS values(@visitanteId, @dataVisita, @internacaoId)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Visita agendada com sucesso";
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

        public AutoCompleteStringCollection GetNomesVisitantes()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            adapter = new SqlDataAdapter("select NOME from VISITANTES", conexao.Conectar());
            dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                autoComplete.Add(item["NOME"].ToString());
            }
            conexao.Desconectar();
            return autoComplete;
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

        public DataTable TodosVisitantes()
        {
            command.CommandText = "select ID, NOME as Visitante_Nome, CPF as Visitante_Cpf from VISITANTES";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable TodasVisitas()
        {
            command.CommandText = "select VISITAS.ID, PACIENTES.NOME as Nome_Paciente, PACIENTES.CPF as Cpf_Paciente, QUARTOID as Numero_Quarto, " +
                "FORMAT(VISITAS.DATAVISITA, 'dd/MM/yyyy HH:mm') as Data_Visita, VISITANTES.NOME as Nome_Visitante, VISITANTES.CPF as Cpf_Visitante from " +
                "INTERNACAO inner join VISITAS on VISITAS.INTERNACAOID = INTERNACAO.ID inner join PACIENTES on INTERNACAO.PACIENTEID = PACIENTES.ID inner join " +
                "VISITANTES on VISITAS.VISITANTEID = VISITANTES.ID";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable PesquisarVisitante(string p_NomeVisitante)
        {
            SqlCommand command = new SqlCommand("select VISITAS.ID, PACIENTES.NOME as Nome_Paciente, PACIENTES.CPF as Cpf_Paciente, QUARTOID as Numero_Quarto, " +
                    "FORMAT(VISITAS.DATAVISITA, 'dd/MM/yyyy HH:mm') as Data_Visita, VISITANTES.NOME as Nome_Visitante, VISITANTES.CPF as Cpf_Visitante from " +
                    "INTERNACAO inner join VISITAS on VISITAS.INTERNACAOID = INTERNACAO.ID inner join PACIENTES on INTERNACAO.PACIENTEID = PACIENTES.ID inner join " +
                    "VISITANTES on VISITAS.VISITANTEID = VISITANTES.ID where VISITANTES.NOME = @NomeVisitante", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@NomeVisitante", p_NomeVisitante);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        } 
        
        public void GetDadosVisitante(int p_IdVisitante, string p_CpfVisitante)
        {
            Visitante visitante = new Visitante();
            SqlCommand command = new SqlCommand("select * from VISITANTES where ID = @IdVisitante or CPF = @CpfVisitante", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdVisitante", p_IdVisitante);
            command.Parameters.AddWithValue("@CpfVisitante", p_CpfVisitante);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                visitante.Id = (int)reader["ID"];
                visitante.Nome = reader["NOME"].ToString();
                visitante.Cpf = reader["CPF"].ToString();
            }
            FuncionarioLogado.SetVisitanteSelecionado(visitante);
            conexao.Desconectar();
        }
    }
}