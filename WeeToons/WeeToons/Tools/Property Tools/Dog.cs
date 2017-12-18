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
    class Dog : ToolStripMenuItem, ITool
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

        public Dog()
        {
            this.Text = "Dog";
            this.Name = "dogToolStrip";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Property\dog.png");
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (panel != null)
            {
                DogProperty dog = new DogProperty();
                panel.AddComicObject((KomikObject)dog);
            }
        }
    }
}
