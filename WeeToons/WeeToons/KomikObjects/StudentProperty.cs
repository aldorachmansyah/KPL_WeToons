﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons.KomikObjects
{
    class StudentProperty : KomikObject
    {
        public StudentProperty()
        {
            this.Width = 180;
            this.Height = 260;
            this.X = 120;
            this.Y = 50;
            this.PropertyPath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\..\"), "Resources\\Icon\\cursor.png");
        }
    }
}
