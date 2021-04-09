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

        //public static Usuarios GetFuncionarioLogado()
        //{
        //    if (RecepcionistaLogada != null)
        //        return RecepcionistaLogada;
        //    return DoutorLogado;
        //}
    }
}
