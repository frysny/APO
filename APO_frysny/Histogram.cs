using System.Drawing;
using System.Windows.Forms;

namespace APO_frysny
{
    public class Histogram : Form
    {
        public Form _form { get; set; }
        public Bitmap imagehist { get; set; }
        public Histogram(Form activeform)
        {
            _form = activeform;
            MakeHistogram(Image.FromFile(_form.Name));
        }

        public void MakeHistogram(Image image)
        {
            int red;
            int green;
            int blue;
            using (Bitmap bmp = new Bitmap(image))
            {
                Color clr = bmp.GetPixel(5, 5); // Get the color of pixel at position 5,5
                red = clr.R;
                green = clr.G;
                blue = clr.B;
            }
        }
    }    
}
