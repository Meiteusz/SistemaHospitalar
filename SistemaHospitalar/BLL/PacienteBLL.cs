using SistemaHospitalar.Models;

namespace SistemaHospitalar.BLL
{
    class PacienteBLL : Validator
    {
        DalPacientes dalPacientes = new DalPacientes();

        public string CadastrarPaciente(Paciente paciente)
        {
            MensagemErro = ValidarPaciente(paciente);

            if (MensagemErro.Equals(string.Empty))
            {
                return dalPacientes.Insert(paciente);
            }
            else
            {
                return MensagemErro;
            }
        }

        public string DeletarPaciente(int idPaciente)
        {
            return dalPacientes.Delete(idPaciente);
        }



        public string ValidarPaciente(Paciente paciente)
        {
            return ValidarNome(paciente.Nome) + ValidarCpf(paciente.Cpf) + ValidarCelular(paciente.Celular) + ValidarGenero(paciente.Genero);
        }
    }
}
