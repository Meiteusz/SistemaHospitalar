using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
using SistemaHospitalar.Models;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.Views
{
    public partial class FormConfiguracoes : Form
    {
        public FormConfiguracoes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbTurnoRecepcionista.DataSource = Enum.GetValues(typeof(Turno));
        }

        RecepcionistaBLL recepcionistaBLL = new RecepcionistaBLL();

        private void txtMaskedCelularRecepcionista_Click(object sender, EventArgs e)
        {
            if (txtMaskedCelularRecepcionista.Text.Equals("(  )      -"))
            {
                txtMaskedCelularRecepcionista.SelectionStart = txtMaskedCelularRecepcionista.SelectionLength = 0;
            }
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked)
            {
                txtSenhaRecepcionista.UseSystemPasswordChar = false;
                txtRepetirSenhaRecepcionista.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaRecepcionista.UseSystemPasswordChar = true;
                txtRepetirSenhaRecepcionista.UseSystemPasswordChar = true;
            }
        }

        private void FormConfiguracoes_Load(object sender, EventArgs e)
        {
            Recepcionista a = new Recepcionista();

            a = recepcionistaBLL.PegarDadosRecepcionista(RecepcionistaBLL.Id);

            txtNomeRecepcionista.Text = a.Nome;
            txtEmailRecepcionista.Text = a.Email;
            txtSenhaRecepcionista.Text = a.Senha;
            cmbTurnoRecepcionista.Text = a.Turno.ToString();
            txtMaskedCelularRecepcionista.Text = a.Celular;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Base.VoltarFormAnterior(this, formEntradaRecepcionista);
        }

        //Atualiza as informações logada como Recepcionista
        private void btnAtualizarInformacoes_Click(object sender, System.EventArgs e)
        {
            Recepcionista recepcionista = new Recepcionista(txtNomeRecepcionista.Text, txtEmailRecepcionista.Text, txtMaskedCelularRecepcionista.Text, (Turno)cmbTurnoRecepcionista.SelectedIndex, txtSenhaRecepcionista.Text);

            if (MessageBox.Show(recepcionistaBLL.MsgAtualizarInformacoes, "Alterar Informações", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(recepcionistaBLL.AtualizarRecepcionista(recepcionista, txtRepetirSenhaRecepcionista.Text));
            }
        }
    }
}
