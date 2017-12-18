using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WeeToons.KomikObjects
{
    class TextProperty : TextObject
    {
        public TextProperty()
        {
            this.brush = new SolidBrush(Color.Black);

            FontFamily fontFamily = new FontFamily("Arial");
            font = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        public override string GetText()
        {
            return Value;
        }

        public override void SetText(string value)
        {
            this.Value = value;
        }
    }
}
