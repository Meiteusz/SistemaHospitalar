using SistemaHospitalar.BLL;
using SistemaHospitalar.Utilities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormAgendaDoutor : Form
    {
        public FormAgendaDoutor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dgvAgendaDoutor.DataSource = consultaBLL.AgendaDoutor(FuncionarioLogado.DoutorTemp.Id);
        }

        ConsultaBLL consultaBLL = new ConsultaBLL();

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAgendaDoutor_Load(object sender, EventArgs e)
        {
            dgvAgendaDoutor.Columns["Consultas_Exames"].Width = 231;
        }
    }
}
