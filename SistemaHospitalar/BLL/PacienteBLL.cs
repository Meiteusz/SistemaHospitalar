using SistemaHospitalar.Models;
using System.Collections;

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

        public int IndentificarConvenio(int idPaciente)
        {
            return dalPacientes.GetConvenioDoPaciente(idPaciente);
        }

        public int PegarConvenioPeloNome(string NomeConvenio)
        {
            return dalPacientes.GetIdConvenioPeloNome(NomeConvenio);
        }

        public string PegarPacientePeloCpf(string CpfPaciente)
        {
            return dalPacientes.GetPacientePeloCpf(CpfPaciente);
        }

        public ArrayList MostrarCpfPacientes()
        {
            return dalPacientes.GetCpfPacientes();
        }



        public string ValidarPaciente(Paciente paciente)
        {
            return ValidarNome(paciente.Nome) + ValidarCpf(paciente.Cpf) + ValidarCelular(paciente.Celular) + ValidarGenero(paciente.Genero);
        }
    }
}
