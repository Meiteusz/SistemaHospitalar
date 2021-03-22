using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormComprovantePagamento : Form
    {
        public FormComprovantePagamento()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
