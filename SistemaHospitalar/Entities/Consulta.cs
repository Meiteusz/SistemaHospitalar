using System;

namespace SistemaHospitalar.Entities
{
    public class Consulta
    {
        public int Id { get; set; }
        public int Paciente { get; set; }
        public int Doutor { get; set; }
        public DateTime DataConsulta { get; set; }
        public float Preco { get; set; }

        public Consulta(int p_paciente, int p_doutor, DateTime p_dataConsulta, float p_preco)
        {
            Paciente = p_paciente;
            Doutor = p_doutor;
            DataConsulta = p_dataConsulta;
            Preco = p_preco;
        }

        public string NomePaciente { get; set; } 

        public Consulta(int p_Id, string p_NomePaciente, DateTime p_DataConsulta)
        {
            Id = p_Id;
            NomePaciente = p_NomePaciente;
            DataConsulta = p_DataConsulta;
        }

        public Consulta() { }
    }
}
