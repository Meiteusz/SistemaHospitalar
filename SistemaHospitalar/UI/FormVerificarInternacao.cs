using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormVerificarInternacao : Form
    {
        public FormVerificarInternacao()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbEstadoInternacao.DataSource = Enum.GetValues(typeof(TipoInternacao));
            cmbQuarto.DataSource = quartosBLL.ListarQuartosDisponiveis();
            lblPrecoDiarioInternacao.Text = FuncionarioLogado.ValorDiarioInternacaoADM.ToString();
            BloquearPacientesComAlta();
        }

        QuartosBLL quartosBLL = new QuartosBLL();
        InternacaoBLL internacaoBLL = new InternacaoBLL();

        private void btnAtualizarInternacao_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbQuarto.Text))
            {
                MessageBox.Show("Há valores inválidos");
            }
            else
            {
                Internacao internacao = new Internacao(FuncionarioLogado.InternacaoTemp.Id, rtbDescricao.Text, (TipoInternacao)cmbEstadoInternacao.SelectedIndex, Convert.ToInt32(cmbQuarto.Text), DateTime.Now);

                if (MessageBox.Show("Deseja atualizar os dados da internação?", "Data de alteração: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    MessageBox.Show(internacaoBLL.AtualizarInternacao(internacao));
                }
            }
        }

        private void btnDarAltar_Click(object sender, System.EventArgs e)
        {
            int DiasDeInternacao = Convert.ToInt32(DateTime.Now.Subtract(FuncionarioLogado.InternacaoTemp.DataEntrada).Days);
            float ValorTotalInternacao = FuncionarioLogado.ValorDiarioInternacaoADM * DiasDeInternacao;
            internacaoBLL.SetValoresInternacao(ValorTotalInternacao, FuncionarioLogado.ConvenioSelecionado.Desconto, DiasDeInternacao);

            Internacao internacao = new Internacao(FuncionarioLogado.InternacaoTemp.Id, DateTime.Now, internacaoBLL.ValorFinalInternacao);
            if (MessageBox.Show("Deseja dar alta para o paciente: " + FuncionarioLogado.PacienteSelecionado.Nome + "?", "Registrar Alta", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show(internacaoBLL.DarAlta(internacao));
                AbrirExtratoInternacao();
            }
        }

        private void FormVerificarInternacao_Load(object sender, System.EventArgs e)
        {
            lblNomePaciente.Text = FuncionarioLogado.PacienteSelecionado.Nome;
            lblCpfPaciente.Text = FuncionarioLogado.PacienteSelecionado.Cpf;
            lblConvenioPaciente.Text = FuncionarioLogado.ConvenioSelecionado.Nome;
            dtpDataEntrada.Value = FuncionarioLogado.InternacaoTemp.DataEntrada;
            rtbDescricao.Text = FuncionarioLogado.InternacaoTemp.Descricao;
            cmbQuarto.Text = FuncionarioLogado.InternacaoTemp.QuartoId.ToString();
            cmbEstadoInternacao.Text = FuncionarioLogado.InternacaoTemp.TipoInternacao.ToString();
        }

        private void btnLimparRtb_Click(object sender, System.EventArgs e)
        {
            rtbDescricao.Text = string.Empty;
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormInternacoesDoutor formInterncoesDoutor = new FormInternacoesDoutor();
            Base.AbrirFormDesejado(this, formInterncoesDoutor);
        }

        private void AbrirExtratoInternacao()
        {
            FormExtratoInternacao formExtratoInternacao = new FormExtratoInternacao();
            Hide();
            formExtratoInternacao.PreencherValoresInternacao(FuncionarioLogado.PacienteSelecionado.Nome, FuncionarioLogado.PacienteSelecionado.Cpf, FuncionarioLogado.ConvenioSelecionado.Nome,
                (FuncionarioLogado.ConvenioSelecionado.Desconto * 100).ToString(), FuncionarioLogado.InternacaoTemp.DataEntrada.ToString("dd/MM/yyyy HH:mm"), DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                FuncionarioLogado.InternacaoTemp.QuartoId.ToString(), FuncionarioLogado.DoutorLogado.Nome, FuncionarioLogado.DoutorLogado.Especialidade.ToString(), FuncionarioLogado.ValorDiarioInternacaoADM.ToString(), internacaoBLL.DiasDeInternacao.ToString(),
                internacaoBLL.ValorDiarioTotal.ToString(), internacaoBLL.ValorDesconto.ToString(), internacaoBLL.ValorFinalInternacao.ToString());
            formExtratoInternacao.ShowDialog();
            Close();
        }

        private void BloquearPacientesComAlta()
        {
            if (!internacaoBLL.isDataSaidaNull(FuncionarioLogado.InternacaoTemp.Id))
            {
                rtbDescricao.ReadOnly = true;
                btnLimparRtb.Enabled = false;
                btnDarAltar.Enabled = false;
                btnAtualizarInternacao.Enabled = false;
                cmbEstadoInternacao.Enabled = false;
                cmbQuarto.Enabled = false;
            }
        }
    }
}
