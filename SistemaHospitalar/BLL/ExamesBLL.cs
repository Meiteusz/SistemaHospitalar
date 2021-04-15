using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;

namespace SistemaHospitalar.BLL
{
    class ExamesBLL
    {
        DalExames dalExames = new DalExames();

        public string AgendarExame(Exame exame)
        {
            return dalExames.Insert(exame);
        }
    }
}
