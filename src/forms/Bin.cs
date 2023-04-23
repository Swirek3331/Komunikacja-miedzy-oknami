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
    public partial class Bin : Form
    {
        private static Bin instance;
        
        public static Bin Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bin();
                }
                return instance;
            }
        }
        
        public Bin()
        {
            InitializeComponent();
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
