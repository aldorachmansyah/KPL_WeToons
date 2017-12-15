using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WeeToons
{
    public class DefaultEditor : PictureBox, IEditor
    {
        private List<ICanvas> canvases;
        private ICanvas selectedCanvas;
       // private IToolbox toolbox;

       /* public IToolbox Toolbox
        {
            get
            {
                return this.toolbox;
            }

            set
            {
                this.toolbox = value;
            }
        }*/

        public DefaultEditor()
        {
            Dock = DockStyle.Fill;
            canvases = new List<ICanvas>();

        }

        public void AddCanvas(ICanvas canvas)
        {
            canvases.Add(canvas);
            this.Controls.Add((Control)canvas);
            this.selectedCanvas = canvas;
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
            //TabPage selectedTab = this.SelectedTab;
            
        }

        public void SelectCanvas(ICanvas canvas)
        {
            this.selectedCanvas = canvas;
        }
    }
}
