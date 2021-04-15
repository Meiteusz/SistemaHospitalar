using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using SistemaHospitalar.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalDoutores : DalComandos
    {
        public string OutPut { get; private set; }
        public bool isLoginValido(Doutores doutor)
        {
            bool isLoginExistente = false;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@email", doutor.Email);
            command.Parameters.AddWithValue("@senha", doutor.Senha);

            command.CommandText = "select * from DOUTORES where email = @email and senha = @senha";

            try
            {
                command.Connection = conexao.Conectar();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    GetDadosFuncionarioLogado(reader);
                    isLoginExistente = true;
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

        public string Insert(Doutores p_doutor, string p_confSenha)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", p_doutor.Nome);
            command.Parameters.AddWithValue("@email", p_doutor.Email);
            command.Parameters.AddWithValue("@senha", p_doutor.Senha);
            command.Parameters.AddWithValue("@cpf", p_doutor.Cpf);
            command.Parameters.AddWithValue("@turno", p_doutor.Turno);
            command.Parameters.AddWithValue("@genero", p_doutor.Genero);
            command.Parameters.AddWithValue("@celular", p_doutor.Celular);
            command.Parameters.AddWithValue("@especialidade", p_doutor.Especialidade);
            command.Parameters.AddWithValue("@valorConsulta", p_doutor.ValorConsulta);
            command.Parameters.AddWithValue("@valorExame", p_doutor.ValorExame);

            command.CommandText = "insert into DOUTORES values(@nome, @email, @senha, @cpf, @turno, @genero, @celular, @especialidade, @valorConsulta, @valorExame)";

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

        public string Delete(int p_Id)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", p_Id);
            command.CommandText = "delete from DOUTORES where id = @ID";
            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Conta deletada com sucesso";
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

        public string Update(Doutores p_doutores, string p_confSenha)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", FuncionarioLogado.DoutorLogado.Id);
            command.Parameters.AddWithValue("@NOME", p_doutores.Nome);
            command.Parameters.AddWithValue("@EMAIL", p_doutores.Email);
            command.Parameters.AddWithValue("@CELULAR", p_doutores.Celular);
            command.Parameters.AddWithValue("@TURNO", p_doutores.Turno);
            command.Parameters.AddWithValue("@SENHA", p_doutores.Senha);
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

        public override void GetDadosFuncionarioLogado(SqlDataReader p_reader)
        {
            Doutores doutor = new Doutores();

            while (p_reader.Read())
            {
                Enum.TryParse(p_reader["TURNO"].ToString(), out Turno TurnoConvertido);
                Enum.TryParse(p_reader["ESPECIALIDADE"].ToString(), out Especialidades EspecialidadeConvertida);

                doutor.Id = (int)p_reader["ID"];
                doutor.Nome = p_reader["NOME"].ToString();
                doutor.Email = p_reader["EMAIL"].ToString();
                doutor.Celular = p_reader["CELULAR"].ToString();
                doutor.Turno = TurnoConvertido;
                doutor.Senha = p_reader["SENHA"].ToString();
                doutor.Especialidade = EspecialidadeConvertida;
                doutor.ValorConsulta = Convert.ToSingle(p_reader["VALORCONSULTA"]);
                doutor.ValorExame = Convert.ToSingle(p_reader["VALOREXAME"]);
            }
            FuncionarioLogado.SetFuncionarioLogado(doutor);
        }

        public string UpdateValores(float p_valorConsulta, float p_valorExame)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ID", FuncionarioLogado.DoutorLogado.Id);
            command.Parameters.AddWithValue("@VALORCONSULTA", p_valorConsulta);
            command.Parameters.AddWithValue("@VALOREXAME", p_valorExame);
            command.CommandText = "update DOUTORES set VALORCONSULTA = @VALORCONSULTA, VALOREXAME = @VALOREXAME where ID = @ID  ";
            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Valores alteradas com sucesso\nLogue novamente para as alterações serem confirmadas!";
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

        public Doutores GetDadosDoutorPeloID(int p_IdDoutor)
        {
            Doutores doutor = new Doutores();
            SqlCommand command = new SqlCommand("select * from DOUTORES where ID = @IdDoutor", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdDoutor", p_IdDoutor);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Enum.TryParse(reader["TURNO"].ToString(), out Turno TurnoConvertido);
                Enum.TryParse(reader["ESPECIALIDADE"].ToString(), out Especialidades EspecialidadeConvertida);

                doutor.Id = (int)reader["ID"];
                doutor.Nome = reader["NOME"].ToString();
                doutor.Celular = reader["CELULAR"].ToString();
                doutor.Turno = TurnoConvertido;
                doutor.Especialidade = EspecialidadeConvertida;
                doutor.ValorConsulta = Convert.ToSingle(reader["VALORCONSULTA"]);
                doutor.ValorExame = Convert.ToSingle(reader["VALOREXAME"]);
            }
            conexao.Desconectar();
            return doutor;
        }

        public DataTable TodosDoutores()
        {
            command.CommandText = "select NOME, CPF, TURNO, GENERO, CELULAR, ESPECIALIDADE, VALORCONSULTA, VALOREXAME from DOUTORES";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable PesquisaDeDoutores(string p_nome, Turno p_turno, Especialidades p_especialidade)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nome", p_nome);
            command.Parameters.AddWithValue("@turno", p_turno);
            command.Parameters.AddWithValue("@especialidade", p_especialidade);
            command.CommandText = "select NOME, CPF, TURNO, GENERO, CELULAR, ESPECIALIDADE, VALORCONSULTA, VALOREXAME from DOUTORES where Nome = @nome or Turno = @turno or Especialidade = @especialidade";

            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetDoutoresConsulta(Especialidades p_especialidade)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@especialidade", p_especialidade);
            command.CommandText = "select ID, NOME, ESPECIALIDADE, VALORCONSULTA from DOUTORES where ESPECIALIDADE = @especialidade";

            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetDoutoresInternacao(Especialidades p_especialidade)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@especialidade", p_especialidade);
            command.CommandText = "select ID, NOME, ESPECIALIDADE, CPF from DOUTORES where ESPECIALIDADE = @especialidade";

            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
