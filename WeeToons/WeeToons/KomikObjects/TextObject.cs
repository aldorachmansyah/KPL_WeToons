﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons.KomikObjects
{
    public class TextObject : KomikObject
    {
        private SizeF textSize;
        public int X { get; set; }
        public int Y{ get; set; }
        public string Value { get; set; }

       /* public TextProperty()
        {

        }*/

        public TextObject()
        {
            this.brush = new SolidBrush(Color.Black);
            this.X = 100;
            this.Y = 100;
            FontFamily fontFamily = new FontFamily("Times New Roman");
            font = new Font(fontFamily, 20, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        public override bool Intersect(int xTest, int yTest)
        {

            if ((xTest >= X && xTest <= X + textSize.Width) && (yTest >= Y && yTest <= Y + textSize.Height))
            {
                //Debug.WriteLine("Object " + ID + " is selected.");
                return true;
            }
            return false;
        }
        public override void Translate(int x, int y, int xAmount, int yAmount)
        {
            this.X += xAmount;
            this.Y += yAmount;
        }
        public override void RenderOnEditingView()
        {
            GetGraphics().DrawString(Value, font, brush, new PointF(X, Y));
            textSize = GetGraphics().MeasureString(Value, font);
            GetGraphics().DrawRectangle(new Pen(Brushes.Red, 2), new Rectangle(this.X, this.Y, (int)this.textSize.Width,(int) this.textSize.Height));


        }
        public override void RenderOnStaticView()
        {
            GetGraphics().DrawString(Value, font, brush, new PointF(X, Y));
            textSize = GetGraphics().MeasureString(Value, font);
        }
    }
}
