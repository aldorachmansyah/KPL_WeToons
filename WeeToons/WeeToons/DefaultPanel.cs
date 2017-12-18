using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.Tools.Selection_Tools;

namespace WeeToons
{
    class DefaultPanel : FlowLayoutPanel, IPanel
    {
        private List<KomikObject> comicObjects;
        private SelectionTool selectionTool;

        public List<KomikObject> ComicObjects
        {
            get
            {
                return this.comicObjects;
            }

            set
            {
                this.comicObjects = value;
            }
        }

        public SelectionTool SelectionTool
        {
            get
            {
                return this.selectionTool;
            }

            set
            {
                this.selectionTool = value;
            }
        }

        public DefaultPanel(int xPosition, int yPosition, int width, int height, string panelName = "Unknown Panel")
        {
            this.comicObjects = new List<KomikObject>();
            this.selectionTool = new SelectionTool();

            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(xPosition, yPosition);
            this.Name = panelName;
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

        public void ChangeBorder(BorderStyle borderStyle)
        {
            this.BorderStyle = borderStyle;
        }

        public void SetBackground(Image backgroundImage)
        {
            this.BackgroundImage = backgroundImage;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void AddComicObject(KomikObject drawingObject)
        {
            this.comicObjects.Add(drawingObject);
            this.Repaint();
        }

        public void Repaint()
        {
            this.Invalidate();
            this.Update();
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
            if (e.Button == MouseButtons.Left)
            {
                if (this.selectionTool != null)
                {
                    this.selectionTool.ToolMouseMove(sender, e);
                    this.Repaint();
                }
            }
        
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.selectionTool != null)
            {
                this.selectionTool.ToolMouseDown(sender, e);
                this.Repaint();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.selectionTool != null)
            {
                this.selectionTool.ToolMouseUp(sender, e);
                this.Repaint();
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (KomikObject obj in comicObjects)
            {
                obj.SetGraphics(e.Graphics);
                obj.Draw();
            }
        }

        public KomikObject GetObjectAt(int x, int y)
        {
            foreach (KomikObject obj in comicObjects)
            {
                if (obj.Intersect(x, y))
                {
                    return obj;
                }
            }
            return null;
        }

        public KomikObject SelectObjectAt(int x, int y)
        {
            KomikObject obj = GetObjectAt(x, y);
            /*if (obj != null)
            {
                obj.Select();
            }*/

            return obj;
        }
    }
}
