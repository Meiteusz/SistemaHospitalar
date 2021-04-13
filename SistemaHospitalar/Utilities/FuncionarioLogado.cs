using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;

namespace SistemaHospitalar.Utilities
{
    public static class FuncionarioLogado
    {
        public static Recepcionista RecepcionistaLogada { get; private set; }
        public static Doutores DoutorLogado { get; private set; }

        public static void SetFuncionarioLogado(object funcionario)
        {
            if (funcionario is Recepcionista)
                RecepcionistaLogada = funcionario as Recepcionista;
            else
                DoutorLogado = funcionario as Doutores;
        }

        public static Consulta ConsultaSelecionada { get; private set; }
        public static void SetConsultaSelecionada(Consulta consulta)
        {
            ConsultaSelecionada = consulta;
        }

        public static Convenios ConvenioSelecionado { get; private set; }
        public static void SetConvenioSelecionado(Convenios convenio)
        {
            ConvenioSelecionado = convenio;
        }

        public static Paciente PacienteSelecionado { get; private set; }
        public static void SetPacienteSelecionado(Paciente paciente)
        {
            PacienteSelecionado = paciente;
        }

        public static Doutores DoutorTemp { get; private set; }
        public static void SetDoutorTemp(int DoutorID)
        {
            DalDoutores dalDoutores = new DalDoutores();

            DoutorTemp = dalDoutores.GetDadosDoutorPeloID(DoutorID);
        }
    }
}
