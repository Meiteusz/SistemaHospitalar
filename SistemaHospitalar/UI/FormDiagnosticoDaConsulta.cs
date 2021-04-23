using SistemaHospitalar.BLL;
using SistemaHospitalar.Utilities;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormDiagnosticoDaConsulta : Form
    {
        public FormDiagnosticoDaConsulta()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pacienteBLL.PegarDadosPaciente(FuncionarioLogado.ConsultaTemp.Paciente ,string.Empty);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        PacienteBLL pacienteBLL = new PacienteBLL();

        private void FormDiagnosticoDaConsulta_Load(object sender, System.EventArgs e)
        {
            lblNomePaciente.Text = FuncionarioLogado.PacienteSelecionado.Nome;
            lblCpfPaciente.Text = FuncionarioLogado.PacienteSelecionado.Cpf;
            lblNomeDoutor.Text = FuncionarioLogado.DoutorLogado.Nome; 
            lblCelularDoutor.Text = FuncionarioLogado.DoutorLogado.Celular;
            lblDiaConsulta.Text = FuncionarioLogado.ConsultaTemp.DataConsulta.ToString("dd/MM/yyyy HH:mm");
            lblValorConsulta.Text = "R$" +  FuncionarioLogado.ConsultaTemp.Preco.ToString();
        }

        Bitmap bmp;
        private void btnFazerDiagnostico_Click(object sender, System.EventArgs e)
        {
            Panel panel = new Panel();
            Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = ClientSize;
            bmp = new Bitmap(formSize.Width, 694, grp);
            grp = Graphics.FromImage(bmp);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.Width = 800;
            printPreviewDialog1.Height = 800;
            printPreviewDialog1.ShowDialog();
        }
    }
}
