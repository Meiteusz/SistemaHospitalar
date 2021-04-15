namespace SistemaHospitalar.Entities
{
    class Quartos
    {
        public int NumeroQuarto { get; set; }
        public bool isDisponivel { get; set; }

        public Quartos(int p_numeroQuarto, bool p_isDisponivel)
        {
            NumeroQuarto = p_numeroQuarto;
            isDisponivel = p_isDisponivel;
        }
    }
}
