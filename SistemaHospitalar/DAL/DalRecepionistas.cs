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

        RecepcionistaBLL recepcionistaBLL = new RecepcionistaBLL();

        public string OutPut { get; set; }
        public bool isLoginExistente { get; set; }

        public static string Id, Nome, Email, Turno, Senha, Celular; // MUDAR PARA USAR O OBJETO "RECEPCIONISTA"

        public string NomeRecepcionista = ""; // Pega o nome do(a) recepcionista para a label do formEntradaRecepcionista



        //Loga um Recepcionista
        public bool isLoginValido(Recepcionista recepcionista)
        {
            OutPut = "";
            isLoginExistente = false;

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
                        Id = reader["ID"].ToString();
                        Nome = reader["NOME"].ToString();
                        Email = reader["EMAIL"].ToString();
                        Senha = reader["SENHA"].ToString();
                        Turno = reader["TURNO"].ToString();
                        Celular = reader["CELULAR"].ToString();

                        Enum.TryParse(Turno, out Turno turnoConvertido);  //Faz o Parse para string
                        Turno = turnoConvertido.ToString();               //Devolve o valor convertido para o "Turno"

                        NomeRecepcionista = Nome;
                        break; //Só para ter certeza que irá sair do while
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



        //Cadastra um Recepcionista
        public string Cadastrar(Recepcionista recepcionista, string confSenha)
        {
            if (recepcionistaBLL.ValidarRecepcionista(recepcionista, confSenha).Equals(""))
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nome", recepcionista.Nome);
                command.Parameters.AddWithValue("@email", recepcionista.Email);
                command.Parameters.AddWithValue("@senha", recepcionista.Senha);
                command.Parameters.AddWithValue("@cpf", recepcionista.Cpf);
                command.Parameters.AddWithValue("@turno", recepcionista.Turno);
                command.Parameters.AddWithValue("@genero", recepcionista.Genero);
                command.Parameters.AddWithValue("@celular", recepcionista.Celular);

                command.CommandText = "insert into RECEPCIONISTAS values(@nome, @email, @senha, @cpf, @turno, @genero, @celular)";
                try
                {
                    command.Connection = conexao.Conectar();
                    command.ExecuteNonQuery();
                    return "Recepcionista cadastrado com sucesso";
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
            else
            {
                return recepcionistaBLL.Status;
            }
        }



        //Deletar um Recepcionista
        public string Deletar(int Id)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", Id);
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
        public string AtualizarInformacoes(Recepcionista recepcionista, string confSenha)
        {
            if (recepcionistaBLL.ValidarAlteracoesRecepcionista(recepcionista, confSenha).Equals(""))
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ID", Id);
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
            else
            {
                return recepcionistaBLL.Status;
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
