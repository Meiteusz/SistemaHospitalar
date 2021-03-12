using SistemaHospitalar.Models;

namespace SistemaHospitalar.BLL
{
    class PacienteBLL : Validator
    {
        public string Status { get; private set; } = "";

        public string ValidarPaciente(Paciente paciente)
        {
            Status = ValidarNome(paciente.Nome) + ValidarCpf(paciente.Cpf) + ValidarCelular(paciente.Celular) + ValidarGenero(paciente.Genero);
            return Status;
        }
    }
}
