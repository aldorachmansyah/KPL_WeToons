using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.KomikObjects;

namespace WeeToons.Tools.Bubble_Tools
{
    class RightBoxBubble : ToolStripMenuItem, ITool
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

        public RightBoxBubble()
        {
            this.Text = "RightBox";
            this.Name = "rightboxBubbleToolStrip";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Bubble\bubble3.png");
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (panel != null)
            {
                RightBoxProperty rightbox = new RightBoxProperty();
                panel.AddComicObject((KomikObject)rightbox);
            }
        }
    }
}
