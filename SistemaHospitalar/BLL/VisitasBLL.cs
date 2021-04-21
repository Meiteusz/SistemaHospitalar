using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using System;
using System.Collections;
using System.Data;

namespace SistemaHospitalar.BLL
{
    class VisitasBLL : Validator
    {
        DalVisitas dalVisitas = new DalVisitas();

        public string CadastrarVisitante(Visitante visitante)
        {
            MensagemErro = ValidarVisitante(visitante);

            if (MensagemErro.Equals(string.Empty))
            {
                return dalVisitas.InsertVisitante(visitante);
            }
            else
            {
                return MensagemErro;
            }
        }

        public string AgendarVisita(Visita visita)
        {
            if (visita.DataVisita.Hour > 23 || visita.DataVisita.Hour < 7 || visita.DataVisita <= DateTime.Today || visita.DataVisita < DateTime.Now.AddHours(12))
            {
                return "Data inválida";
            }
            else
            {
                return dalVisitas.InsertVisita(visita);
            }
        }

        public ArrayList MostrarCpfVisitantes()
        {
            return dalVisitas.GetCpfVisitantes();
        }

        public DataTable MostrarVisitantes()
        {
            return dalVisitas.TodosVisitantes();
        }

        public DataTable MostrarVisitas()
        {
            return dalVisitas.TodasVisitas();
        }

        public void PegarDadosVisitante(int IdVisitante, string CpfVisitante)
        {
            dalVisitas.GetDadosVisitante(IdVisitante, CpfVisitante);
        }

        private string ValidarVisitante(Visitante visitante)
        {
            return ValidarNome(visitante.Nome) + ValidarCpf(visitante.Cpf);
        }
    }
}
