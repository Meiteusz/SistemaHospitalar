using SistemaHospitalar.Entities;
using System;
using System.Text.RegularExpressions;

namespace SistemaHospitalar.Models
{
    class Validator
    {
		static Regex regexEmail = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");
		static Match matchEmail;

        static Regex regexSenha = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{4,}$");
		static Match matchSenha;

        static Regex regexNome = new Regex(@"[A-Z][a-z].* [A-Z][a-z].*");
		static Match matchNome;

		static Regex regexCelular = new Regex(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");
		static Match matchCelular;

		public string MensagemErro { get; set; }
		public string MsgAtualizarInformacoes = "Deseja realmente atualizar as informações da sua conta?";

		//Valida o CPF
		#region ValidatorCPF
		public static bool IsCpf(string cpf)
		{
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;

			cpf = cpf.Trim();
			cpf = cpf.Replace(".", "").Replace("-", "");

			if (cpf.Length != 11)
				return false;

			tempCpf = cpf.Substring(0, 9);
			soma = 0;
			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;

			digito = resto.ToString();

			tempCpf = tempCpf + digito;

			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;

			digito = digito + resto.ToString();

			return cpf.EndsWith(digito);
		}
		#endregion

		public string ValidarNome(string nome)
        {
			if (!(matchNome = regexNome.Match(nome)).Success || string.IsNullOrWhiteSpace(nome))
			{
				return "Nome inválido\n";
			}
			return "";
		}

		public string ValidarCpf(string cpf)
        {
            if (!IsCpf(cpf))
            {
				return "Cpf inválido\n";
            }
			return "";
        }

		public string ValidarEmail(string email)
        {
			if (!(matchEmail = regexEmail.Match(email)).Success || string.IsNullOrWhiteSpace(email))
			{
				return "Email inválido\n";
			}
			return "";
		}

		public string ValidarSenha(string senha)
        {
			if (!(matchSenha = regexSenha.Match(senha)).Success || string.IsNullOrWhiteSpace(senha))
			{
				return "Senha inválida\n";
			}
			return "";
		}

		public string ConferirSenha(string senha, string confSenha)
        {
			if (ValidarSenha(senha).Equals(confSenha))
			{
				return "As senhas não correspodem\n";
			}
			return "";
		}

		public string ValidarTurno(Turno turno)
        {
			if (turno.Equals(Turno.Selecione))
			{
				return "Selecione um Turno\n";
			}
			return "";
		}

		public string ValidarGenero(Genero genero)
        {
			if (genero.Equals(Genero.Selecione))
			{
				return "Selecione um Genêro\n";
			}
			return "";
		}

		public string ValidarEspecialidade(Especialidades especialidades)
        {
			if (especialidades.Equals(Especialidades.Selecione))
			{
				return "Selecione uma Especialidade\n";
			}
			return "";
		}

		public string ValidarGravidade(Gravidade gravidade)
        {
			if (gravidade.Equals(Gravidade.Selecione))
			{
				return "Selecione uma Gravidade\n";
			}
			return "";
		}
		
		public string ValidarCelular(string celular)
        {
			if (!(matchCelular = regexCelular.Match(celular)).Success || string.IsNullOrWhiteSpace(celular))
			{
				return "Celular inválido\n";
			}
			return "";
		}

		public string ValidarCelular2(string celular2)
        {
			if (!(matchCelular = regexCelular.Match(celular2)).Success || string.IsNullOrWhiteSpace(celular2))
			{
				return "Celular 2 inválido\n";
			}
			return "";
		}

		public string ValidarNomeConvenio(string nomeConvenio)
        {
            if (nomeConvenio.Length < 3 || nomeConvenio.Length > 25)
            {
				return "Nome do convênio é inválido!\n";
            }
			return "";
        }

		public string ValidarDescontoConvenio(float descontoConvenio)
        {
            if (descontoConvenio < 0 || descontoConvenio > 100)
            {
				return "Desconto está inválido!\n";
            }
			return "";
        }

		public bool ValidarDataConsulta(DateTime dateTime)
        {
            if (dateTime <= DateTime.Now || dateTime.DayOfWeek.Equals(DayOfWeek.Saturday) ||dateTime.DayOfWeek.Equals(DayOfWeek.Sunday) || dateTime.Hour > 23 || 
				dateTime.Hour < 7 || dateTime.Minute != 0 && dateTime.Minute != 30)
            {
				return false;
			}
			return true;
        }
	}
}
