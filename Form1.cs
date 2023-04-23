using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KarolSutkowski1TPKomunikacjaAplikacjiMDI.src;
using Omlcs.src;

namespace KarolSutkowski1TPKomunikacjaAplikacjiMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Colores.HexColor("#0000ff");
        }
    }
}
