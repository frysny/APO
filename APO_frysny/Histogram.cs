using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace APO_frysny
{
    public class Histogram : Form
    {
        public Form Form { get; set; }
        public Histogram(Form activeform)
        {
            Form = activeform;
            MakeHistogram(Image.FromFile(Form.Name));
        }

        public Bitmap MakeHistogram(Image image)
        {
            Bitmap bmp = new Bitmap(image);

                BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* ptr = (byte*)data.Scan0;

                    int remain = data.Stride - data.Width * 3;

                    int[] histogram = new int[256];
                    for (int i = 0; i < histogram.Length; i++)
                        histogram[i] = 0;

                    for (int i = 0; i < data.Height; i++)
                    {
                        for (int j = 0; j < data.Width; j++)
                        {
                            int mean = ptr[0] + ptr[1] + ptr[2];
                            mean /= 3;

                            histogram[mean]++;
                            ptr += 3;
                        }

                        ptr += remain;
                    }
                bmp.UnlockBits(data);
                return RysujHistogram(histogram);

                }       

        }
        public Bitmap RysujHistogram(int[] histogram)
        {
            Bitmap bmp = new Bitmap(histogram.Length + 10, 310);

            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                int remain = data.Stride - data.Width * 3;
                byte* ptr = (byte*)data.Scan0;

                for (int i = 0; i < data.Height; i++)
                {

                    for (int j = 0; j < data.Width; j++)
                    {
                        ptr[0] = ptr[1] = ptr[2] = 150;
                        ptr += 3;
                    }
                    ptr += remain;

                }

                int max = 0;
                for (int i = 0; i < histogram.Length; i++)
                {

                    if (max < histogram[i])
                        max = histogram[i];

                }

                for (int i = 0; i < histogram.Length; i++)
                {
                    ptr = (byte*)data.Scan0;
                    ptr += data.Stride * (305) + (i + 5) * 3;

                    int length = (int)(1.0 * histogram[i] * 300 / max);

                    for (int j = 0; j < length; j++)
                    {
                        ptr[0] = 255;
                        ptr[1] = ptr[2] = 0;
                        ptr -= data.Stride;
                    }

                }

            }
            bmp.UnlockBits(data);
            return bmp;
        }
    }
}    

