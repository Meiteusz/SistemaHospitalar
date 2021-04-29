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
            //txtEmail.Text = "RecepcionistaTeste1@gmail.com";
            //txtSenha.Text = "123a";
            //rbRecepcionista.Checked = true;
            #endregion

            #region Login Doutor(a)
            //txtEmail.Text = "DoutorTeste1@gmail.com";
            //txtSenha.Text = "123a";
            //rbDoutor.Checked = true;
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
                    FormEntradaDoutores formEntradaDoutor = new FormEntradaDoutores();
                    MessageBox.Show("Bem vindo(a) " + FuncionarioLogado.DoutorLogado.Nome, "Doutor(a) logado com sucesso!");
                    Base.AbrirFormDesejado(this, formEntradaDoutor);
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
                    FormEntradaRecepcionista formEntradaRecepcionista = new FormEntradaRecepcionista();
                    MessageBox.Show("Bem vindo(a) " + FuncionarioLogado.RecepcionistaLogada.Nome, "Recepcionista logado com sucesso!");
                    Base.AbrirFormDesejado(this, formEntradaRecepcionista);
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
            Base.MostrarSenha(cbMostrarSenha, txtSenha, txtSenha);
        }
    }
}
