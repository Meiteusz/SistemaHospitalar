using System;
using System.Windows.Forms;

namespace SistemaHospitalar.BLL
{
    public static class Base
    {
        public static void AbrirFormDesejado(Form formAtual, Form formAnterior)
        {
            formAtual.Hide();
            formAnterior.ShowDialog();
            formAtual.Close();
        }

        public static void LimparTxtEtc()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    if (control is MaskedTextBox)
                    {
                        (control as MaskedTextBox).Clear();
                    }
                    if (control is ComboBox)
                    {
                        (control as ComboBox).SelectedIndex = 0;
                    }
                    //if (c is ComboBox)
                    //{
                    //    (c as ComboBox).SelectedItem = "Nenhum";
                    //}
                    else
                    {
                        func(control.Controls);
                    }
                }
            func(controls);
            };
        }
    }
}
