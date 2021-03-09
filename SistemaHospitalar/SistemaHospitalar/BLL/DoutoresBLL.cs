using SistemaHospitalar.Models;

namespace SistemaHospitalar.BLL
{
    class DoutoresBLL : Validator
    {
        public string Status { get; private set; } = "";

        public string ValidarDoutor(Doutores doutores, string confSenha)
        {
            Status = ValidarNome(doutores.Nome) + ValidarEmail(doutores.Email) + ValidarSenha(doutores.Senha) + ConferirSenha(doutores.Senha, confSenha) +
                     ValidarCpf(doutores.Cpf) + ValidarTurno(doutores.Turno) + ValidarGenero(doutores.Genero) + ValidarEspecialidade(doutores.Especialidade) + ValidarCelular(doutores.Celular);
            return Status;
        }

        public string ValidarAlteracoesDoutor(Doutores doutores, string confSenha)
        {
            Status = ValidarNome(doutores.Nome) + ValidarEmail(doutores.Email) + ValidarSenha(doutores.Senha) + ConferirSenha(doutores.Senha, confSenha) +
                     ValidarTurno(doutores.Turno) + ValidarCelular(doutores.Celular);
            return Status;
        }
    }
}
