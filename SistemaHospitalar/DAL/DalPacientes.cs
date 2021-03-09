using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.Models
{
    public class DalPacientes : DalComandos
    {
        PacienteBLL pacienteBLL = new PacienteBLL();

        public string Cadastrar(Paciente paciente)
        {
            if (pacienteBLL.ValidarPaciente(paciente).Equals(""))
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nome", paciente.Nome);
                command.Parameters.AddWithValue("@cpf", paciente.Cpf);
                command.Parameters.AddWithValue("@celular_1", paciente.Celular);
                command.Parameters.AddWithValue("@genero", paciente.Genero);
                command.Parameters.AddWithValue("@gravidade", paciente.Gravidade);
                command.Parameters.AddWithValue("@dataEntrada", paciente.DataEntrada);
                command.Parameters.AddWithValue("@dataSaida", paciente.DataSaida);
                command.Parameters.AddWithValue("@celular_2", paciente.Celular2);
                command.Parameters.AddWithValue("@templano", paciente.isPlano);
                command.CommandText = "insert into PACIENTES (NOME, CPF, CELULAR_1, GENERO, GRAVIDADE, DATAENTRADA, DATASAIDA, TEMPLANO ,CELULAR_2) values (@nome, @cpf, @celular_1," +
                    " @genero, @gravidade, @dataEntrada, @dataSaida, @templano ,@celular_2)";
                try
                {
                    command.Connection = conexao.Conectar();
                    command.ExecuteNonQuery();
                    return "Paciente cadastrado com sucesso";
                }
                catch (SqlException ex)
                {
                    return "Erro com o banco de dados" + ex.Message;
                }
                finally
                {
                    conexao.Desconectar();
                }
            }
            else
            {
                return pacienteBLL.Status;
            }
        }

        public string Deletar(int Id)
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

        public static DataTable MostrarPacientesDGV()
        {
            command.CommandText = "select * from PACIENTES";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable PesquisarPaciente(string p_nome, Gravidade p_gravidade)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", p_nome);
            command.Parameters.AddWithValue("@gravidade", p_gravidade);
            command.CommandText = "select * from PACIENTES where Nome = @nome or Gravidade = @gravidade";

            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
