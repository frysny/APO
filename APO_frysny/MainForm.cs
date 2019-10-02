using System;
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
            IsMdiContainer = true;
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
            MakePictureForm(openFileDialog);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        public PictureBox MakePictureBox(string picturepath)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Image.FromFile(picturepath);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            return pictureBox;
        }
        public void MakePictureForm(OpenFileDialog ofg)
        {
            Form _form = new Form();
            obraz++;
            PictureBox pictureBox = MakePictureBox(ofg.FileName);
            _form.Text= "Obrazek" + obraz;
            _form.Name = ofg.FileName;
            _form.Controls.Add(pictureBox);
            _form.MdiParent = this;
            _form.Show();
        }

        private void HistogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) { Histogram hist = new Histogram(this.ActiveMdiChild); };
        }
    }
}
