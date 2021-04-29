using SistemaHospitalar.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalConsultas : DalComandos
    {
        public bool isDataConsultaValido(DateTime p_dataConsulta, int p_idPaciente, int p_idDoutor)
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

        public string Insert(Consulta p_consulta)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@paciente", p_consulta.Paciente);
            command.Parameters.AddWithValue("@doutor", p_consulta.Doutor);
            command.Parameters.AddWithValue("@dataConsulta", p_consulta.DataConsulta);
            command.Parameters.AddWithValue("@preco", p_consulta.Preco);
            command.CommandText = "insert into CONSULTAS values(@paciente, @doutor, @dataConsulta, @preco)";

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

        public string UpdateDataConsulta(DateTime p_dataConsulta, int p_idConsulta)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@dataConsulta", p_dataConsulta);
            command.Parameters.AddWithValue("@id", p_idConsulta);
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

        public Consulta GetDadosConsultaById(int p_IdConsulta)
        {
            Consulta consulta = new Consulta();
            SqlCommand command = new SqlCommand("select * from CONSULTAS where ID = @IdConsulta", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdConsulta", p_IdConsulta);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                consulta.Id = (int)reader["ID"];
                consulta.Paciente = (int)reader["PACIENTEID"];
                consulta.Doutor = (int)reader["DOUTORID"];
                consulta.DataConsulta = Convert.ToDateTime(reader["DATACONSULTA"]);
                consulta.Preco = Convert.ToSingle(reader["PRECO"]);
            }
            conexao.Desconectar();
            return consulta;
        }

        public int GetConvenioDoPaciente(int p_pacienteId)
        {
            int IdConvenio = 0;
            SqlCommand command = new SqlCommand("select CONVENIOID from PACIENTES where ID = @id", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", p_pacienteId);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                IdConvenio = (int)reader["CONVENIOID"];
            }
            conexao.Desconectar();
            return IdConvenio;
        }

        public DataTable MostrarConsultas()
        {
            command.CommandText = "select CONSULTAS.ID, PACIENTES.NOME as Paciente_Nome, DOUTORES.NOME as Doutor_Nome, " +
                "FORMAT(CONSULTAS.DATACONSULTA, 'dd/MM/yyyy HH:mm') as Data_Horario, FORMAT(CONSULTAS.PRECO, 'c', 'pt-br') as Valor, CONVENIOS.NOME as Convênio_Nome " +
                "from CONSULTAS inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID inner join DOUTORES on DOUTORES.ID = DOUTORID inner join CONVENIOS on CONVENIOS.ID = CONVENIOID";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable MostrarConsultasHoje()
        {
            command.CommandText = "select CONSULTAS.ID, PACIENTES.NOME as Paciente_Nome, DOUTORES.NOME as Doutor_Nome, " +
                "FORMAT(CONSULTAS.DATACONSULTA, 'dd/MM/yyyy HH:mm') as Data_Horario, FORMAT(CONSULTAS.PRECO, 'c', 'pt-br') as Valor, CONVENIOS.NOME as " +
                "Convênio_Nome from CONSULTAS inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID inner join DOUTORES on DOUTORES.ID = DOUTORID inner join " +
                "CONVENIOS on CONVENIOS.ID = CONVENIOID where CONVERT(DATE, CONSULTAS.DATACONSULTA) = Convert(date, getdate())";

            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable MostrarConsultasParaDoutor(int p_IdDoutor)
        {
            SqlCommand command = new SqlCommand("select CONSULTAS.ID, PACIENTES.NOME as Paciente_Nome, FORMAT(CONSULTAS.DATACONSULTA, 'dd/MM/yyyy HH:mm') " +
                "as Data_Horario from CONSULTAS inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID inner join DOUTORES on " +
                "DOUTORES.ID = DOUTORID inner join CONVENIOS on CONVENIOS.ID = CONVENIOID WHERE DOUTORID = @IdDoutor and CONVERT(DATE, CONSULTAS.DATACONSULTA) = " +
                "Convert(date, getdate())", conexao.Conectar());

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdDoutor", p_IdDoutor);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        public DataTable PesquisarConsultasByData(string p_dataConsulta)
        {
            SqlCommand command = new SqlCommand("select DOUTORES.NOME as Doutor_Nome, FORMAT(CONSULTAS.DATACONSULTA , 'dd/MM/yyyy HH:mm') as Consulta_Data from " +
                "CONSULTAS inner join DOUTORES on DOUTORES.ID = CONSULTAS.DOUTORID where FORMAT(CONVERT(DATE, CONSULTAS.DATACONSULTA), 'dd/MM/yyyy') = @DataConsulta", conexao.Conectar());

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@DataConsulta", p_dataConsulta);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }

        public DataTable PesquisarConsultaByNomePaciente(string p_NomePaciente)
        {
            SqlCommand command = new SqlCommand("select CONSULTAS.ID, PACIENTES.NOME as Paciente_Nome, DOUTORES.NOME as Doutor_Nome, " +
                "FORMAT(CONSULTAS.DATACONSULTA, 'dd/MM/yyyy HH:mm') as Data_Horario, FORMAT(CONSULTAS.PRECO, 'c', 'pt-br') as Valor, CONVENIOS.NOME as Convênio_Nome " +
                "from CONSULTAS inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID inner join DOUTORES on DOUTORES.ID = DOUTORID inner join CONVENIOS on " +
                "CONVENIOS.ID = CONVENIOID where PACIENTES.NOME = @NomePaciente", conexao.Conectar());

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@NomePaciente", p_NomePaciente);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }   

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
