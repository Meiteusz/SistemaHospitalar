using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using System.Collections;

namespace SistemaHospitalar.BLL
{
    class ConveniosBLL : Validator
    {
        DalConvenios dalConvenios = new DalConvenios();

        public string CadastrarConvenio(Convenios convenio)
        {
            MensagemErro = ValidarConvenio(convenio);

            if (MensagemErro.Equals(string.Empty))
            {
                return dalConvenios.Insert(convenio);
            }
            else
            {
                return MensagemErro;
            }
        }

        public void PegarDadosConvenio(int idConvenio)
        {
            dalConvenios.GetDadosConvenio(idConvenio);
        }

        public ArrayList ListarConvenios()
        {
            return dalConvenios.ListaConvenios();
        }

        public string ValidarConvenio(Convenios convenio)
        {
            return ValidarNomeConvenio(convenio.Nome) + ValidarDescontoConvenio(convenio.Desconto);
        }
    }
}
