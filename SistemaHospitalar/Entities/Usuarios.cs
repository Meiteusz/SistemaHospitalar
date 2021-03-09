namespace SistemaHospitalar.Models
{
    public abstract class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Celular { get; set; }
        public Turno Turno { get; set; }
        public Genero Genero { get; set; }
    }
}
