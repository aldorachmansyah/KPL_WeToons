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
    class ChefCharacter : ToolStripMenuItem, ITool
    {
        private IPanelContainer panelContainer;
        private KomikObject chef;

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

        public ChefCharacter()
        {
            this.Text = "Chef";
            this.Name = "chefCharacterToolStrip";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Character\chef.png");
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (panel != null)
            {
                ChefProperty chef = new ChefProperty();
                panel.AddComicObject((KomikObject)chef);
            }
        }
    }
}
