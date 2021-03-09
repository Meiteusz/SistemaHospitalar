using SistemaHospitalar.Models;

namespace SistemaHospitalar.BLL
{
    class RecepcionistaBLL : Validator
    {
        public string Status { get; private set; } = "";

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
