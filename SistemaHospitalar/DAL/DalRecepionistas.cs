using SistemaHospitalar.BLL;
using SistemaHospitalar.Models;
using SistemaHospitalar.UI;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalRecepionistas : DalComandos
    {
        // MELHORAR A CONSTRUÇÃO DO CÓDIGO 
        public string OutPut { get; set; }

        //public static string Id, Nome, Email, Turno, Senha, Celular; // MUDAR PARA USAR O OBJETO "RECEPCIONISTA"

        //public static int Id { get; set; }


        //Loga um Recepcionista
        public bool isLoginValido(Recepcionista recepcionista)
        {
            bool isLoginExistente = false;

            command.Parameters.AddWithValue("@email", recepcionista.Email);
            command.Parameters.AddWithValue("@senha", recepcionista.Senha);

            command.CommandText = "select * from RECEPCIONISTAS where email = @email and senha = @senha";

            try
            {
                command.Connection = conexao.Conectar();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        RecepcionistaBLL.Id = (int)reader["ID"];
                        recepcionista.Nome = reader["NOME"].ToString();
                    }
                    isLoginExistente = true;
                }
                else
                {
                    OutPut = "Login não encontrado";
                    command.Parameters.Clear();
                }
            }
            catch (SqlException ex)
            {
                OutPut = "Erro com Banco de Dados" + ex.Message;
            }
            finally
            {
                conexao.Desconectar();
            }
            return isLoginExistente;
        }


        //Pega todos os dados do Recepcionista
        public static Recepcionista PegarDadosRecepcionista(int p_id)
        {
            Recepcionista recepcionista = new Recepcionista();

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Id", p_id);

            command.CommandText = "select * from RECEPCIONISTAS where ID = @Id";

            command.Connection = conexao.Conectar();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                recepcionista.Nome = reader["NOME"].ToString();
                recepcionista.Email = reader["EMAIL"].ToString();
                recepcionista.Celular = reader["CELULAR"].ToString();
                recepcionista.Senha = reader["SENHA"].ToString();

                Enum.TryParse(reader["TURNO"].ToString(), out Turno turnoConvertido);  //Faz o Parse para string
                recepcionista.Turno = turnoConvertido;                                     //Devolve o valor convertido para o "Turno"
            }
            return recepcionista;
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
