using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.Tools.Selection_Tools;

namespace WeeToons.Tools.Panel_Tools
{
    class TwoPanelLayout : ToolStripMenuItem, ITool
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

        public TwoPanelLayout()
        {
            this.Text = "2 Panel";
            this.Name = "twoPanelToolStrip";
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            this.panelContainer.RemoveAllPanel();
            this.AddPanel(10, 20, 310, 310, "Left double panel");
            this.AddPanel(325, 20, 310, 310, "Right double panel");
            this.panelContainer.Text = "2 Panel";
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
