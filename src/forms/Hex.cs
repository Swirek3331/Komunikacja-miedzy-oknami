using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarolSutkowski1TPKomunikacjaAplikacjiMDI.src
{
    public partial class Hex : Form
    {
        private static Hex instance;

        public static Hex Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Hex();
                }
                return instance;
            }
        }

        public Hex()
        {
            InitializeComponent();
        }
    }
}
