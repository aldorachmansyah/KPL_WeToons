using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WeeToons
{
    public class DefaultEditor : PictureBox, IEditor
    {
        private List<ICanvas> canvases;
        private ICanvas selectedCanvas;

        private IToolbox toolbox;

        public IToolbox Toolbox
        {
             get
             {
                 return this.toolbox;
             }

             set
             {
                 this.toolbox = value;
             }
        }

        public DefaultEditor()
        {
            Dock = DockStyle.Fill;
            canvases = new List<ICanvas>();
            
        }

        public void AddCanvas(ICanvas canvas)
        {
            canvases.Add(canvas);
            this.Controls.Add((Control)canvas);
            SelectCanvas(canvas);
            foreach (Control c in this.Controls)
            {
                c.MouseClick += new MouseEventHandler(CanvasClick);
            }
        }

        public ICanvas GetSelectedCanvas()
        {
            return this.selectedCanvas;
        }

        public void RemoveCanvas(ICanvas canvas)
        {
            throw new NotImplementedException();
        }

        public void RemoveSelectedCanvas()
        {
            this.Controls.Clear();
            
        }

        private void CanvasClick(object sender, EventArgs e)
        {
            ICanvas panel = sender as ICanvas;
            if (panel != null)
            {
                SelectCanvas(panel);
            }
          
        }

        public void SelectCanvas(ICanvas canvas)
        {
            if (this.selectedCanvas != null)
            {
                this.selectedCanvas.Deactivate();
            }
            canvas.Activate();
            this.selectedCanvas = canvas;
        }

        

    }
}
