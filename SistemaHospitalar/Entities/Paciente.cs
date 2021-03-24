using SistemaHospitalar.Entities;
using System;

namespace SistemaHospitalar.Models
{
    public class Paciente : Usuarios
    {
        public Paciente(string p_nome, string p_cpf, string p_celular, Genero p_genero, int p_convenio)
        {
            Nome = p_nome;
            Cpf = p_cpf;
            Celular = p_celular;
            Genero = p_genero;
            Convenio = p_convenio;
        }

        public Paciente() { }


        public int Convenio { get; set; }
    }
}
