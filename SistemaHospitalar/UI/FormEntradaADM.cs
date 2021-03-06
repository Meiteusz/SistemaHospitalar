using SistemaHospitalar.BLL;
using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Utilities;
using System;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormEntradaADM : Form
    {
        public FormEntradaADM()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtDiariaInternacao.Value = (decimal)FuncionarioLogado.ADMatual.ValorDiarioInternacao;
        }

        AdmBLL admBLL = new AdmBLL();

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            FormFuncionarios formFuncionarios = new FormFuncionarios();
            Base.AbrirFormDesejado(this, formFuncionarios);
        }

        private void btnConvenios_Click(object sender, EventArgs e)
        {
            FormConvenios formConvenios = new FormConvenios();
            Base.AbrirFormDesejado(this, formConvenios);
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            FormQuartos formQuartos = new FormQuartos();
            Base.AbrirFormDesejado(this, formQuartos);
        }

        private void btnAtualizarDiaria_Click(object sender, EventArgs e)
        {
            ADM adm = new ADM(FuncionarioLogado.ADMatual.Usuario, FuncionarioLogado.ADMatual.Senha, (float)txtDiariaInternacao.Value);

            MessageBox.Show(admBLL.AtualizarValorDiarioInternacao(adm));
        }

        private void btnFazerBackup_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();

            if (MessageBox.Show("Deseja fazer o Backup do Banco de Dados?", "BACKUP", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show(backup.Backupear(), DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            }
        }

        private void btnEncerrarSessão_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            Base.AbrirFormDesejado(this, formLogin);
        }
    }
}
