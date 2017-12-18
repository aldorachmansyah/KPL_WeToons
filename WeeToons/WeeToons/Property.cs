using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons
{
    class Property : KomikObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string aldo;

        public override bool Add(KomikObject obj)
        {
            return false;
        }

        public override bool Intersect(int xTest, int yTest)
        {
            /*if ((xTest >= X && xTest <= X + textSize.Width) && (yTest >= Y && yTest <= Y + textSize.Height))
            {
                Debug.WriteLine("Object " + ID + " is selected.");
                return true;
            }*/
            return false;
        }

        public override bool Remove(KomikObject obj)
        {
            return false;
        }

        public override void RenderOnEditingView()
        {
            //GetGraphics().DrawString(Value, font, brush, new PointF(X, Y));
            //textSize = GetGraphics().MeasureString(Value, font);
        }

        public override void RenderOnPreview()
        {
            //GetGraphics().DrawString(Value, font, brush, new PointF(X, Y));
            //textSize = GetGraphics().MeasureString(Value, font);
        }

        public override void RenderOnStaticView()
        {
           // GetGraphics().DrawString(Value, font, brush, new PointF(X, Y));
            //textSize = GetGraphics().MeasureString(Value, font);
        }

        public override void Translate(int x, int y, int xAmount, int yAmount)
        {
            X += xAmount;
            Y += yAmount;
        }

        public override string GetText()
        {
           return aldo;
        }

        public override void SetText(string value)
        {
            //this.Value = value;
        }
    }

}
