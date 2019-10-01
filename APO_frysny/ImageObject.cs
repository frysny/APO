using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO_frysny
{  
    public class ImageObject
    {
        Image _image { get; set; }
        public ImageObject(Image obraz)
        {
            _image = obraz;
        }

    }
}
