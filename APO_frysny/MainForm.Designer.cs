namespace APO_frysny
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzObrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.histogramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzObrazToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzObrazToolStripMenuItem
            // 
            this.otwórzObrazToolStripMenuItem.Name = "otwórzObrazToolStripMenuItem";
            this.otwórzObrazToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.otwórzObrazToolStripMenuItem.Text = "Otwórz obraz";
            this.otwórzObrazToolStripMenuItem.Click += new System.EventHandler(this.OtwórzObrazToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.ZamknijToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem1});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.histogramToolStripMenuItem.Text = "Operacje";
            // 
            // histogramToolStripMenuItem1
            // 
            this.histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
            this.histogramToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.histogramToolStripMenuItem1.Text = "Histogram";
            this.histogramToolStripMenuItem1.Click += new System.EventHandler(this.HistogramToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(943, 532);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "APO_frysny";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzObrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem1;
    }
}

