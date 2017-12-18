using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons.Tools.Bubble_Tools
{
    class BubbleTool : ToolDropDownObject
    {
        public BubbleTool()
        {
            this.Name = "bubbleToolStrip";
            this.Text = "Bubble";

            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Icon\bubble.png");
        }
    }
}
