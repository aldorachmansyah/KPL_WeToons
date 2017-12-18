using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons
{
    public abstract class KomikObject
    {
        public abstract bool Add(KomikObject obj);
        public abstract bool Remove(KomikObject obj);
        private Graphics graphics;

        public abstract bool Intersect(int xTest, int yTest);
        public abstract void Translate(int x, int y, int xAmount, int yAmount);
        public abstract void RenderOnPreview();
        public abstract void RenderOnEditingView();
        public abstract void RenderOnStaticView();


        public virtual void Draw()
        {
            this.RenderOnPreview();
        }
        public virtual void SetGraphics(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public virtual Graphics GetGraphics()
        {
            return this.graphics;
        }

    }
}
