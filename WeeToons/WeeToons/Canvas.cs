using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeToons
{
    class Canvas : FlowLayoutPanel, ICanvas
    {

        //  private ITool activeTool;
        // private List<KomikObject> drawingObjects;

        public Canvas(int xPosition, int yPosition, int width, int height)
        {
            Init(xPosition, yPosition, width, height);
        }

        private void Init(int xPosition, int yPosition, int width, int height)
        {
            // this.drawingObjects = new List<KomikObject>();
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(xPosition, yPosition);
            this.Size = new System.Drawing.Size(height, width);
            this.TabIndex = 2;

            this.Paint += Canvas_Paint;
            this.MouseDown += Canvas_MouseDown;
            this.MouseUp += Canvas_MouseUp;
            this.MouseMove += Canvas_MouseMove;
            this.MouseDoubleClick += Canvas_MouseDoubleClick;
            this.KeyDown += Canvas_KeyDown;
            this.KeyUp += Canvas_KeyUp;
            this.PreviewKeyDown += Canvas_PreviewKeyDown;
        }

        private void Canvas_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void Canvas_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void Canvas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {

        }


        public void Repaint()
        {
            this.Invalidate();
            this.Update();
        }

        public void Activate()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        public void Deactivate()
        {
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        public void SetBackground(Image image)
        {
            this.BackgroundImage = image;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public ITool GetActiveTool()
        {
            return this.GetActiveTool();
            // throw new NotImplementedException();
        }

        public void SetActiveTool(ITool tool)
        {
            //throw new NotImplementedException();
        }

        public void SetBackgroundColor(Color color)
        {
            //throw new NotImplementedException();
        }

        public void DeselectAllObjects()
        {
            //throw new NotImplementedException();
        }

        /* public void AddDrawingObject(KomikObject drawingObject)
         {
             throw new NotImplementedException();
         }
         public void DeselectAllObjects()
         {
             throw new NotImplementedException();
         }
         public ITool GetActiveTool()
         {
             throw new NotImplementedException();
         }
         public KomikObject GetObjectAt(int x, int y)
         {
             throw new NotImplementedException();
         }
         public void RemoveDrawingObject(KomikObject drawingObject)
         {
             throw new NotImplementedException();
         }
         public KomikObject SelectObjectAt(int x, int y)
         {
             throw new NotImplementedException();
         }
         public void SetActiveTool(ITool tool)
         {
             throw new NotImplementedException();
         }
         public void SetBackgroundColor(Color color)
         {
             throw new NotImplementedException();
         }*/
    }
}