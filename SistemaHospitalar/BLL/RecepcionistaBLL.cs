using SistemaHospitalar.DAL;
using SistemaHospitalar.Models;

namespace SistemaHospitalar.BLL
{
    class RecepcionistaBLL : Validator
    {
        public string Status { get; private set; } = "";

        public void LogarRecepcionista(string p_email, string p_senha)
        {
            DalRecepionistas dalRecepionistas = new DalRecepionistas();
            Recepcionista recepionista = new Recepcionista(p_email, p_senha);
        }

        public string ValidarRecepcionista(Recepcionista recepcionista, string confSenha)
        {
            Status = ValidarNome(recepcionista.Nome) + ValidarEmail(recepcionista.Email) + ValidarSenha(recepcionista.Senha) + ConferirSenha(recepcionista.Senha, confSenha) +
                     ValidarCpf(recepcionista.Cpf) + ValidarTurno(recepcionista.Turno) + ValidarGenero(recepcionista.Genero) + ValidarCelular(recepcionista.Celular);
            return Status;
        }
        public string ValidarAlteracoesRecepcionista(Recepcionista recepcionista, string confSenha)
        {
            Status = ValidarNome(recepcionista.Nome) + ValidarEmail(recepcionista.Email) + ValidarSenha(recepcionista.Senha) + ConferirSenha(recepcionista.Senha, confSenha) + 
                     ValidarTurno(recepcionista.Turno) + ValidarCelular(recepcionista.Celular);
            return Status;
        }
    }
}
