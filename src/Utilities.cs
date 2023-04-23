using System;
using System.Collections.Generic;
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

        public static void ShowWindow(Form form)
        {
            form.Show();
        }
    }
}
