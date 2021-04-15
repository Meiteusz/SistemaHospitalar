using SistemaHospitalar.BLL;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormVisitas : Form
    {
        public FormVisitas()
        {
            InitializeComponent();
        }

        VisitantesBLL visitanteBLL = new VisitantesBLL();
        PacienteBLL pacienteBLL = new PacienteBLL();

        private void btnAgendarVisita_Click(object sender, EventArgs e)
        {

        }

        private void FormVisitas_Load(object sender, EventArgs e)
        {
            cbVisitantes.DisplayMember = "CPF";
            cbVisitantes.DataSource = visitanteBLL.MostrarCpfVisitantes();
            cbVisitantes.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbPacientes.DisplayMember = "CPF";
            cbPacientes.DataSource = pacienteBLL.MostrarCpfPacientesInternados();
            cbPacientes.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
