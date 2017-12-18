using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons.Tools.Text_Tools
{
    class TextTools : ToolDropDownObject
    {
        public TextTools()
        {
            this.Name = "textToolStrip";
            this.Text = "Text";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Icon\text.png");
        }
    }
}
