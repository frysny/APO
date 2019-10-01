﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace APO_frysny
{
    public partial class MainForm : Form
    {        
        int obraz { get; set; }
        public MainForm()
        {
            InitializeComponent();
            obraz = 0;
        }

        private void ZamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void OtwórzObrazToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            Form _form = new Form();
            obraz++;
            IsMdiContainer = true;
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _form.Text = "Obrazek" + obraz;
            _form.Controls.Add(pictureBox);
            _form.MdiParent = this;
            _form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
