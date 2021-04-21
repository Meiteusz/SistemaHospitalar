namespace SistemaHospitalar.Models
{
    public class Visitante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Visitante() { }

        public Visitante(string p_NomeVisitante, string p_CpfVisitante)
        {
            Nome = p_NomeVisitante;
            Cpf = p_CpfVisitante;
        }
    }
}
