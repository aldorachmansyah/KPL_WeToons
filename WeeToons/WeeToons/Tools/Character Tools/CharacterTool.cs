using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons.Tools.Character_Tools
{
    class CharacterTool : ToolDropDownObject
    {
        public CharacterTool()
        {
            this.Name = "characterToolStrip";
            this.Text = "Character";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Background\park.jpg");
        }
    }
}
