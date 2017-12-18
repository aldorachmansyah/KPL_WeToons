using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace WeeToons
{
    class Text : KomikObject
    {
        public string Value { get; set; }
        public int X { get; set; }
        public int y { get; set; }

        private Font font;
        private SizeF textSize;
        private Brush brush;

        public Text()
        {
            this.brush = new SolidBrush(Color.Black);

            FontFamily fontFamily = new FontFamily("Arial");
            font = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);
        }
    }
}
