using System;
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
<<<<<<< HEAD
            this.Width = 200;
            this.Height = 200;
=======
            this.Width = 256;
            this.Height = 256;
>>>>>>> 6e9ee3ab3e02042165384078316751f07bb72b8e
            this.X = 120;
            this.Y = 50;
            this.PropertyPath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\..\"), "Resources\\Character\\student.png");
        }
    }
}
