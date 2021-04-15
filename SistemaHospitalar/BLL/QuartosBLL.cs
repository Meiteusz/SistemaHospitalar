using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using System.Collections;
using System.Data;

namespace SistemaHospitalar.BLL
{
    class QuartosBLL : Validator
    {
        DalQuartos dalQuartos = new DalQuartos();

        public string CadastrarQuarto(Quartos quarto)
        {
            MensagemErro = ValidarNumeroQuarto(quarto.NumeroQuarto);

            if (MensagemErro.Equals(string.Empty))
            {
                return dalQuartos.Insert(quarto);
            }
            else
            {
                return MensagemErro;
            }
        }

        public DataTable MostrarQuartos()
        {
            return dalQuartos.TodosQuartos();
        }

        public DataTable MostrarQuartosDisponiveis()
        {
            return dalQuartos.QuartosDisponiveis();
        }    

        public ArrayList ListarQuartosDisponiveis()
        {
            return dalQuartos.ListarQuartosDisponiveis();
        }
    }
}
