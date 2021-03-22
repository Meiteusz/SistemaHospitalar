using System;

namespace SistemaHospitalar.Entities
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public int Paciente { get; set; }
        public int Doutor { get; set; }
        public DateTime DataConsulta { get; set; }
        public float Preco { get; set; }

        public Consulta(string p_estado, int p_paciente, int p_doutor, DateTime p_dataConsulta, float p_preco)
        {
            Estado = p_estado;
            Paciente = p_paciente;
            Doutor = p_doutor;
            DataConsulta = p_dataConsulta;
            Preco = p_preco;
        }
    }
}
