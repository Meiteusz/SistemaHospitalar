using System;

namespace SistemaHospitalar.Entities
{
    public class Exame
    {
        public int Id { get; set; }
        public int ConsultaId { get; set; }
        public DateTime DataExame { get; set; }
        public float Preco { get; set; }
        public string TipoExame { get; set; }

        public Exame(int p_consultaId, DateTime p_dataExame, float p_preco, string p_tipoExame)
        {
            ConsultaId = p_consultaId;
            DataExame = p_dataExame;
            Preco = p_preco;
            TipoExame = p_tipoExame;
        }
    }
}
