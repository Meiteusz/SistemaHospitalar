using SistemaHospitalar.DAL;
using SistemaHospitalar.Utilities;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.Models
{
    public class DalPacientes : DalComandos
    {
        public string Insert(Paciente p_paciente)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", p_paciente.Nome);
            command.Parameters.AddWithValue("@cpf", p_paciente.Cpf);
            command.Parameters.AddWithValue("@celular", p_paciente.Celular);
            command.Parameters.AddWithValue("@genero", p_paciente.Genero);
            command.Parameters.AddWithValue("@convenio", p_paciente.Convenio);

            command.CommandText = "insert into PACIENTES values (@nome, @cpf, @celular, @genero, @convenio)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Paciente cadastrado com sucesso";
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

        public string Delete(int p_Id)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", p_Id);
            command.CommandText = "delete PACIENTES where id = @id";
            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Paciente deletado com sucesso";
            }
            catch (SqlException ex)
            {
                return "Erro com o Banco de Dados" + ex.Message;
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void GetDadosPaciente(int p_IdPaciente, string p_CpfPaciente)
        {
            Paciente paciente = new Paciente();

            SqlCommand command = new SqlCommand("select * from PACIENTES where ID = @Id or CPF = @Cpf", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Id", p_IdPaciente);
            command.Parameters.AddWithValue("@Cpf", p_CpfPaciente);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Enum.TryParse(reader["GENERO"].ToString(), out Genero generoConvertido);

                paciente.Id = (int)reader["ID"];
                paciente.Nome = reader["NOME"].ToString();
                paciente.Cpf = reader["CPF"].ToString();
                paciente.Celular = reader["CELULAR"].ToString();
                paciente.Genero = generoConvertido;
                paciente.Convenio = (int)reader["CONVENIOID"];
            }
            conexao.Desconectar();
            FuncionarioLogado.SetPacienteSelecionado(paciente);
        }

        public Paciente GetPacienteByCpf(string p_CpfPaciente)
        {
            Paciente paciente = new Paciente();

            SqlCommand command = new SqlCommand("select * from PACIENTES where CPF = @Cpf", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Cpf", p_CpfPaciente);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Enum.TryParse(reader["GENERO"].ToString(), out Genero generoConvertido);

                paciente.Id = (int)reader["ID"];
                paciente.Nome = reader["NOME"].ToString();
                paciente.Cpf = reader["CPF"].ToString();
                paciente.Celular = reader["CELULAR"].ToString();
                paciente.Genero = generoConvertido;
                paciente.Convenio = (int)reader["CONVENIOID"];
            }
            conexao.Desconectar();
            return paciente;
        }

        public int GetIdConvenioPeloNome(string p_nomeConvenio)
        {
            int IdConvenio = 0;

            SqlCommand command = new SqlCommand("select * from CONVENIOS where nome = @nome", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", p_nomeConvenio);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    IdConvenio = (int)reader["ID"];
                }
            }
            conexao.Desconectar();
            return IdConvenio;
        }

        public ArrayList GetCpfPacientes()
        {
            ArrayList pacientes = new ArrayList();
            adapter = new SqlDataAdapter("select CPF from PACIENTES", conexao.Conectar());
            dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                pacientes.Add(item["CPF"].ToString());
            }
            conexao.Desconectar();
            return pacientes;
        }

        public ArrayList MostrarCpfPacientesInternados()
        {
            ArrayList pacientes = new ArrayList();
            adapter = new SqlDataAdapter("select CPF from PACIENTES where ID IN (select PACIENTEID from INTERNACAO where " +
                "INTERNACAO.DATASAIDA is null)", conexao.Conectar());
            dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                pacientes.Add(item["CPF"].ToString());
            }
            conexao.Desconectar();
            return pacientes;
        }

        public ArrayList MostrarCpfPacientesNaoInternados()
        {
            ArrayList pacientes = new ArrayList();
            adapter = new SqlDataAdapter(
                "select CPF from PACIENTES where ID NOT IN " +
                "(select PACIENTEID from INTERNACAO)"
                , conexao.Conectar());
            dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                pacientes.Add(item["CPF"].ToString());
            }
            conexao.Desconectar();
            return pacientes;
        }

        public DataTable TodosPacientes()
        {
            command.CommandText = "select PACIENTES.ID, PACIENTES.NOME as Paciente_Nome, PACIENTES.CPF as Paciente_Cpf, PACIENTES.CELULAR as Paciente_Celular, " +
                "PACIENTES.GENERO as Paciente_Genero, CONVENIOS.NOME as Convênio_Nome from PACIENTES inner join CONVENIOS ON CONVENIOS.ID = PACIENTES.CONVENIOID";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable PesquisaDePacientes(string p_nome)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", p_nome);
            command.CommandText = "select * from PACIENTES where Nome = @nome";

            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
