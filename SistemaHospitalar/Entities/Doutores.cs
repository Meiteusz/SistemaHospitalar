using SistemaHospitalar.Entities;

namespace SistemaHospitalar.Models
{
    class Doutores : Usuarios
    {
        public Doutores(string p_nome, string p_email, string p_senha, string p_cpf, Turno p_turno, Genero p_genero, Especialidades p_especialidades, string p_celular)
        {
            Nome = p_nome;
            Email = p_email;
            Senha = p_senha;
            Cpf = p_cpf;
            Turno = p_turno;
            Genero = p_genero;
            Especialidade = p_especialidades;
            Celular = p_celular;
        }

        public Doutores(string p_nome, string p_email, string p_celular, Turno p_turno, string p_senha)
        {
            Nome = p_nome;
            Email = p_email;
            Celular = p_celular;
            Turno = p_turno;
            Senha = p_senha;
        }

        public Doutores(string p_email, string p_senha) 
        {
            Email = p_email;
            Senha = p_senha;
        }

        public Doutores() { }

        public Especialidades Especialidade { get; set; }
    }
}
