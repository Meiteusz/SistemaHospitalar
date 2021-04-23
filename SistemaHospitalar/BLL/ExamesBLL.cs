using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using SistemaHospitalar.Utilities;
using System.Data;

namespace SistemaHospitalar.BLL
{
    class ExamesBLL : Validator
    {
        DalExames dalExames = new DalExames();
        DalConsultas dalConsultas = new DalConsultas();

        public bool isDataExameValido(Exame exame)
        {
            if (ValidarDataConsultaExame(exame.DataExame) && dalConsultas.isDataConsultaValido(exame.DataExame,
                FuncionarioLogado.ConsultaTemp.Paciente, FuncionarioLogado.ConsultaTemp.Doutor) && dalExames.isDataExameValido(exame.DataExame, 
                FuncionarioLogado.ConsultaTemp.Paciente, FuncionarioLogado.ConsultaTemp.Doutor) && exame.DataExame > FuncionarioLogado.ConsultaTemp.DataConsulta)
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
            return dalExames.InsertExame(exame);
        }

        public string CadastrarDiagnosticoExame(Diagnostico diagnostico)
        {
            return dalExames.InsertDiagnostico(diagnostico);
        }

        public string DeletarDiagnostico(int IdDiagnostico)
        {
            return dalExames.DeleteDiagnostico(IdDiagnostico);
        }

        public bool isDiagnosticoExistente(int IdExame)
        {
            return dalExames.isDiagnosticoExistente(IdExame);
        }

        public DataTable MostrarExamesDoutor(int IdDoutor)
        {
            return dalExames.TodosExamesDoDoutor(IdDoutor);
        }

        public DataTable MostrarExamesHojeDoutor(int IdDoutor)
        {
            return dalExames.TodosExamesDoDoutorHoje(IdDoutor);
        }

        public DataTable MostrarDiagnosticosExame(int IdExame)
        {
            return dalExames.DiagnosticosExame(IdExame);
        }
    }
}
