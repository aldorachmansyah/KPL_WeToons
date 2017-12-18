using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace WeeToons
{
    public abstract class KomikObject
    {
        public abstract bool Add(KomikObject obj);
        public abstract bool Remove(KomikObject obj);

        public abstract bool Intersect(int xTest, int yTest);
        public abstract void Translate(int x, int y, int xAmount, int yAmount);

        public abstract void RenderOnPreview();
        public abstract void RenderOnEditingView();
        public abstract void RenderOnStaticView();
        public abstract string GetText();
        public abstract void SetText(string value);

        public Guid ID { get; set; }

        public State State
        {
            get
            {
                return this.state;
            }
        }

        private Graphics graphics;

        public KomikObject()
        {
            ID = Guid.NewGuid();
            this.ChangeState(PreviewState.GetInstance());
        }

        private State state;

        public void ChangeState(State state)
        {
            this.state = state;
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

        public void Select()
        {
            Debug.WriteLine("Object id= " + ID.ToString() + "is selected.");
            this.state.Select(this);
        }

        public void Deselect()
        {
            Debug.WriteLine("Object id= " + ID.ToString() + "is deselected");
            this.state.Deselect(this);
        }
    }
}
