using SistemaHospitalar.BLL;
using SistemaHospitalar.Models;
using SistemaHospitalar.Utilities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormConfiguracoesDoutores : Form
    {
        public FormConfiguracoesDoutores()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbTurnoDoutor.DataSource = Enum.GetValues(typeof(Turno));
        }

        DoutoresBLL doutoresBLL = new DoutoresBLL();

        private void btnAtualizarInformacoes_Click(object sender, EventArgs e)
        {
            Doutores doutores = new Doutores(txtNomeDoutor.Text, txtEmailDoutor.Text, txtMaskedCelularDoutor.Text, (Turno)cmbTurnoDoutor.SelectedIndex, txtSenhaDoutor.Text);

            if (MessageBox.Show(doutoresBLL.MsgAtualizarInformacoes, "Alterar Informações", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(doutoresBLL.AtualizarDoutor(doutores, txtRepetirSenhaDoutor.Text));
            }
        }


        private void txtMaskedCelularDoutor_Click(object sender, EventArgs e)
        {
            if (txtMaskedCelularDoutor.Text.Equals("(  )      -"))
            {
                txtMaskedCelularDoutor.SelectionStart = txtMaskedCelularDoutor.SelectionLength = 0;
            }
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            Base.MostrarSenha(cbMostrarSenha, txtSenhaDoutor, txtRepetirSenhaDoutor);
        }

        private void FormConfiguracoesDoutores_Load(object sender, System.EventArgs e)
        {
            txtNomeDoutor.Text = FuncionarioLogado.DoutorLogado.Nome;
            txtEmailDoutor.Text = FuncionarioLogado.DoutorLogado.Email;
            txtMaskedCelularDoutor.Text = FuncionarioLogado.DoutorLogado.Celular;
            cmbTurnoDoutor.Text = FuncionarioLogado.DoutorLogado.Turno.ToString();
            txtSenhaDoutor.Text = FuncionarioLogado.DoutorLogado.Senha;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Base.AbrirFormDesejado(this, formEntradaDoutores);
        }

    }
}
