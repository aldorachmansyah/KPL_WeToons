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
    class FourPanelLayout : ToolStripMenuItem, ITool
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

        public FourPanelLayout()
        {
            this.Text = "4 Panel";
            this.Name = "fourPanelToolStrip";
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            this.panelContainer.RemoveAllPanel();
            this.AddPanel(10, 20, 310, 310, "Top Left Quartet Panel");
            this.AddPanel(325, 20, 310, 310, "Top Right Quartet Panel");
            this.AddPanel(10, 335, 310, 310, "Bottom Left Quartet Panel");
            this.AddPanel(325, 335, 310, 310, "Bottom Right Quartet Panel");
            this.panelContainer.Text = "4 Panel";
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
