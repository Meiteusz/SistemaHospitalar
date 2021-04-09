using SistemaHospitalar.BLL;
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

            //*Recepcionista*
            txtEmail.Text = "rosanabnu@gmail.com";
            txtSenha.Text = "321ab";
            rbRecepcionista.Checked = true;

            //*Doutor*
            //txtEmail.Text = "brunalupa@gmail.com";
            //txtSenha.Text = "321ab";
            //rbDoutor.Checked = true;
        }

        RecepcionistaBLL recepcionistaBLL = new RecepcionistaBLL();

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
                    MessageBox.Show("Logado com sucesso!\nDoutor: " + DalDoutores.NomeDoutor, "Logando no Sistema Doutor", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (recepcionistaBLL.LogarRecepcionista(recepionista).Equals(string.Empty))
                {
                    Hide();
                    MessageBox.Show("Recepcionista logado com sucesso!\n" + recepionista.Nome);
                    FormEntradaRecepcionista entradaRecepcionista = new FormEntradaRecepcionista();
                    entradaRecepcionista.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show(recepcionistaBLL.OutPut);
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
    }
}
