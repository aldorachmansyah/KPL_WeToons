using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons
{
    class Benda : KomikObject
    {
        public int x { get; set; }
        public int y { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public Benda ()
        {
            this.width = 200;
            this.height = 200;
            this.x = 0;
            this.y = 0;
        }
        public override bool Add(KomikObject obj)
        {
            //throw new NotImplementedException();
            return true;
        }

        public override bool Intersect(int xTest, int yTest)
        {

            if ((xTest >= x && xTest <= x + width) && (yTest >= y && yTest <= y + height))
            {
                Debug.Write("selected");
                //Debug.WriteLine("Object " + ID + " is selected.");
                return true;
            }
            return false;
        }

        public override bool Remove(KomikObject obj)
        {
            throw new NotImplementedException();
        }

        public override void RenderOnEditingView()
        {
            throw new NotImplementedException();
        }

        public override void RenderOnPreview()
        {
            Image imageBox = Bitmap.FromFile(this.url);
            GetGraphics().DrawImage(imageBox, this.x, this.y, this.width, this.height);
        }

        public override void RenderOnStaticView()
        {
            throw new NotImplementedException();
        }

        public override void Translate(int x, int y, int xAmount, int yAmount)
        {
            this.x += xAmount;
            this.y += yAmount;
            Debug.Write(this.x);
            Debug.Write(this.y);
 
        }
    }
}
