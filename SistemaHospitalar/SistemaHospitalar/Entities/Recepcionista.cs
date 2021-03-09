namespace SistemaHospitalar.Models
{
    class Recepcionista : Usuarios
    {
        public Recepcionista(string p_nome, string p_cpf, string p_celular, Turno p_turno, Genero p_genero, string p_email, string p_senha)
        {
            Nome = p_nome;
            Cpf = p_cpf;
            Celular = p_celular;
            Turno = p_turno;
            Genero = p_genero;
            Email = p_email;
            Senha = p_senha;
        }

        public Recepcionista(string p_email, string p_senha)
        {
            Email = p_email;
            Senha = p_senha;
        }

        public Recepcionista(string p_nome, string p_email, string p_celular, Turno p_turno, string p_senha)
        {
            Nome = p_nome;
            Email = p_email;
            Celular = p_celular;
            Turno = p_turno;
            Senha = p_senha;
        }
    }
}
