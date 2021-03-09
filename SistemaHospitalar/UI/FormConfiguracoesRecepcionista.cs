using SistemaHospitalar.DAL;
using SistemaHospitalar.Models;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.Views
{
    public partial class FormConfiguracoes : Form
    {
        public FormConfiguracoes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cmbTurnoRecepcionista.DataSource = Enum.GetValues(typeof(Turno));
        }

        private void txtMaskedCelularRecepcionista_Click(object sender, EventArgs e)
        {
            if (txtMaskedCelularRecepcionista.Text.Equals("(  )      -"))
            {
                txtMaskedCelularRecepcionista.SelectionStart = txtMaskedCelularRecepcionista.SelectionLength = 0;
            }
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked)
            {
                txtSenhaRecepcionista.UseSystemPasswordChar = false;
                txtRepetirSenhaRecepcionista.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaRecepcionista.UseSystemPasswordChar = true;
                txtRepetirSenhaRecepcionista.UseSystemPasswordChar = true;
            }
        }

        private void FormConfiguracoes_Load(object sender, System.EventArgs e)
        {
            txtNomeRecepcionista.Text = DalRecepionistas.Nome;
            txtEmailRecepcionista.Text = DalRecepionistas.Email;
            txtSenhaRecepcionista.Text = DalRecepionistas.Senha;
            cmbTurnoRecepcionista.Text = DalRecepionistas.Turno;
            txtMaskedCelularRecepcionista.Text = DalRecepionistas.Celular;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormEntradaRecepcionista entradaRecepcionista = new FormEntradaRecepcionista();
            Hide();
            entradaRecepcionista.ShowDialog();
            Close();
        }


        //Deleta a conta logada como Recepcionista
        private void btnDeletarConta_Click(object sender, System.EventArgs e)
        {
            string MsgDeleçãoConta = "Deseja realmente excluir sua conta?\nTodos os dados da conta serão perdidos!";
            DalRecepionistas dalRecepionistas = new DalRecepionistas();

            int Id = int.Parse(DalRecepionistas.Id);

            if (MessageBox.Show(MsgDeleçãoConta, "Deleção de Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(dalRecepionistas.Deletar(Id));
                Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
                Close();
            }
        }


        //Atualiza as informações logada como Recepcionista
        private void btnAtualizarInformacoes_Click(object sender, System.EventArgs e)
        {
            string MsgAtualizarInformacoes = "Deseja realmente atualizar as informações da sua conta?";
            DalRecepionistas dalRecepionistas = new DalRecepionistas();

            Recepcionista recepcionista = new Recepcionista(txtNomeRecepcionista.Text,txtEmailRecepcionista.Text, txtMaskedCelularRecepcionista.Text, (Turno)cmbTurnoRecepcionista.SelectedIndex, txtSenhaRecepcionista.Text);

            if (MessageBox.Show(MsgAtualizarInformacoes, "Alterar Informações", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(dalRecepionistas.AtualizarInformacoes(recepcionista, txtRepetirSenhaRecepcionista.Text));
            }
        }
    }
}
