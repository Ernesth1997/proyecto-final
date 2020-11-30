using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ElectroSoftWPF
{
    public class Validaciones
    {

        public void validarLetras(TextCompositionEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "^[a-zA-Z]"))
            {
                e.Handled = true;
                MessageBox.Show("SOLO ADMITE LETRAS");

            }

        }
        public void email(TextCompositionEventArgs e)
        {
          
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.Text, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*"))

                e.Handled = true;
                MessageBox.Show("Ingrese un correo valido");
            
        }
        public void validarNumeros(TextCompositionEventArgs e)
        {
            int character = Convert.ToInt32(Convert.ToChar(e.Text));


            if (character >= 48 && character <= 57)


                e.Handled = false;

            else
            {

                e.Handled = true;
                MessageBox.Show("INGRESE UN NUMERO");
            }

        }
    }
}
   


