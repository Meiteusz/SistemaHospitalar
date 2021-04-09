using SistemaHospitalar.Models;
using SistemaHospitalar.Utilities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    public class DalComandos
    {
        public static Conexao conexao = new Conexao();
        public static SqlCommand command = new SqlCommand();
        public static DataTable dt;
        public static SqlDataAdapter adapter;

        public virtual string MostrarTipoErro(SqlException ex)
        {
            string erro = "";
            if (ex.Number == 2627)
                erro = "Já existe este CPF cadastrado!";
            else
                erro = " Erro com o banco de dados " + ex.Message;
            return erro;
        }

        public virtual void GetDadosFuncionarioLogado(SqlDataReader p_reader)
        {
            Recepcionista recepcionista = new Recepcionista();

            while (p_reader.Read())
            {
                Enum.TryParse(p_reader["TURNO"].ToString(), out Turno turnoConvertido);
                recepcionista.Id = (int)p_reader["ID"];
                recepcionista.Nome = p_reader["NOME"].ToString();
                recepcionista.Email = p_reader["EMAIL"].ToString();
                recepcionista.Celular = p_reader["CELULAR"].ToString();
                recepcionista.Turno = turnoConvertido;
                recepcionista.Senha = p_reader["SENHA"].ToString();
            }
            FuncionarioLogado.SetFuncionarioLogado(recepcionista);
        }
    }
}
