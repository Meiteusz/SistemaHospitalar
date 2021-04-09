using SistemaHospitalar.BLL;
using SistemaHospitalar.Models;
using SistemaHospitalar.UI;
using SistemaHospitalar.Utilities;
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
            #region Login Recepcionista
            //txtEmail.Text = "rosanabnu@gmail.com";
            //txtSenha.Text = "321ab";
            //rbRecepcionista.Checked = true;
            #endregion

            #region Login Doutor(a)
            txtEmail.Text = "brunalupa@gmail.com";
            txtSenha.Text = "321ab";
            rbDoutor.Checked = true;
            #endregion
        }

        RecepcionistaBLL recepcionistaBLL = new RecepcionistaBLL();
        DoutoresBLL doutoresBLL = new DoutoresBLL();

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Recepcionista recepionista = new Recepcionista(txtEmail.Text, txtSenha.Text);
            Doutores doutor = new Doutores(txtEmail.Text, txtSenha.Text);

            if (rbDoutor.Checked)
            {
                if (doutoresBLL.LogarDoutor(doutor).Equals(string.Empty))
                {
                    Hide();
                    MessageBox.Show("Doutor(a) logado com sucesso!\n\t" + FuncionarioLogado.DoutorLogado.Nome);
                    FormEntradaDoutores formEntradaDoutor = new FormEntradaDoutores();
                    formEntradaDoutor.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show(doutoresBLL.OutPut);
                }
            }
            else if (rbRecepcionista.Checked)
            {
                if (recepcionistaBLL.LogarRecepcionista(recepionista).Equals(string.Empty))
                {
                    Hide();
                    MessageBox.Show("Recepcionista logado com sucesso!\n\t" + FuncionarioLogado.RecepcionistaLogada.Nome);
                    FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
                    formEntradaRecepcionista.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show(recepcionistaBLL.OutPut);
                }
            }
            else
            {
                MessageBox.Show("Escolha uma forma de Login");
            }

        }

        private void btnADM_Click(object sender, EventArgs e)
        {
            FormLoginADM loginADM = new FormLoginADM();
            Base.AbrirFormDesejado(this, loginADM);
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked)
                txtSenha.UseSystemPasswordChar = false;
            else
                txtSenha.UseSystemPasswordChar = true;
        }
    }
}
