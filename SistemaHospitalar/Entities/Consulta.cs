using System;

namespace SistemaHospitalar.Entities
{
    class Consulta
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public int Paciente { get; set; }
        public int Doutor { get; set; }
        public DateTime DataConsulta { get; set; }
        public float Preco { get; set; }
        public DateTime HorarioConsulta { get; set; }

        public Consulta(string p_estado, int p_paciente, int p_doutor, DateTime p_dataConsulta, float p_preco, DateTime p_horarioConsulta)
        {
            Estado = p_estado;
            Paciente = p_paciente;
            Doutor = p_doutor;
            DataConsulta = p_dataConsulta;
            Preco = p_preco;
            HorarioConsulta = p_horarioConsulta;
        }
    }
}
