using System;

namespace SistemaHospitalar.Entities
{
    public class Diagnostico
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int ExameId { get; set; }
        public DateTime DataDiagnostico { get; set; }

        public Diagnostico() { }

        public Diagnostico(string p_descricao, int p_exameId, DateTime p_dataDiagnostico)
        {
            Descricao = p_descricao;
            ExameId = p_exameId;
            DataDiagnostico = p_dataDiagnostico;
        }
    }
}