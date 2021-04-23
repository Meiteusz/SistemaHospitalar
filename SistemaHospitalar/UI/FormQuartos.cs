using SistemaHospitalar.BLL;
using SistemaHospitalar.Entities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormQuartos : Form
    {
        public FormQuartos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            rbTodosQuartos.Checked = true;
        }

        QuartosBLL quartosBLL = new QuartosBLL();

        private void btnCadastrarQuarto_Click(object sender, EventArgs e)
        {
            Quartos quarto = new Quartos((int)txtNumeroQuarto.Value, true);

            MessageBox.Show(quartosBLL.CadastrarQuarto(quarto));
        }

        private void rbTodosQuartos_CheckedChanged(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = quartosBLL.MostrarQuartos();
        }

        private void rbQuartosDisponiveis_CheckedChanged(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = quartosBLL.MostrarQuartosDisponiveis();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaADM formEntradaADM = new FormEntradaADM();
            Base.AbrirFormDesejado(this, formEntradaADM);
        }

        private void FormQuartos_Load(object sender, EventArgs e)
        {
            dgvQuartos.Columns["Numero_Quarto"].Width = 151;
            dgvQuartos.Columns["isDisponivel"].Width = 152;
        }
    }
}
