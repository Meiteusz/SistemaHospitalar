using SistemaHospitalar.Models;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalRecepcionistas : DalComandos
    {

        //Loga um Recepcionista
        public string OutPut { get; set; }
        public bool isLoginValido(Recepcionista recepcionista)
        {
            bool isLoginExistente = false;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@email", recepcionista.Email);
            command.Parameters.AddWithValue("@senha", recepcionista.Senha);

            command.CommandText = "select * from RECEPCIONISTAS where email = @email and senha = @senha";

            try
            {
                command.Connection = conexao.Conectar();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    isLoginExistente = true;
                    GetDadosFuncionarioLogado(reader);
                }
                else
                {
                    OutPut = "Login não encontrado";
                }
            }
            catch (SqlException ex)
            {
                OutPut = MostrarTipoErro(ex);
            }
            finally
            {
                conexao.Desconectar();
            }
            return isLoginExistente;
        }


        //Cadastra um Recepcionista
        public string Insert(Recepcionista p_recepcionista, string p_confSenha)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", p_recepcionista.Nome);
            command.Parameters.AddWithValue("@email", p_recepcionista.Email);
            command.Parameters.AddWithValue("@senha", p_recepcionista.Senha);
            command.Parameters.AddWithValue("@cpf", p_recepcionista.Cpf);
            command.Parameters.AddWithValue("@turno", p_recepcionista.Turno);
            command.Parameters.AddWithValue("@genero", p_recepcionista.Genero);
            command.Parameters.AddWithValue("@celular", p_recepcionista.Celular);

            command.CommandText = "insert into RECEPCIONISTAS values(@nome, @email, @senha, @cpf, @turno, @genero, @celular)";
            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Recepcionista cadastrado com sucesso";
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


        //Deletar um Recepcionista
        public string Delete(int p_Id)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", p_Id);
            command.CommandText = "delete from RECEPCIONISTAS where ID = @ID";
            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Conta deletada com sucesso";
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


        //Atualiza as informações de um Recepcionista
        public string Update(Recepcionista recepcionista, string confSenha)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", recepcionista.Id);
            command.Parameters.AddWithValue("@NOME", recepcionista.Nome);
            command.Parameters.AddWithValue("@EMAIL", recepcionista.Email);
            command.Parameters.AddWithValue("@CELULAR", recepcionista.Celular);
            command.Parameters.AddWithValue("@TURNO", recepcionista.Turno);
            command.Parameters.AddWithValue("@SENHA", recepcionista.Senha);
            command.CommandText = "update RECEPCIONISTAS set NOME = @NOME, EMAIL = @EMAIL, CELULAR = @CELULAR, TURNO = @TURNO, SENHA = @SENHA where ID = @ID";
            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Informações Alteradas com Sucesso";
            }
            catch (SqlException ex)
            {
                return "Erro com o Banco de Dados " + ex.Message;
            }
            finally
            {
                conexao.Desconectar();
            }
        }


        public static DataTable MostrarRecepcionistas()
        {
            command.CommandText = "select * from RECEPCIONISTAS";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        public static DataTable PesquisarRecepcionistas(string p_nome, Turno p_turno)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", p_nome);
            command.Parameters.AddWithValue("@turno", p_turno);
            command.CommandText = "select * from RECEPCIONISTAS where Nome = @nome or Turno = @turno";

            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
