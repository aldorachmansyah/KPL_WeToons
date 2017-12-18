using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WeeToons.KomikObjects
{
    class TextProperty : KomikObject
    {
        public TextProperty()
        {
            this.brush = new SolidBrush(Color.Black);

            FontFamily fontFamily = new FontFamily("Arial");
            font = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);
        }
    }
}
