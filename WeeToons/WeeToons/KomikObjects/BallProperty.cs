using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons.KomikObjects
{
    class BallProperty : KomikObject
    {
        public BallProperty()
        {
            this.Width = 150;
            this.Height = 150;
            this.X = 120;
            this.Y = 50;
            this.PropertyPath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\..\"), "Resources\\Property\\football.png");
        }
    }
}
