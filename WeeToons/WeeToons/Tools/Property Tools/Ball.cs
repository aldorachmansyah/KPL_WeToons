using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.KomikObjects;

namespace WeeToons.Tools.Property_Tools
{
    class Ball : ToolStripMenuItem, ITool
    {
        private IPanelContainer panelContainer;

        public IPanelContainer PanelContainer
        {
            get
            {
                return this.panelContainer;
            }

            set
            {
                this.panelContainer = value;
            }
        }

        public Ball()
        {
            this.Text = "Ball";
            this.Name = "ballToolStrip";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Property\football.png");
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (panel != null)
            {
                BallProperty ball = new BallProperty();
                panel.AddComicObject((KomikObject)ball);
            }
        }
    }
   
}
