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
        private static Form1 instance;

        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Form1();
                }
                return instance;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void inputOpen_Click(object sender, EventArgs e)
        {
            Utilities.ShowWindow(Calculator.Instance, this, "Calculator");
        }

        private void binaryOpen_Click(object sender, EventArgs e)
        {
            Calculator.Instance.toBin_Click(sender, e);
        }

        private void octalOpen_Click(object sender, EventArgs e)
        {
            Calculator.Instance.toOct_Click(sender, e);
        }

        private void hexadecimalOpen_Click(object sender, EventArgs e)
        {
            Calculator.Instance.toHex_Click(sender, e);
        }

        private void closeShutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
