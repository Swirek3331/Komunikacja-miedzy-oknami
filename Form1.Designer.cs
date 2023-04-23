namespace KarolSutkowski1TPKomunikacjaAplikacjiMDI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.inputOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.octalOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.hexadecimalOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 30);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // openMenu
            // 
            this.openMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputOpen,
            this.binaryOpen,
            this.octalOpen,
            this.hexadecimalOpen,
            this.toolStripMenuItem1,
            this.closeShutdown});
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(71, 26);
            this.openMenu.Text = "Otwórz";
            // 
            // inputOpen
            // 
            this.inputOpen.Name = "inputOpen";
            this.inputOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.inputOpen.Size = new System.Drawing.Size(297, 26);
            this.inputOpen.Text = "Wprowadź dane";
            this.inputOpen.Click += new System.EventHandler(this.inputOpen_Click);
            // 
            // binaryOpen
            // 
            this.binaryOpen.Name = "binaryOpen";
            this.binaryOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.binaryOpen.Size = new System.Drawing.Size(297, 26);
            this.binaryOpen.Text = "Wynik binarny";
            this.binaryOpen.Click += new System.EventHandler(this.binaryOpen_Click);
            // 
            // octalOpen
            // 
            this.octalOpen.Name = "octalOpen";
            this.octalOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.octalOpen.Size = new System.Drawing.Size(297, 26);
            this.octalOpen.Text = "Wynik oktalny";
            this.octalOpen.Click += new System.EventHandler(this.octalOpen_Click);
            // 
            // hexadecimalOpen
            // 
            this.hexadecimalOpen.Name = "hexadecimalOpen";
            this.hexadecimalOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hexadecimalOpen.Size = new System.Drawing.Size(297, 26);
            this.hexadecimalOpen.Text = "Wynik heksadecymalny";
            this.hexadecimalOpen.Click += new System.EventHandler(this.hexadecimalOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(294, 6);
            // 
            // closeShutdown
            // 
            this.closeShutdown.Name = "closeShutdown";
            this.closeShutdown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeShutdown.Size = new System.Drawing.Size(297, 26);
            this.closeShutdown.Text = "Zamknij";
            this.closeShutdown.Click += new System.EventHandler(this.closeShutdown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem inputOpen;
        private System.Windows.Forms.ToolStripMenuItem binaryOpen;
        private System.Windows.Forms.ToolStripMenuItem octalOpen;
        private System.Windows.Forms.ToolStripMenuItem hexadecimalOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeShutdown;
    }
}

