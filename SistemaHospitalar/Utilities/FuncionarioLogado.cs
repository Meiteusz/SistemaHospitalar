using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;

namespace SistemaHospitalar.Utilities
{
    public static class FuncionarioLogado
    {
        public static Recepcionista RecepcionistaLogada { get; private set; }
        public static Doutores DoutorLogado { get; private set; }
        public static Convenios ConvenioSelecionado { get; private set; }
        public static Paciente PacienteSelecionado { get; private set; }
        public static Visitante VisitanteSelecionado { get; private set; }
        public static Consulta ConsultaTemp { get; private set; }
        public static Internacao InternacaoTemp { get; private set; }
        public static Doutores DoutorTemp { get; private set; }
        public static ADM ADMatual { get; private set; }
        public static float ValorDiarioInternacaoADM { get; private set; }

        public static void SetFuncionarioLogado(object funcionario)
        {
            if (funcionario is Recepcionista)
                RecepcionistaLogada = funcionario as Recepcionista;
            else
                DoutorLogado = funcionario as Doutores;
        }

        public static void SetConvenioSelecionado(Convenios convenio)
        {
            ConvenioSelecionado = convenio;
        }

        public static void SetPacienteSelecionado(Paciente paciente)
        {
            PacienteSelecionado = paciente;
        }

        public static void SetVisitanteSelecionado(Visitante visitante)
        {
            VisitanteSelecionado = visitante;
        }

        public static void SetConsultaTemp(int ConsultaID)
        {
            DalConsultas dalConsultas = new DalConsultas();

            ConsultaTemp = dalConsultas.GetDadosConsultaPeloId(ConsultaID);
        }

        public static void SetInternacaoTemp(int InternacaoID)
        {
            DalInternacao dalInternacao = new DalInternacao();

            InternacaoTemp = dalInternacao.GetDadosInternacaoById(InternacaoID);
        }

        public static void SetDoutorTemp(int DoutorID)
        {
            DalDoutores dalDoutores = new DalDoutores();

            DoutorTemp = dalDoutores.GetDadosDoutorPeloID(DoutorID);
        }

        public static void SetADM(ADM adm)
        {
            ADMatual = adm;
        }

        public static void SetValorDiarioInternacaoADM(float valorInternacao)
        {
            ValorDiarioInternacaoADM = valorInternacao;
        }
    }
}
