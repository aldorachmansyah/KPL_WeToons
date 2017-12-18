using System;
using System.Diagnostics;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.Tools.Selection_Tools;

namespace WeeToons
{
    class OnePanelLayout : ToolStripMenuItem, ITool
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

        public OnePanelLayout()
        {
            this.Text = "1 Panel";
            this.Name = "onePanelToolStrip";
            this.Click += new EventHandler(this.tool_Click);
        }

        public void tool_Click(object sender, EventArgs e)
        {
            this.panelContainer.RemoveAllPanel();
            IPanel newPanel = new DefaultPanel(10, 20, 630, 630, "Full Single Panel");
            newPanel.SelectionTool = new SelectionTool();
            newPanel.SelectionTool.PanelContainer = this.panelContainer;
            this.panelContainer.AddPanel(newPanel);
            this.panelContainer.SetActivePanel(newPanel);
        }
    }
}