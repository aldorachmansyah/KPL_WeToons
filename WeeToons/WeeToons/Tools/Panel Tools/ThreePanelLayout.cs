using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.Tools.Selection_Tools;

namespace WeeToons.Tools.Panel_Tools
{
    class ThreePanelLayout : ToolStripMenuItem, ITool
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

        public ThreePanelLayout()
        {
            this.Text = "3 Panel";
            this.Name = "threePanelToolStrip";
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            this.panelContainer.RemoveAllPanel();
            this.AddPanel(10, 20, 200, 200, "Top Left Triple Panel");
            this.AddPanel(10, 225, 200, 200, "Bottom Left Triple Panel");
            this.AddPanel(215, 20, 405, 405, "Right Triple Panel");
            this.panelContainer.Text = "3 Panel";
        }

        private void AddPanel(int xPosition, int yPosition, int width, int height, string panelName = "Unknown Panel")
        {
            IPanel newPanel = new DefaultPanel(xPosition, yPosition, width, height, panelName);
            newPanel.SelectionTool = new SelectionTool();
            newPanel.SelectionTool.PanelContainer = this.panelContainer;
            this.panelContainer.AddPanel(newPanel);
            this.panelContainer.SetActivePanel(newPanel);
        }
    }
}
