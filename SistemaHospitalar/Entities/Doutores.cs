using SistemaHospitalar.Entities;

namespace SistemaHospitalar.Models
{
    public class Doutores : Usuarios
    {
        public Doutores(string p_nome, string p_email, string p_senha, string p_cpf, Turno p_turno, Genero p_genero, Especialidades p_especialidades, 
            string p_celular, float p_ValorConsulta, float p_ValorExame)
        {
            Nome = p_nome;
            Email = p_email;
            Senha = p_senha;
            Cpf = p_cpf;
            Turno = p_turno;
            Genero = p_genero;
            Especialidade = p_especialidades;
            Celular = p_celular;
            ValorConsulta = p_ValorConsulta;
            ValorExame = p_ValorExame;
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
        public float ValorConsulta { get; set; }
        public float ValorExame { get; set; }
    }
}
