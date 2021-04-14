using SistemaHospitalar.BLL;
using SistemaHospitalar.Models;
using SistemaHospitalar.UI;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.Views
{
    public partial class FormCadastroRecepcionista : Form
    {
        public FormCadastroRecepcionista()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbTurnoRecepcionista.DataSource = Enum.GetValues(typeof(Turno));
            cmbGeneroRecepcionista.DataSource = Enum.GetValues(typeof(Genero));
        }

        RecepcionistaBLL recepcionistaBLL = new RecepcionistaBLL();

        private void btnCadastrarRecepcionista_Click(object sender, System.EventArgs e)
        {
            Recepcionista recepcionista = new Recepcionista(txtNomeRecepcionista.Text, MtbCpfRecepcionista.Text, MtbCelularRecepcionista.Text,
            (Turno)cmbTurnoRecepcionista.SelectedIndex, (Genero)cmbGeneroRecepcionista.SelectedIndex, txtEmailRecepcionista.Text, txtSenhaRecepcionista.Text);

            MessageBox.Show(recepcionistaBLL.CadastrarRecepcionista(recepcionista, txtRepitaSenhaRecepcionista.Text));
        }


        private void txtMaskedCpfRecepcionista_Click(object sender, EventArgs e)
        {
            if (MtbCpfRecepcionista.Text.Equals("   .   .   -"))
            {
                MtbCpfRecepcionista.SelectionStart = MtbCpfRecepcionista.SelectionLength = 0;
            }
        }

        private void txtMaskedCelularRecepcionista_Click(object sender, EventArgs e)
        {
            if (MtbCelularRecepcionista.Text.Equals("(  )      -"))
            {
                MtbCelularRecepcionista.SelectionStart = MtbCelularRecepcionista.SelectionLength = 0;
            }
        }
        
        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            Base.MostrarSenha(cbMostrarSenha, txtSenhaRecepcionista, txtRepitaSenhaRecepcionista);
        }
        
        private void btnApagar_Click(object sender, EventArgs e)
        {
            Base.LimparTxtEtc(Controls);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormFuncionarios formADM = new FormFuncionarios();
            Base.AbrirFormDesejado(this, formADM);
        }
    }
}
