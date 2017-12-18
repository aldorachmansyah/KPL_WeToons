using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons.Tools.Property_Tools
{
    class PropertyTool : ToolDropDownObject
    {
        public PropertyTool()
        {
            this.Name = "propertyToolStrip";
            this.Text = "Property";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Icon\property.png");
        }
    }
}
