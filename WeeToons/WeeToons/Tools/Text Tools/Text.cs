using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.KomikObjects;

namespace WeeToons.Tools.Text_Tools
{
    class Text : ToolStripMenuItem, ITool
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

        public Text()
        {
            this.Text = "Text";
            this.Name = "textToolStrip";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Icon\text.png");
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            IPanel panel = this.panelContainer.ActivePanel;
            if (panel != null)
            {
                string input;
                TextObject text = new TextObject();
                input = Microsoft.VisualBasic.Interaction.InputBox("Input Text", "Text Box", "", 500, 300);
                text.Value = input;
                Debug.WriteLine("masuk");
                panel.AddComicObject((KomikObject)text);
            }
        }


    }

}
