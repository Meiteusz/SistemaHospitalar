using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormValores : Form
    {
        public FormValores()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            VerificarValorExistente();
        }

        private void VerificarValorExistente()
        {
            if (DalValores.isValorDefinido(int.Parse(DalDoutores.Id)))
            {
                btnCadastrarValor.Text = "Atualizar Valores";
            }
        }

        // O doutor(a) poderá cadastrar os valores apenas uma vez, depois só atualiza-lo
        private void btnCadastrarValor_Click(object sender, System.EventArgs e)
        {
            Valores valor = new Valores((float)txtValorConsulta.Value, (float)txtValorExame.Value, int.Parse(DalDoutores.Id));
            DalValores dalValores = new DalValores();

            if (btnCadastrarValor.Text.Equals("Atualizar Valores"))
            {
                MessageBox.Show(dalValores.AtualizarValor(valor));
            }
            else
            {
                MessageBox.Show(dalValores.CadastrarValor(valor));
            }
        }

        private void btnVoltar_Click(object sender, System.EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Hide();
            formEntradaDoutores.ShowDialog();
            Close();
        }
    }
}
