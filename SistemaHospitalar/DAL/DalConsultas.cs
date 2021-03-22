using SistemaHospitalar.Entities;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    class DalConsultas : DalComandos
    {
        public string CadastrarConsulta(Consulta consulta)
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
                return MostrarErro(ex);
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
                return MostrarErro(ex);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public static DataTable MostrarConsultasDGV()
        {
            command.CommandText = "select CONSULTAS.ID, CONSULTAS.ESTADO as Estado_Consulta, PACIENTES.NOME as Paciente_Nome, DOUTORES.NOME as Doutor_Nome, " +
                "FORMAT(CONSULTAS.DATACONSULTA, 'dd/MM/yyyy HH:mm') as DataHorarioConsulta, FORMAT(CONSULTAS.PRECO, 'c', 'pt-br') as ValorConsulta " +
                "from CONSULTAS inner join PACIENTES on PACIENTES.ID = CONSULTAS.PACIENTEID inner join DOUTORES on DOUTORES.ID = DOUTORID";
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
