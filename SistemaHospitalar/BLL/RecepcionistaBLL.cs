using SistemaHospitalar.DAL;
using SistemaHospitalar.Models;
using System.Data;

namespace SistemaHospitalar.BLL
{
    class RecepcionistaBLL : Validator
    {
        DalRecepcionistas dalRecepionistas = new DalRecepcionistas();

        public string OutPut { get; private set; }
        public string LogarRecepcionista(Recepcionista recepcionista)
        {
            if (dalRecepionistas.isLoginValido(recepcionista))
            {
                OutPut = string.Empty;
            }
            else
            {
                OutPut = dalRecepionistas.OutPut;
            }
            return OutPut;
        }

        public string CadastrarRecepcionista(Recepcionista recepcionista, string confSenha)
        {
            MensagemErro = ValidarRecepcionista(recepcionista, confSenha);

            if (MensagemErro.Equals(string.Empty))
            {
                return dalRecepionistas.Insert(recepcionista, confSenha);
            }
            else
            {
                return MensagemErro;
            }
        }

        public string DeletarRecepcionista(int idRecepcionista)
        {
            return dalRecepionistas.Delete(idRecepcionista);
        }

        public string AtualizarRecepcionista(Recepcionista recepcionista, string confSenha)
        {
            MensagemErro = ValidarAlteracoesRecepcionista(recepcionista, confSenha);

            if (MensagemErro.Equals(string.Empty))
            {
                return dalRecepionistas.Update(recepcionista, confSenha);
            }
            else
            {
                return MensagemErro;
            }
        }

        public DataTable MostrarRecepcionistas()
        {
            return dalRecepionistas.TodasRecepcionistas();
        }

        public DataTable PesquisarRecepcionistas(string NomeRecepcionistas, Turno TurnoRecepnionistas)
        {
            return dalRecepionistas.PesquisaDeRecepcionistas(NomeRecepcionistas, TurnoRecepnionistas);
        }


        public string ValidarRecepcionista(Recepcionista recepcionista, string confSenha)
        {
            return ValidarNome(recepcionista.Nome) + ValidarEmail(recepcionista.Email) + ValidarSenha(recepcionista.Senha) + ConferirSenha(recepcionista.Senha, confSenha) +
                     ValidarCpf(recepcionista.Cpf) + ValidarTurno(recepcionista.Turno) + ValidarGenero(recepcionista.Genero) + ValidarCelular(recepcionista.Celular);
        }

        public string ValidarAlteracoesRecepcionista(Recepcionista recepcionista, string confSenha)
        {
            return ValidarNome(recepcionista.Nome) + ValidarEmail(recepcionista.Email) + ValidarSenha(recepcionista.Senha) + ConferirSenha(recepcionista.Senha, confSenha) +
                     ValidarTurno(recepcionista.Turno) + ValidarCelular(recepcionista.Celular);
        }
    }
}
