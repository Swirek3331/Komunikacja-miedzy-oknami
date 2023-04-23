using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolSutkowski1TPKomunikacjaAplikacjiMDI.src
{
    internal class Utilities
    {
        public static string FromBaseTenToAny(int number, byte baseNumber)
        {
            string result = "";
            while (number > 0)
            {
                result += FromBaseTenToAny(number / baseNumber, baseNumber);

                if (number % baseNumber > 9)
                {
                    result += (number % baseNumber).ToString("X");
                }
                else
                {
                    result += (number % baseNumber).ToString();
                }
            }

            return result;
        }

        public static void ShowWindow(Form form, Form container, string tag)
        {
            form.Tag = tag;
            form.MdiParent = container;
            form.Icon = container.Icon;

            form.Activate();
            form.Show();
        }

        public static void ShowWindow(Form form, Form container, string tag, Icon icon)
        {
            form.Tag = tag;
            form.MdiParent = container;
            form.Icon = icon;

            form.Activate();
            form.Show();
        }

        public static void Checker(TextBox textBox)
        {
            if (textBox.Text[0] == '0')
            {
            
                for (int i = 0; i < textBox.Text.Length; i++)
                {

                    textBox.Text = textBox.Text.Remove(0, 1);
                    if (textBox.Text[0] != '0')
                    {
                        break;
                    }
                }
            }
        }
    }
}
