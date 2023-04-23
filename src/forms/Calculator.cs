using Omlcs.src;
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
    public partial class Calculator : Form
    {
        private static Calculator instance;


        public static Calculator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculator();
                }
                return instance;
            }
        }

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            mainTextBox.Text += button.Text;
            
            /*
             * Z nieznanych przczyn czasem jak się kliknie za szybko guziki
             * Program dostaję szmerlga
             */
        }

        private void TextBox_Clear(object sender, EventArgs e)
        {
            mainTextBox.Clear();
        }

        private void Backspace(object sender, EventArgs e)
        {
            if (mainTextBox.Text.Length > 0)
            {
                mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
            }
        }

        public void toBin_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text.Length > 0)
            {
                Utilities.Checker(mainTextBox);
                Bin.Instance._resultLabel.Text = Utilities.FromBaseTenToAny(Convert.ToInt32(mainTextBox.Text), 2);
                if (!Bin.Instance.Visible)
                {
                    Bin.Instance.Activate();
                    Bin.Instance.Show();
                    Bin.Instance.Icon = Form1.Instance.Icon;
                }
            }
        }

        public void toOct_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text.Length > 0)
            {
                Utilities.Checker(mainTextBox);
                Oct.Instance._resultLabel.Text = Utilities.FromBaseTenToAny(Convert.ToInt32(mainTextBox.Text), 8);
                if (!Oct.Instance.Visible)
                {
                    Oct.Instance.Activate();
                    Oct.Instance.Show();
                    Oct.Instance.Icon = Form1.Instance.Icon;
                }
            }
        }

        public void toHex_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text.Length > 0)
            {
                Utilities.Checker(mainTextBox);
                Hex.Instance._resultLabel.Text = Utilities.FromBaseTenToAny(Convert.ToInt32(mainTextBox.Text), 16);
                if (!Hex.Instance.Visible)
                {
                    Hex.Instance.Activate();
                    Hex.Instance.Show();
                    Hex.Instance.Icon = Form1.Instance.Icon;
                }
            }
        }
    }
}