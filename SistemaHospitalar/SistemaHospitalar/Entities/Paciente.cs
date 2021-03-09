using SistemaHospitalar.Entities;
using System;

namespace SistemaHospitalar.Models
{
    public class Paciente : Usuarios
    {
        public Paciente(string p_nome, string p_cpf, string p_celular, string p_celular2, Genero p_genero, Gravidade p_gravidade,
            DateTime p_dataEntrada, DateTime p_dataSaida)
        {
            Nome = p_nome;
            Cpf = p_cpf;
            Celular = p_celular;
            Celular2 = p_celular2;
            Genero = p_genero;
            Gravidade = p_gravidade;
            DataEntrada = p_dataEntrada;
            DataSaida = p_dataSaida;
        }

        public Paciente() { }

        public string Celular2 { get; set; }
        public Gravidade Gravidade { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public bool isPlano { get; set; }
    }
}
