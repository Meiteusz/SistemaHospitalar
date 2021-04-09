using System.Windows.Forms;

namespace SistemaHospitalar.BLL
{
    public static class Base
    {
        public static void VoltarFormAnterior(Form formAtual, Form formAnterior)
        {
            formAtual.Hide();
            formAnterior.ShowDialog();
            formAtual.Close();
        }
    }
}
