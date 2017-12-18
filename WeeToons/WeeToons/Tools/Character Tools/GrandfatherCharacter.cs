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
    class GrandfatherCharacter : ToolStripMenuItem, ITool
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

        public GrandfatherCharacter()
        {
            this.Text = "Grandfather";
            this.Name = "grandfatherCharacterToolStrip";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Character\grandfather.png");
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (panel != null)
            {
                GrandfatherProperty grandfather = new GrandfatherProperty();
                panel.AddComicObject((KomikObject)grandfather);
            }
        }
    }
}
