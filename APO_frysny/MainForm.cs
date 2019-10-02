using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace APO_frysny
{
    public partial class MainForm : Form
    {        
        int Obraz { get; set; }
        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
            Obraz = 0;
            this.IsMdiContainer = true;
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
            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = Image.FromFile(picturepath),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            return pictureBox;
        }
        public PictureBox MakePictureBox(Bitmap bitmap)
        {
            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = bitmap,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            return pictureBox;
        }
        public void MakePictureForm(OpenFileDialog ofg)
        {
            Form _form = new Form();
            Obraz++;
            PictureBox pictureBox = MakePictureBox(ofg.FileName);
            _form.Text= "Obrazek" + Obraz;
            _form.Name = ofg.FileName;
            _form.Controls.Add(pictureBox);
            _form.MdiParent = this;
            _form.Show();
        }
        public void MakeHistoForm(Bitmap bitmap, string picname)
        {
            Form _form = new Form();
            _form.MdiParent = this;
            _form.Text = "Histogram dla " + picname;
            _form.Name = "Histogram";
            PictureBox pictureBox = MakePictureBox(bitmap);
            _form.Controls.Add(pictureBox);           
            _form.Show();
        }

            private void HistogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Histogram hist = new Histogram(this.ActiveMdiChild);

            if (this.ActiveMdiChild != null) {
                MakeHistoForm(hist.MakeHistogram(Image.FromFile(this.ActiveMdiChild.Name)),this.ActiveMdiChild.Text);
            };
        }
    }
}
