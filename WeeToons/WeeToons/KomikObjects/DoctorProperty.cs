﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons.KomikObjects
{
    class DoctorProperty : KomikObject
    {
        public DoctorProperty()
        {
            this.Width = 256;
            this.Height = 256;
            this.X = 120;
            this.Y = 50;
            this.PropertyPath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\..\"), "Resources\\Character\\doctor.png");
        }
    }
}
