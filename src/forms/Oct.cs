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
    public partial class Oct : Form
    {
        private static Oct instance;

        public Label _resultLabel => resultLabel;

        public static Oct Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Oct();
                }
                return instance;
            }
        } 

        public Oct()
        {
            InitializeComponent();
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
