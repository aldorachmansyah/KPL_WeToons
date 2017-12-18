using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons
{
    class ObjectGroup : KomikObject
    {
       private List<KomikObject> objects;

        public override void Draw()
        {
            foreach(KomikObject obj in objects)
            {
                obj.Draw();
            }
        }

        public override void RenderOnEditingView()
        {
            foreach (KomikObject obj in objects)
            {
                obj.RenderOnEditingView();
            }
        }

        public override void Translate(int x, int y, int xAmount, int yAmount)
        {
            foreach (KomikObject obj in objects)
            {
                obj.Translate(x, y, xAmount, yAmount);
            }
        }

        public override void RenderOnStaticView()
        {
            foreach (KomikObject obj in objects)
            {
                obj.RenderOnStaticView();
            }
        }

        public override bool Intersect(int xTest, int yTest)
        {
            foreach (KomikObject obj in objects)
            {
                if(obj.Intersect(xTest,yTest))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
