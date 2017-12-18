using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.KomikObjects;

namespace WeeToons.Tools.Character_Tools
{
    class SwimmerCharacter : ToolStripMenuItem, ITool
    {
        private IPanelContainer panelContainer;
        private KomikObject swimmer;

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

        public SwimmerCharacter()
        {
            this.Text = "Swimmer";
            this.Name = "swimmerCharacterToolStrip";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Character\swimmer.png");
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (panel != null)
            {
                SwimmerProperty swimmer = new SwimmerProperty();
                panel.AddComicObject((KomikObject)swimmer);
            }
        }
    }
}
