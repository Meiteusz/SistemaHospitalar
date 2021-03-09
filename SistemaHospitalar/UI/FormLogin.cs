using SistemaHospitalar.DAL;
using SistemaHospitalar.Models;
using SistemaHospitalar.UI;
using SistemaHospitalar.Views;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            //LOGIN PARA TESTE
            txtEmail.Text = "amandaabreu@gmail.com";
            txtSenha.Text = "321a";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DalRecepionistas dalRecepcionistas = new DalRecepionistas();
            DalDoutores dalDoutores = new DalDoutores();
            Recepcionista recepionista = new Recepcionista(txtEmail.Text, txtSenha.Text);
            Doutores doutores = new Doutores(txtEmail.Text, txtSenha.Text);

            if (!rbRecepcionista.Checked && !rbDoutor.Checked)
            {
                MessageBox.Show("Escolha uma forma de Login");
            }

            if (rbDoutor.Checked)
            {
                if (dalDoutores.isLoginValido(doutores))
                {
                    Hide();
                    MessageBox.Show("Logado com sucesso!\nDoutor: " + dalDoutores.NomeDoutor, "Logando no Sistema Doutor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormEntradaDoutores entradaDoutor = new FormEntradaDoutores();
                    entradaDoutor.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show(dalDoutores.OutPut);
                }
            }
            else if (rbRecepcionista.Checked)
            {
                if (dalRecepcionistas.isLoginValido(recepionista))
                {
                    Hide();
                    MessageBox.Show("Logado com sucesso!\nRecepcionista: " + dalRecepcionistas.NomeRecepcionista, "Logando no Sistema Recepcionista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormEntradaRecepcionista entradaRecepcionista = new FormEntradaRecepcionista();
                    entradaRecepcionista.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show(dalRecepcionistas.OutPut);
                }
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormLoginADM loginADM = new FormLoginADM();
            Hide();
            loginADM.ShowDialog();
            Close();
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void btnVisitante_Click(object sender, EventArgs e)
        {
            FormEntradaRecepcionista entrada = new FormEntradaRecepcionista();
            Hide();
            entrada.ShowDialog();
            Close();
        }
    }
}
