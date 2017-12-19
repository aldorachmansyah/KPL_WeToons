using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons.KomikObjects
{
    public abstract class TextObject : KomikObject
    {
        private Graphics graphics;
        private SizeF textSize;

        public string Value { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string PropertyPath { get; set; }

        public TextObject()
        {
            this.ChangeState(StaticState.GetInstance());
        }

        private State state;

        public override void Select()
        {
            this.state.Select(this);
        }

        public override void Deselect()
        {
            this.state.Deselect(this);
        }

        public override bool Intersect(int xTest, int yTest)
        {
            if ((xTest >= X && xTest <= X + Width) && (yTest >= Y && yTest <= Y + Height))
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

        }
        public override void RenderOnStaticView()
        {
            GetGraphics().DrawString(Value, font, brush, new PointF(X, Y));
            textSize = GetGraphics().MeasureString(Value, font);
        }

        public override void Draw()
        {
            this.state.Draw(this);
        }
        public override void SetGraphics(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public override Graphics GetGraphics()
        {
            return this.graphics;
        }

        public void ChangeState(State state)
        {
            this.state = state;
        }
    }
}
