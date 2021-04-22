using System;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class Backup : DalComandos
    {
        public string Backupear()
        {
            string sql = "Select * into bkpADM from ADM";
            SqlCommand command = new SqlCommand(sql, conexao.Conectar());
            command.ExecuteNonQuery();
            conexao.Desconectar();

            string sql2 = "Select * into bkpConsultas from CONSULTAS";
            SqlCommand command2 = new SqlCommand(sql2, conexao.Conectar());
            command2.ExecuteNonQuery();
            conexao.Desconectar();

            string sql3 = "Select * into bkpConvenios from CONVENIOS";
            SqlCommand command3 = new SqlCommand(sql3, conexao.Conectar());
            command3.ExecuteNonQuery();
            conexao.Desconectar();

            string sql4 = "Select * into bkpDiagnosticos from DIAGNOSTICOS";
            SqlCommand command4 = new SqlCommand(sql4, conexao.Conectar());
            command4.ExecuteNonQuery();
            conexao.Desconectar();

            string sql5 = "Select * into bkpDoutores from DOUTORES";
            SqlCommand command5 = new SqlCommand(sql5, conexao.Conectar());
            command5.ExecuteNonQuery();
            conexao.Desconectar();

            string sql6 = "Select * into bkpExames from EXAMES;";
            SqlCommand command6 = new SqlCommand(sql6, conexao.Conectar());
            command6.ExecuteNonQuery();
            conexao.Desconectar();

            string sql7 = "Select * into bkpInternacao from INTERNACAO";
            SqlCommand command7 = new SqlCommand(sql7, conexao.Conectar());
            command7.ExecuteNonQuery();
            conexao.Desconectar();

            string sql8 = "Select * into bkpPacientes from PACIENTES";
            SqlCommand command8 = new SqlCommand(sql8, conexao.Conectar());
            command8.ExecuteNonQuery();
            conexao.Desconectar();

            string sql9 = "Select * into bkpQuartos from QUARTOS";
            SqlCommand command9 = new SqlCommand(sql9, conexao.Conectar());
            command9.ExecuteNonQuery();
            conexao.Desconectar();

            string sqll0 = "Select * into bkpRecepcionistas from RECEPCIONISTAS";
            SqlCommand command10 = new SqlCommand(sqll0, conexao.Conectar());
            command10.ExecuteNonQuery();
            conexao.Desconectar();

            string sql11 = "Select * into bkpVisitantes from VISITANTES";
            SqlCommand command11 = new SqlCommand(sql11, conexao.Conectar());
            command11.ExecuteNonQuery();
            conexao.Desconectar();

            string sql12 = "Select * into bkpVisitas from VISITAS";
            SqlCommand command12 = new SqlCommand(sql12, conexao.Conectar());
            command12.ExecuteNonQuery();
            conexao.Desconectar();

            return "Backup de todas as tabelas feitas com sucesso!";
        }
    }
}
