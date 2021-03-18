using SistemaHospitalar.Entities;
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
            command.Parameters.AddWithValue("@horarioConsulta", consulta.HorarioConsulta);
            command.CommandText = "insert into CONSULTAS values(@estado, @paciente, @doutor, @dataConsulta, @preco, @horarioConsulta)";

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
    }
}
