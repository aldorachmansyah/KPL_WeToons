using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons
{
    abstract class KomikObject
    {
        public abstract bool Add(KomikObject obj);
        public abstract bool Remove(KomikObject obj);

        public abstract bool Intersect(int xTest, int yTest);
        public abstract void Translate(int x, int y, int xAmount, int yAmount);
    }
}
