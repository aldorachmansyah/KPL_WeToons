using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.Tools;

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
