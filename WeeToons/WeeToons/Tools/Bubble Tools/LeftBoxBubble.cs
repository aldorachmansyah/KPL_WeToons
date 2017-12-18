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
    class LeftBoxBubble : ToolStripMenuItem, ITool
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

        public LeftBoxBubble()
        {
            this.Text = "LeftBox";
            this.Name = "leftboxBubbleToolStrip";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Bubble\bubble2.png");
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (panel != null)
            {
                LeftBoxProperty leftbox = new LeftBoxProperty();
                panel.AddComicObject((KomikObject)leftbox);
            }
        }
    }
}
