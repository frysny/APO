using System.Windows.Forms;

namespace APO_frysny
{
    public class Histogram : MainForm
    {
        public Form _form { get; set; }
        public Histogram(Form activeform)
        {
            _form = activeform;

        }
    }    
}
