using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using SistemaHospitalar.Utilities;
using System;
using System.Data;

namespace SistemaHospitalar.BLL
{
    class InternacaoBLL : Validator
    {
        public float ValorDiarioTotal { get; private set; }
        public float ValorDesconto { get; private set; }
        public float ValorFinalInternacao { get; private set; }
        public int DiasDeInternacao { get; private set; }
        DalInternacao dalInternacao = new DalInternacao();

        public string CadastrarInternacao(Internacao internacao)
        {
            MensagemErro = ValidarTipoInternacao(internacao.TipoInternacao) + ValidarDataEntradaInternacao(internacao.DataEntrada);

            if (MensagemErro.Equals(string.Empty))
            {
                return dalInternacao.Insert(internacao);
            }
            return MensagemErro;
        }

        public string AtualizarInternacao(Internacao internacao)
        {
            MensagemErro = ValidarTipoInternacao(internacao.TipoInternacao);

            if (MensagemErro.Equals(string.Empty))
            {
                return dalInternacao.Update(internacao);
            }
            return MensagemErro;
        }

        public void SetValoresInternacao(float p_valorDiarioTotal, float p_valorDesconto, int p_diasInternacao)
        {
            ValorDiarioTotal = p_valorDiarioTotal;
            ValorDesconto = p_valorDiarioTotal * p_valorDesconto;
            ValorFinalInternacao = p_valorDiarioTotal - ValorDesconto;
            DiasDeInternacao = p_diasInternacao;
        }
        
        public string DarAlta(Internacao internacao)
        {
            if (FuncionarioLogado.InternacaoTemp.DataEntrada < DateTime.Now)
            {
                return dalInternacao.UpdateAltaInternacao(internacao);
            }
            else
            {
                return "Data para Alta é inválida";
            }
        }

        public bool isDataSaidaNull(int IdInternacao)
        {
            return dalInternacao.isDataSaidaNull(IdInternacao);
        }

        public DataTable TodasInternacoes()
        {
            return dalInternacao.MostrarTodasInternacoes();
        }

        public DataTable TodasInternacoesDoutor(int IdDoutor)
        {
            return dalInternacao.MostrarInternacoesParaDoutor(IdDoutor);
        }
    }
}
