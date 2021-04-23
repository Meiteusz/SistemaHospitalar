using SistemaHospitalar.BLL;
using SistemaHospitalar.Models;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormVisitantes : Form
    {
        public FormVisitantes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvVisitantes.DataSource = visitasBLL.MostrarVisitantes();
        }

        VisitasBLL visitasBLL = new VisitasBLL();

        private void btnCadastrarVisitante_Click(object sender, EventArgs e)
        {
            Visitante visitante = new Visitante(txtNomeVisitante.Text, MtbCpfVisitante.Text);

            MessageBox.Show(visitasBLL.CadastrarVisitante(visitante));
            dgvVisitantes.DataSource = visitasBLL.MostrarVisitantes();
        }

        private void txtCpfVisitante_Click(object sender, EventArgs e)
        {
            Base.SelectionLength(MtbCpfVisitante);
        }

        private void FormVisitantes_Load(object sender, EventArgs e)
        {
            dgvVisitantes.Columns["ID"].Width = 50;
            dgvVisitantes.Columns["Visitante_Nome"].Width = 203;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
            Base.AbrirFormDesejado(this, formEntradaRecepcionista);
        }
    }
}
