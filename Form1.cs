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
            this.WindowState = FormWindowState.Maximized;
        }

        private void closeShutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputOpen_Click(object sender, EventArgs e)
        {
            Utilities.ShowWindow(Calculator.Instance, this, "Calculator");
        }

        private void binaryOpen_Click(object sender, EventArgs e)
        {
            Utilities.ShowWindow(Bin.Instance, this, "Binary");
        }

        private void octalOpen_Click(object sender, EventArgs e)
        {
            Utilities.ShowWindow(Oct.Instance, this, "Octal");
        }

        private void hexadecimalOpen_Click(object sender, EventArgs e)
        {
            Utilities.ShowWindow(Hex.Instance, this, "Hexadecimal");
        }
    }
}
