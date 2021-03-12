using SistemaHospitalar.Entities;
using System;

namespace SistemaHospitalar.Models
{
    public class Paciente : Usuarios
    {
        public Paciente(string p_nome, string p_cpf, string p_celular, Genero p_genero)
        {
            Nome = p_nome;
            Cpf = p_cpf;
            Celular = p_celular;
            Genero = p_genero;
        }

        public Paciente() { }

        //public Gravidade Gravidade { get; set; }
        //public DateTime DataEntrada { get; set; }
        //public DateTime DataSaida { get; set; }
        //public bool isPlano { get; set; }
    }
}
