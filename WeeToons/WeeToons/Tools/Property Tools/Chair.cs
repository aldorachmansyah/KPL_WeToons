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
    class Chair : ToolStripMenuItem, ITool
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

        public Chair()
        {
            this.Text = "Chair";
            this.Name = "deskToolStrip";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Property\chair.png");
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (panel != null)
            {
                ChairProperty chair = new ChairProperty();
                panel.AddComicObject((KomikObject)chair);
            }
        }
    }
}
