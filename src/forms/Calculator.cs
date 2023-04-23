﻿using Omlcs.src;
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
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            mainTextBox.Text += button.Text;
        }

        private void TextBox_Clear(object sender, EventArgs e)
        {
            mainTextBox.Clear();
        }

        private void Backspace(object sender, EventArgs e)
        {
            mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1);
        }
    }
}
