using SistemaHospitalar.DAL;
using System.Windows.Forms;

namespace SistemaHospitalar.UI
{
    public partial class FormAgendaDoutor : Form
    {
        public FormAgendaDoutor()
        {
            InitializeComponent();
            //dgvAgendaDoutor.DataSource = DalConsultas.MostrarAgendarDoutor(FormAgendarConsulta.DoutorId);
        }
    }
}
