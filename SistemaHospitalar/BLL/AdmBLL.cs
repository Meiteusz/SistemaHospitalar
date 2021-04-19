using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;

namespace SistemaHospitalar.BLL
{
    class AdmBLL
    {
        DalADM dalAdm = new DalADM();
        public string OutPut { get; private set; }

        public string LogarADM(ADM adm)
        {
            if (dalAdm.isAcessoValido(adm))
            {
                OutPut = string.Empty;
            }
            else
            {
                OutPut = dalAdm.OutPut;
            }
            return OutPut;
        }

        public string AtualizarValorDiarioInternacao(ADM adm)
        {
            return dalAdm.AtualizarValorInternacao(adm);
        }

        public void PegarValorDiarioInternacao()
        {
            dalAdm.GetValorDiarioAdmAtivo();
        }
    }
}