using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using SistemaHospitalar.UI;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.Views
{
    public partial class FormCadastroDoutor : Form
    {
        public FormCadastroDoutor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbTurnoDoutor.DataSource = Enum.GetValues(typeof(Turno));
            cmbGeneroDoutor.DataSource = Enum.GetValues(typeof(Genero));
            cmbEspecialidadeDoutor.DataSource = Enum.GetValues(typeof(Especialidades));
        }

        DoutoresBLL doutorBLL = new DoutoresBLL();

        private void btnCadastrarDoutor_Click(object sender, EventArgs e)
        {
            Doutores doutor = new Doutores(txtNomeDoutor.Text, txtEmailDoutor.Text, txtSenhaDoutor.Text, MtbCpfDoutor.Text, (Turno)cmbTurnoDoutor.SelectedIndex,
           (Genero)cmbGeneroDoutor.SelectedIndex, (Especialidades)cmbEspecialidadeDoutor.SelectedIndex, MtbCelularDoutor.Text, (float)txtValorConsulta.Value, (float)txtValorExame.Value);

            MessageBox.Show(doutorBLL.CadastrarDoutor(doutor, txtRepitaSenhaDoutor.Text));
        }

        private void cbMostrarSenha_CheckedChanged(object sender, System.EventArgs e)
        {
            Base.MostrarSenha(cbMostrarSenha, txtSenhaDoutor, txtRepitaSenhaDoutor);
        }

        private void txtMaskedCpfDoutor_Click(object sender, EventArgs e)
        {
            Base.SelectionLength(MtbCpfDoutor);
        }

        private void txtMaskedCelularDoutor_Click(object sender, EventArgs e)
        {
            Base.SelectionLength(MtbCelularDoutor);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Base.LimparTxtEtc(Controls);
            txtValorConsulta.Value = (decimal)0.00;
            txtValorExame.Value = (decimal)0.00;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormFuncionarios formADM = new FormFuncionarios();
            Base.AbrirFormDesejado(this, formADM);
        }
    }
}
