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
    class BasketCharacter : ToolStripMenuItem, ITool
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

        public BasketCharacter()
        {
            this.Text = "BasketBall-Player";
            this.Name = "basketCharacterToolStrip";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Character\basketball-player.png");
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (panel != null)
            {
                BasketProperty basket = new BasketProperty();
                panel.AddComicObject((KomikObject)basket);
            }
        }
    }
}
