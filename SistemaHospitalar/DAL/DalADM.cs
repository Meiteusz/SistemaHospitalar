using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
using System;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalADM : DalComandos
    {
        public string OutPut = "";
        private bool isLoginExistente = false;

        public bool isAcessoValido(ADM adm)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@usuario", adm.Usuario);
            command.Parameters.AddWithValue("@senha", adm.Senha);

            command.CommandText = "select * from ADM where Usuario = @usuario and Senha = @senha and isAtivo = 1";

            try
            {
                command.Connection = conexao.Conectar();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isLoginExistente = true;
                    GetDadosADM(reader);
                }
                else
                {
                    OutPut = "Conta ADM não encontrada";
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

        public string AtualizarValorInternacao(ADM adm)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@USUARIO", adm.Usuario);
            command.Parameters.AddWithValue("@SENHA", adm.Senha);
            command.Parameters.AddWithValue("@VALORDIARIOINTERNACAO", adm.ValorDiarioInternacao);

            command.CommandText = "update ADM set VALORDIARIOINTERNACAO = @VALORDIARIOINTERNACAO where USUARIO = @USUARIO and SENHA = @SENHA";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Valor diario da internação atualizado com sucesso!";
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

        public void GetDadosADM(SqlDataReader reader)
        {
            ADM adm = new ADM();

            while (reader.Read())
            {
                adm.Usuario = reader["USUARIO"].ToString();
                adm.Senha = reader["SENHA"].ToString();
                adm.ValorDiarioInternacao = Convert.ToSingle(reader["VALORDIARIOINTERNACAO"]);
            }
            FuncionarioLogado.SetADM(adm);
        }

        public void GetValorDiarioAdmAtivo()
        {
            SqlCommand command = new SqlCommand("select VALORDIARIOINTERNACAO from ADM where isAtivo = 1", conexao.Conectar());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    FuncionarioLogado.SetValorDiarioInternacaoADM(Convert.ToSingle(reader["VALORDIARIOINTERNACAO"]));
                }
            }
            conexao.Desconectar();
        }
    }
}
