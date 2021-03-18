using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalDoutores : DalComandos
    {
        DoutoresBLL doutoresBLL = new DoutoresBLL();

        public string OutPut { get; set; }
        public bool isLoginExistente { get; set; }

        public static string Id { get; set; }
        public static string Nome { get; set; }
        public static string Email { get; set; }
        public static string Senha { get; set; }
        public static string Turno { get; set; }
        public static string Celular { get; set; }
        public static string Especialidade { get; set; }

        public string NomeDoutor { get; set; }

        //Verifica se o login é existente
        public bool isLoginValido(Doutores doutor)
        {
            OutPut = "";
            isLoginExistente = false;

            command.Parameters.AddWithValue("@email", doutor.Email);
            command.Parameters.AddWithValue("@senha", doutor.Senha);
            command.CommandText = "select * from DOUTORES where email = @email and senha = @senha";
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
                        Especialidade = reader["ESPECIALIDADE"].ToString();

                        Enum.TryParse(Turno, out Turno turnoConvertido);  //Faz o Parse para string
                        Turno = turnoConvertido.ToString();               //Devolve o valor convertido para o "Turno"

                        Enum.TryParse(Especialidade, out Especialidades especialidadeConvertida);
                        Especialidade = especialidadeConvertida.ToString();

                        NomeDoutor = Nome;
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
                OutPut = "Erro com o Banco de Dados" + ex.Message;
            }
            finally
            {
                conexao.Desconectar();
            }
            return isLoginExistente;
        }

        //Cadastra um Doutor
        public string Cadastrar(Doutores doutor, string confSenha)
        {
            if (doutoresBLL.ValidarDoutor(doutor, confSenha).Equals(""))
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@nome", doutor.Nome);
                command.Parameters.AddWithValue("@email", doutor.Email);
                command.Parameters.AddWithValue("@senha", doutor.Senha);
                command.Parameters.AddWithValue("@cpf", doutor.Cpf);
                command.Parameters.AddWithValue("@turno", doutor.Turno);
                command.Parameters.AddWithValue("@genero", doutor.Genero);
                command.Parameters.AddWithValue("@celular", doutor.Celular);
                command.Parameters.AddWithValue("@especialidade", doutor.Especialidade);

                command.CommandText = "insert into DOUTORES values(@nome, @email, @senha, @cpf, @turno, @genero, @celular, @especialidade)";
                try
                {
                    command.Connection = conexao.Conectar();
                    command.ExecuteNonQuery();
                    return "Doutor(a) cadastrado com sucesso";
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
                return doutoresBLL.Status;
            }
        }

        //Deleta um Doutor
        public string Deletar(int Id)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", Id);
            command.CommandText = "delete from DOUTORES where id = @ID";
            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Conta deletada com sucesso";
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

        //Atualiza as informações de um Doutor
        public string AtualizarInformacoes(Doutores doutores, string confSenha)
        {
            if (doutoresBLL.ValidarAlteracoesDoutor(doutores, confSenha).Equals(""))
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ID", Id);
                command.Parameters.AddWithValue("@NOME", doutores.Nome);
                command.Parameters.AddWithValue("@EMAIL", doutores.Email);
                command.Parameters.AddWithValue("@CELULAR", doutores.Celular);
                command.Parameters.AddWithValue("@TURNO", doutores.Turno);
                command.Parameters.AddWithValue("@SENHA", doutores.Senha);
                command.CommandText = "update DOUTORES set NOME = @NOME, EMAIL = @EMAIL, CELULAR = @CELULAR, TURNO = @TURNO, SENHA = @SENHA where ID = @ID  ";
                try
                {
                    command.Connection = conexao.Conectar();
                    command.ExecuteNonQuery();
                    return "Informações alteradas com sucesso";
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
                return doutoresBLL.Status;
            }
        }

        public static DataTable MostrarDoutores()
        {
            command.CommandText = "select * from DOUTORES";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable PesquisarDoutor(string p_nome, Turno p_turno, Especialidades p_especialidade)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome",p_nome);
            command.Parameters.AddWithValue("@turno",p_turno);
            command.Parameters.AddWithValue("@especialidade", p_especialidade);
            command.CommandText = "select * from DOUTORES where Nome = @nome or Turno = @turno or Especialidade = @especialidade";

            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable PesquisarEspecialidade(Especialidades p_especialidade)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@especialidade", p_especialidade);
            command.CommandText = "select ID, NOME, ESPECIALIDADE from DOUTORES where ESPECIALIDADE = @especialidade";

            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private static string ValorConsulta { get; set; }
        public static string PegarValorConsulta(int p_doutorId)
        {
            SqlCommand command = new SqlCommand("select VALORCONSULTA from VALORES where doutorid = @doutorid", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@doutorId", p_doutorId);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ValorConsulta = reader["VALORCONSULTA"].ToString();
            }
            conexao.Desconectar();
            return ValorConsulta;
        }
    }
}
