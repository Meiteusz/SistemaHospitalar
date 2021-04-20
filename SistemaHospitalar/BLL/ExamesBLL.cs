using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using SistemaHospitalar.Utilities;

namespace SistemaHospitalar.BLL
{
    class ExamesBLL : Validator
    {
        DalExames dalExames = new DalExames();
        DalConsultas dalConsultas = new DalConsultas();

        public bool isDataExameValido(Exame exame)
        {
            if (ValidarDataConsultaExame(exame.DataExame) && dalConsultas.isDataConsultaValido(FuncionarioLogado.ConsultaTemp.DataConsulta, FuncionarioLogado.ConsultaTemp.Paciente, FuncionarioLogado.ConsultaTemp.Doutor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string AgendarExame(Exame exame)
        {
            return dalExames.Insert(exame);
        }
    }
}
