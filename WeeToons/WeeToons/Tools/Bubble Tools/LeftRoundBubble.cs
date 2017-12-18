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
    class LeftRoundBubble : ToolStripMenuItem, ITool
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

        public LeftRoundBubble()
        {
            this.Text = "LeftRound";
            this.Name = "leftroundBubbleToolStrip";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Bubble\bubble1.png");
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (panel != null)
            {
                LeftRoundProperty leftround = new LeftRoundProperty();
                panel.AddComicObject((KomikObject)leftround);
            }
        }
    }
}
