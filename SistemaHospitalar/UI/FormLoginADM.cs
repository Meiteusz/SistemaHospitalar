using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.UI;
using System.Windows.Forms;

namespace SistemaHospitalar.Views
{
    public partial class FormLoginADM : Form
    {
        public FormLoginADM()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;


            txtUsuario.Text = "admin";
            txtSenha.Text = "admin";
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            DalADM dalAdm = new DalADM();
            ADM adm = new ADM(txtUsuario.Text, txtSenha.Text) ;
            
            if (dalAdm.isAcessoValido(adm))
            {
                FormEntradaADM formEntradaADM = new FormEntradaADM();
                Hide();
                formEntradaADM.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show(dalAdm.OutPut);
            }
        }
    }
}
