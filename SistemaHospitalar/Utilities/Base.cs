using System;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

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

        public static void LimparTxtEtc(ControlCollection Controls)
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
                    if (control is RichTextBox)
                    {
                        (control as RichTextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }

        public static void MostrarSenha(Control cb, Control txtPass, Control txtRepeat)
        {
            if ((cb as CheckBox).Checked)
            {
                (txtPass as TextBox).UseSystemPasswordChar = false;
                (txtRepeat as TextBox).UseSystemPasswordChar = false;
            }
            else
            {
                (txtPass as TextBox).UseSystemPasswordChar = true;
                (txtRepeat as TextBox).UseSystemPasswordChar = true;
            }
        }

        public static void SelectionLength(Control control)
        {
            if (control is MaskedTextBox)
            {
                if ((control as MaskedTextBox).Text.Equals("   .   .   -") || (control as MaskedTextBox).Text.Equals("(  )      -"))
                {
                    (control as MaskedTextBox).SelectionStart = (control as MaskedTextBox).SelectionLength = 0;
                }
            }
        }

        //public static List<string> ReformularEspecialidades()
        //{
        //    IEnumerable<Especialidades> values = Enum.GetValues(typeof(Especialidades)).Cast<Especialidades>();
        //    List<string> valuesWithSpaces = new List<string>(values.Select(v => v.ToString().Replace("_", " ")));
        //    return valuesWithSpaces;
        //}

        //public static List<string> ReformularTipoInternacao()
        //{
        //    IEnumerable<TipoInternacao> values = Enum.GetValues(typeof(TipoInternacao)).Cast<TipoInternacao>();
        //    List<string> valuesWithSpaces = new List<string>(values.Select(v => v.ToString().Replace("_", " ")));
        //    return valuesWithSpaces;
        ////}

    }
}
