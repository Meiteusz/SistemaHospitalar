using SistemaHospitalar.Models;
using System.Collections;
using System.Data;
using System.Windows.Forms;

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

        public void PegarDadosPaciente(int p_IdPaciente, string p_CpfPaciente)
        {
            dalPacientes.GetDadosPaciente(p_IdPaciente, p_CpfPaciente);
        }

        public Paciente GetPacienteByCpf(string cpf)
        {
            return dalPacientes.GetPacienteByCpf(cpf);
        }

        public int PegarConvenioPeloNome(string NomeConvenio)
        {
            return dalPacientes.GetIdConvenioPeloNome(NomeConvenio);
        }

        public ArrayList MostrarCpfPacientes()
        {
            return dalPacientes.GetCpfPacientes();
        }

        public AutoCompleteStringCollection MostrarNomesPacientes()
        {
            return dalPacientes.GetNomesPacientes();
        }

        public DataTable MostrarPacientes()
        {
            return dalPacientes.TodosPacientes();
        }

        public DataTable PesquisarPacientes(string NomePaciente, string CpfPaciente)
        {
            return dalPacientes.PesquisaDePacientes(NomePaciente, CpfPaciente);
        }

        public ArrayList MostrarCpfPacientesInternados()
        {
            return dalPacientes.MostrarCpfPacientesInternados();
        }

        public ArrayList MostrarCpfPacientesNaoInternados()
        {
            return dalPacientes.MostrarCpfPacientesNaoInternados();
        }

        private string ValidarPaciente(Paciente paciente)
        {
            return ValidarNome(paciente.Nome) + ValidarCpf(paciente.Cpf) + ValidarCelular(paciente.Celular) + ValidarGenero(paciente.Genero);
        }
    }
}
