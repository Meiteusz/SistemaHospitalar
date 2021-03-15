using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
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
                command.Parameters.AddWithValue("@celular", paciente.Celular);
                command.Parameters.AddWithValue("@genero", paciente.Genero);

                command.CommandText = "insert into PACIENTES (NOME, CPF, CELULAR, GENERO) values (@nome, @cpf, @celular, @genero)";
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
    }
}
