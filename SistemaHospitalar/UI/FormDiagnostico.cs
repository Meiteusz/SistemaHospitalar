using SistemaHospitalar.DAL;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormDiagnostico : Form
    {
        public FormDiagnostico()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtNomePaciente.Text = DalConsultas.NomePaciente;
        }



        Bitmap bmp;

        private void btnFazerDiagnostico_Click(object sender, System.EventArgs e)
        {
            //FormEscolhaDeVisualizacaoDiagnostico formEscolhaDeVisualizacao = new FormEscolhaDeVisualizacaoDiagnostico();
            //Hide();
            //formEscolhaDeVisualizacao.ShowDialog();
            //Close();

            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bmp = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bmp);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
