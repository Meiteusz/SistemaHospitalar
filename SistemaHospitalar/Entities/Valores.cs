namespace SistemaHospitalar.Entities
{
    class Valores
    {
        public int Id { get; set; }
        public float ValorConsulta { get; set; }
        public float ValorExame { get; set; }
        public int Doutor { get; set; }

        public Valores(float p_valorConsulta, float p_valorExame, int p_doutor)
        {
            ValorConsulta = p_valorConsulta;
            ValorExame = p_valorExame;
            Doutor = p_doutor;
        }
    }
}
