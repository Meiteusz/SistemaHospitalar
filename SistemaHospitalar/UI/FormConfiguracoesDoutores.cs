using SistemaHospitalar.DAL;
using SistemaHospitalar.Models;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormConfiguracoesDoutores : Form
    {
        public FormConfiguracoesDoutores()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbTurnoDoutor.DataSource = Enum.GetValues(typeof(Turno));
        }

        private void FormConfiguracoesDoutores_Load(object sender, System.EventArgs e)
        {
            txtNomeDoutor.Text = DalDoutores.Nome;
            txtEmailDoutor.Text = DalDoutores.Email;
            txtMaskedCelularDoutor.Text = DalDoutores.Celular;
            cmbTurnoDoutor.Text = DalDoutores.Turno;
            txtSenhaDoutor.Text = DalDoutores.Senha;
        }

        private void btnAtualizarInformacoes_Click(object sender, EventArgs e)
        {
            string MsgAtualizarInformacoes = "Deseja realmente atualizar as informações da sua conta?";
            DalDoutores dalDoutores = new DalDoutores();

            Doutores doutores = new Doutores(txtNomeDoutor.Text, txtEmailDoutor.Text, txtMaskedCelularDoutor.Text, (Turno)cmbTurnoDoutor.SelectedIndex, txtSenhaDoutor.Text);

            if (MessageBox.Show(MsgAtualizarInformacoes, "Alterar Informações", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(dalDoutores.AtualizarInformacoes(doutores, txtRepetirSenhaDoutor.Text));
            }
        }

        private void btnDeletarConta_Click(object sender, EventArgs e)
        {
            string msgDelecaoConta = "Deseja realmente excluir sua conta?\nTodos os dados da conta serão perdidos!";
            DalDoutores dalDoutores = new DalDoutores();

            int Id = int.Parse(DalDoutores.Id);

            if (MessageBox.Show(msgDelecaoConta, "Deleção de Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(dalDoutores.DeletarDoutor(Id));
                FormLogin formLogin = new FormLogin();
                Hide();
                formLogin.ShowDialog();
                Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaDoutores formEntradaDoutores = new FormEntradaDoutores();
            Hide();
            formEntradaDoutores.ShowDialog();
            Close();
        }
    }
}
