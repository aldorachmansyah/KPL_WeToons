using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;

namespace WeeToons
{
    class DefaultPanel : FlowLayoutPanel, IPanel
    {
        private List<IComicObject> comicObjects;

        public List<IComicObject> ComicObjects
        {
            get
            {
                return this.comicObjects;
            }

            set
            {
                this.comicObjects = value;
            }
        }

        public DefaultPanel(WeeToonsForm weeToonsForm, int xPosition, int yPosition, int width, int height, string panelName = "Unknown Panel")
        {
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(xPosition, yPosition);
            this.Name = panelName;
            this.Size = new System.Drawing.Size(height, width);
            this.TabIndex = 2;
            this.Click += new System.EventHandler(weeToonsForm.panel_Click);
            weeToonsForm.AddPanels(this);
        }

        public void ChangeBorder(BorderStyle borderStyle)
        {
            this.BorderStyle = borderStyle;
        }
    }
}
