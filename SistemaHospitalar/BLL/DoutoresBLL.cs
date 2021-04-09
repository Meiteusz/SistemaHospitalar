using SistemaHospitalar.DAL;
using SistemaHospitalar.Models;

namespace SistemaHospitalar.BLL
{
    class DoutoresBLL : Validator
    {
        DalDoutores dalDoutores = new DalDoutores();

        public string OutPut { get; private set; }
        public string LogarDoutor(Doutores doutor)
        {
            if (dalDoutores.isLoginValido(doutor))
            {
                OutPut = string.Empty;
            }
            else
            {
                OutPut = dalDoutores.OutPut;
            }
            return OutPut;
        }

        public string CadastrarDoutor(Doutores doutor, string confSenha)
        {
            MensagemErro = ValidarDoutor(doutor, confSenha);

            if (MensagemErro.Equals(string.Empty))
            {
                return dalDoutores.Insert(doutor, confSenha);
            }
            else
            {
                return MensagemErro;
            }
        }

        public string DeletarDoutor(int idDoutor)
        {
            return dalDoutores.Delete(idDoutor);
        }

        public string AtualizarDoutor(Doutores doutor, string confSenha)
        {
            MensagemErro = ValidarAlteracoesDoutor(doutor, confSenha);
            
            if (MensagemErro.Equals(string.Empty))
            {
                return dalDoutores.Update(doutor, confSenha);
            }
            else
            {
                return MensagemErro;
            }
        }

        public string AtualizarValores(float valorConsulta, float valorExame)
        {
            return dalDoutores.UpdateValores(valorConsulta, valorExame);
        }








        public string ValidarDoutor(Doutores doutores, string confSenha)
        {
            return ValidarNome(doutores.Nome) + ValidarEmail(doutores.Email) + ValidarSenha(doutores.Senha) + ConferirSenha(doutores.Senha, confSenha) +
                     ValidarCpf(doutores.Cpf) + ValidarTurno(doutores.Turno) + ValidarGenero(doutores.Genero) + ValidarEspecialidade(doutores.Especialidade) + ValidarCelular(doutores.Celular);
        }

        public string ValidarAlteracoesDoutor(Doutores doutores, string confSenha)
        {
            return ValidarNome(doutores.Nome) + ValidarEmail(doutores.Email) + ValidarSenha(doutores.Senha) + ConferirSenha(doutores.Senha, confSenha) +
                     ValidarTurno(doutores.Turno) + ValidarCelular(doutores.Celular);
        }
    }
}
