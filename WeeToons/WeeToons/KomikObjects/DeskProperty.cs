using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons.KomikObjects
{
    class DeskProperty : KomikObject
    {
        public DeskProperty()
        {
            this.Width = 200;
            this.Height = 200;
            this.X = 120;
            this.Y = 50;
            this.PropertyPath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\..\"), "Resources\\Property\\desk.png");
        }
    }
}
