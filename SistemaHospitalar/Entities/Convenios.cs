namespace SistemaHospitalar.Entities
{
    public class Convenios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Desconto { get; set; }

        public Convenios() { }

        public Convenios(string p_nome, float p_desconto)
        {
            Nome = p_nome;
            Desconto = p_desconto;
        }
    }
}
