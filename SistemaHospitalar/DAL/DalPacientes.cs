using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
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
            command.Parameters.AddWithValue("@id", Id);
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

        public static int Id { get; set; }
        public static string Nome { get; set; }



        //Pega o ID do Convenio selecionado para cadastrar no Paciente
        public int DetectarConvenio(string p_nomeConvenio)
        {
            SqlCommand command = new SqlCommand("select * from CONVENIOS where nome = @nome", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", p_nomeConvenio);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Id = (int)reader["ID"];
                }
            }
            conexao.Desconectar();
            return Id;
        }

        public static DataTable MostrarPacientesDGV()
        {
            command.CommandText = "select PACIENTES.ID, PACIENTES.NOME, PACIENTES.CPF, PACIENTES.CELULAR, PACIENTES.GENERO, CONVENIOS.NOME as CONVENIO " +
                "from PACIENTES inner join CONVENIOS ON CONVENIOS.ID = PACIENTES.CONVENIOID";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static ArrayList MostrarCPFPacientes()
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

        //Procura o Paciente pelo nome
        public static DataTable PesquisarPaciente(string p_nome)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", p_nome);
            command.CommandText = "select * from PACIENTES where Nome = @nome";

            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //Pega um Paciente pelo CPF
        public static string IdentificarPaciente(string p_CpfPaciente)
        {
            SqlCommand command = new SqlCommand("select * from PACIENTES where CPF = @cpf", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@cpf", p_CpfPaciente);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Nome = reader["NOME"].ToString();
                Id = (int)reader["ID"];
            }
            conexao.Desconectar();
            return Nome;
        }
    }
}
