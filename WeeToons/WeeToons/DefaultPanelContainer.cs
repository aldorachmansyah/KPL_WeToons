using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;

namespace WeeToons
{
    class DefaultPanelContainer : GroupBox, IPanelContainer
    {
        private IPanel activePanel;
        private List<IPanel> panels;
        
        public IPanel ActivePanel
        {
            get
            {
                return this.activePanel;
            }

            set
            {
                this.activePanel = value;
            }
        }

        public DefaultPanelContainer()
        {
            this.panels = new List<IPanel>();

            this.Location = new System.Drawing.Point(49, 37);
            this.Name = "WeeToons";
            this.Size = new System.Drawing.Size(660, 660);
            this.TabIndex = 2;
            this.TabStop = false;
            this.Text = "Default Panel";
        }

        public void AddPanel(IPanel panel)
        {
            Panel newPanel = (Panel)panel;

            this.Controls.Add(newPanel);
            this.panels.Add(panel);
            Debug.WriteLine("masuk");
        }

        public void SetActivePanel(IPanel panel)
        {
            if (this.activePanel != null)
            {
                this.activePanel.ChangeBorder(BorderStyle.FixedSingle);
            }
            panel.ChangeBorder(BorderStyle.Fixed3D);
            this.activePanel = panel;
        }

        public void RemoveAllPanel()
        {
            Debug.WriteLine("Removing all panels");

            if (this.panels != null)
            {
                foreach (Panel panel in this.panels)
                {
                    this.Controls.Remove(panel);
                }
            }
        }

        public void panel_Click(object sender, EventArgs e)
        {
            IPanel panel = sender as IPanel;
            SetActivePanel(panel);
        }
    }
}
