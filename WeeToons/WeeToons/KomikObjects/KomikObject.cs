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
        private Graphics graphics;

        public int X { get; set; }
        public int Y { get; set; }
        public string PropertyPath { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }


        public KomikObject()
        {
            this.ChangeState(StaticState.GetInstance());
        }

        public State WeState
        {
            get
            {
                return this.state;
            }
        }

        private State state;

        public void Select()
        {
            this.state.Select(this);
        }

        public void Deselect()
        {
            this.state.Deselect(this);
        }

        public virtual bool Intersect(int xTest, int yTest)
        {
            if ((xTest >= X && xTest <= X + Width) && (yTest >= Y && yTest <= Y + Height))
            {
                //Debug.WriteLine("Object " + ID + " is selected.");
                return true;
            }
            return false;
        }
        public virtual void Translate(int x, int y, int xAmount, int yAmount)
        {
            this.X += xAmount;
            this.Y += yAmount;
        }

        public virtual void Expand()
        {
            this.Height += 10;
            this.Width += 10;
        }

        public virtual void Shrink()
        {
            this.Height -= 10;
            this.Width -= 10;
        }



        public virtual void RenderOnEditingView()
        {
            Image imageBox = Bitmap.FromFile(this.PropertyPath);
            GetGraphics().DrawImage(imageBox, this.X, this.Y, this.Width, this.Height);
            GetGraphics().DrawRectangle(new Pen(Brushes.Red, 5), new Rectangle(this.X, this.Y, this.Width, this.Height));

        }
        public virtual void RenderOnStaticView()
        {
            Image imageBox = Bitmap.FromFile(this.PropertyPath);
            GetGraphics().DrawImage(imageBox, this.X, this.Y, this.Width, this.Height);
        }


        public virtual void Draw()
        {
            this.state.Draw(this);
        }
        public virtual void SetGraphics(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public virtual Graphics GetGraphics()
        {
            return this.graphics;
        }

        public void ChangeState(State state)
        {
            this.state = state;
        }
    }
}
