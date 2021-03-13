namespace SistemaHospitalar.Entities
{
    class Convenios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Desconto { get; set
            {
                value = value 
            } }

        public Convenios(string p_nome, float p_desconto)
        {
            Nome = p_nome;
            Desconto = p_desconto;
        }
    }
}
