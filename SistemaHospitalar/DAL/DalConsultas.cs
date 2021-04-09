﻿using SistemaHospitalar.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalConsultas : DalComandos
    {
        public static int Id { get; set; }
        public static string DataConsulta { get; set; }
        public static string NomePaciente { get; set; }

        public string AgendarConsulta(Consulta consulta)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@estado", consulta.Estado);
            command.Parameters.AddWithValue("@paciente", consulta.Paciente);
            command.Parameters.AddWithValue("@doutor", consulta.Doutor);
            command.Parameters.AddWithValue("@dataConsulta", consulta.DataConsulta);
            command.Parameters.AddWithValue("@preco", consulta.Preco);
            command.CommandText = "insert into CONSULTAS values(@estado, @paciente, @doutor, @dataConsulta, @preco)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Consulta agendada com sucesso!";
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

        public string DeletarConsulta(int p_id)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", p_id);
            command.CommandText = "delete CONSULTAS where id = @id";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Consulta deletada com sucesso!";
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

        public string ReagendarConsulta(DateTime p_dataConsulta, int p_id)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@dataConsulta", p_dataConsulta);
            command.Parameters.AddWithValue("@id", p_id);
            command.CommandText = "update CONSULTAS set DATACONSULTA = @dataConsulta where Id = @id";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Consulta reagendada com sucesso";
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

        // Verifica se há alguma consulta ja cadastrada na data/hora que foi informada
        public static bool isDataConsultaValido(DateTime p_dataConsulta, int p_idPaciente, int p_idDoutor)
        {
            bool isValido = true;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@dataConsulta", p_dataConsulta);
            command.Parameters.AddWithValue("@idPaciente", p_idPaciente);
            command.Parameters.AddWithValue("@idDoutor", p_idDoutor);

            command.CommandText = "select PACIENTEID, DOUTORID, FORMAT(DATACONSULTA , 'dd/MM/yyyy HH:mm') as DataConsulta from CONSULTAS where DATACONSULTA = @dataConsulta" +
                " AND (PACIENTEID = @idPaciente OR DOUTORID = @idDoutor)";

            command.Connection = conexao.Conectar();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                isValido = false;
            }
            conexao.Desconectar();
            return isValido;
        }

        //Pega o valor do desconto de acordo com o convênio do paciente
        public static string ValorDescontoConvenio(int p_idPaciente)
        {
            int idConvenio = DalConvenios.IndentificarConvenio(p_idPaciente);
            string valorDesconto = "";

            SqlCommand command = new SqlCommand("select DESCONTO from CONVENIOS where ID = @id", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", idConvenio);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                valorDesconto = reader["DESCONTO"].ToString();
            }
            conexao.Desconectar();
            return valorDesconto;
        }

        public static DataTable MostrarConsultas()
        {
            command.CommandText = "select CONSULTAS.ID, CONSULTAS.ESTADO as Estado_Consulta, PACIENTES.NOME as Paciente_Nome, DOUTORES.NOME as Doutor_Nome, " +
                "FORMAT(CONSULTAS.DATACONSULTA, 'dd/MM/yyyy HH:mm') as DataHorarioConsulta, FORMAT(CONSULTAS.PRECO, 'c', 'pt-br') as ValorConsulta, CONVENIOS.NOME as Convênio_Nome " +
                "from CONSULTAS inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID inner join DOUTORES on DOUTORES.ID = DOUTORID inner join CONVENIOS on CONVENIOS.ID = CONVENIOID";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable MostrarConsultasHoje()
        {
            command.CommandText = "select CONSULTAS.ID, CONSULTAS.ESTADO as Estado_Consulta, PACIENTES.NOME as Paciente_Nome, DOUTORES.NOME as Doutor_Nome, " +
                "FORMAT(CONSULTAS.DATACONSULTA, 'dd/MM/yyyy HH:mm') as DataHorarioConsulta, FORMAT(CONSULTAS.PRECO, 'c', 'pt-br') as ValorConsulta, CONVENIOS.NOME as " +
                "Convênio_Nome from CONSULTAS inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID inner join DOUTORES on DOUTORES.ID = DOUTORID inner join " +
                "CONVENIOS on CONVENIOS.ID = CONVENIOID where CONVERT(DATE, CONSULTAS.DATACONSULTA) = Convert(date, getdate())";
            
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable MostrarConsultasParaDoutor(int p_IdDoutor)
        {
            SqlCommand command = new SqlCommand("select CONSULTAS.ID, PACIENTES.NOME as Paciente_Nome, FORMAT(CONSULTAS.DATACONSULTA, 'dd/MM/yyyy HH:mm') " +
                "as DataHorarioConsulta from CONSULTAS inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID inner join DOUTORES on " +
                "DOUTORES.ID = DOUTORID inner join CONVENIOS on CONVENIOS.ID = CONVENIOID WHERE DOUTORID = @IdDoutor and CONVERT(DATE, CONSULTAS.DATACONSULTA) = " +
                "Convert(date, getdate())", conexao.Conectar());

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdDoutor", p_IdDoutor);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable MostrarAgendarDoutor(int p_IdDoutor)
        {
            SqlCommand command = new SqlCommand("select PACIENTES.NOME as NomePaciente, FORMAT(CONSULTAS.DATACONSULTA , 'HH:mm') as DataConsulta FROM CONSULTAS " +
                "inner join PACIENTES on PACIENTEID = PACIENTES.ID WHERE DOUTORID = @IdDoutor and CONVERT(DATE, CONSULTAS.DATACONSULTA) = Convert(date, getdate()); ", conexao.Conectar());

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdDoutor", p_IdDoutor);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //Pegar Cpf do paciente pelo id
        public static string PegarCpfPaciente(int p_idPacientes)
        {
            string cpfPaciente = "";
            SqlCommand command = new SqlCommand("select CPF from PACIENTES where ID = @id", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", p_idPacientes);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                cpfPaciente = reader["CPF"].ToString();
            }
            conexao.Desconectar();
            return cpfPaciente;
        }

        //Pegar consulta pelo ID
        public static int PegarIdConsulta(int p_idConsulta)
        {
            int consultaId = 0;
            SqlCommand command = new SqlCommand("select PACIENTEID from CONSULTAS where ID = @id", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", p_idConsulta);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                consultaId = (int)reader["PACIENTEID"];
            }
            conexao.Desconectar();
            return consultaId;
        }


        // ID PACIENTE E ID DOUTOR PELO ID DA CONSULTA
        public static int PegarIdPaciente(int p_IdConsulta)
        {
            int IdPaciente = 0;
            SqlCommand command = new SqlCommand("select PACIENTEID from CONSULTAS where ID = @idConsulta", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@idConsulta", p_IdConsulta);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                IdPaciente = (int)reader["PACIENTEID"];
            }
            conexao.Desconectar();
            return IdPaciente;
        }

        public static int PegarIdDoutor(int p_IdConsulta)
        {
            int IdDoutor = 0;
            SqlCommand command = new SqlCommand("select DOUTORID from CONSULTAS where ID = @idConsulta", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@idConsulta", p_IdConsulta);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                IdDoutor = (int)reader["DOUTORID"];
            }
            conexao.Desconectar();
            return IdDoutor;
        }
    }
}
