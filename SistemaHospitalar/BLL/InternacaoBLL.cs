using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;

namespace SistemaHospitalar.BLL
{
    public class InternacaoBLL
    {
        DalInternacao dalInternacao = new DalInternacao();

        public string CadastrarInternacao(Internacao internacao)
        {
            return dalInternacao.Insert(internacao);
        }
    }
}
