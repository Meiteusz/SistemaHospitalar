using System;

namespace SistemaHospitalar.Entities
{
    public class Visita
    {
        public int VisitanteId { get; set; }
        public DateTime DataVisita { get; set; }
        public int InternacaoId { get; set; }

        public Visita(int p_VisitanteId, DateTime P_DataVisita, int p_InternacaoId)
        {
            VisitanteId = p_VisitanteId;
            DataVisita = P_DataVisita;
            InternacaoId = p_InternacaoId;
        }
    }
}
