using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons.Tools.Background_Tools
{
    class BackgroundTool : ToolDropDownObject
    {
        public BackgroundTool()
        {
            this.Name = "backgroundToolStrip";
            this.Text = "Background";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Background\park.jpg");
        }
    }
}
