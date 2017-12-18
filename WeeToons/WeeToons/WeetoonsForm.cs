using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;

namespace WeeToons
{
    public partial class WeeToonsForm : Form
    {
        private List<IPanel> panels;
        private IPanel panelActive;

        public WeeToonsForm()
        {
            panels = new List<IPanel>();
            InitializeComponent();
        }

        public void AddPanels(IPanel panel)
        {
            this.Controls.Add((FlowLayoutPanel)panel);
            this.panels.Add(panel);
        }

        private void onePanelToolStrip_Click(object sender, EventArgs e)
        {
            removeAllPanel();
            IPanel newPanel = new DefaultPanel(this, 49, 37, 660, 660, "Full Single Panel");
            activatePanel(newPanel);
        }

        private void twoPanelToolStrip_Click(object sender, EventArgs e)
        {
            removeAllPanel();
            IPanel leftPanel = new DefaultPanel(this, 49, 37, 320, 320, "left double panel");
            IPanel rightPanel = new DefaultPanel(this, 375, 37, 320, 320, "right double panel");
            activatePanel(leftPanel);
        }

        private void threePanelToolStrip_Click(object sender, EventArgs e)
        {
            removeAllPanel();
            IPanel leftPanelTop = new DefaultPanel(this, 49, 37, 200, 200, "Top Left Triple Panel");
            IPanel leftPanelBottom = new DefaultPanel(this, 49, 257, 200, 200, "Bottom Left Triple Panel");
            IPanel rightPanel = new DefaultPanel(this, 265, 37, 420, 420, "Right Triple Panel");
            activatePanel(leftPanelTop);
        }

        private void fourPanelToolStrip_Click(object sender, EventArgs e)
        {
            removeAllPanel();
            IPanel leftTopPanel = new DefaultPanel(this, 49, 37, 320, 320, "Top Left Quartet Panel");
            IPanel rightTopPanel = new DefaultPanel(this, 375, 37, 320, 320, "Top Right Quartet Panel");
            IPanel leftBottomPanel = new DefaultPanel(this, 47, 370, 320, 320, "Bottom Left Quartet Panel");
            IPanel rightBottomPanel = new DefaultPanel(this, 375, 370, 320, 320, "Bottom Right Quartet Panel");
            activatePanel(leftTopPanel);
        }

        private void activatePanel(IPanel panel)
        {
            if(this.panelActive != null)
            {
                this.panelActive.ChangeBorder(BorderStyle.FixedSingle);
            }
            panel.ChangeBorder(BorderStyle.Fixed3D);
            this.panelActive = panel;
        }

        private void removeAllPanel()
        {
            if(this.panelGroup != null)
            {
                foreach (FlowLayoutPanel panel in this.panelGroup)
                {
                    this.Controls.Remove(panel);
                }
            }
        }

        public void panel_Click(object sender, EventArgs e)
        {
            IPanel panel = sender as IPanel;
            activatePanel(panel);
        }

        private void parkBackgroundToolStrip_Click(object sender, EventArgs e)
        {
            if (this.activePanel != null)
            {
                Image backgroundImage = new Bitmap(@"..\..\..\Resources\Background\park.jpg");
                this.activePanel.BackgroundImage = backgroundImage;
                this.activePanel.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void beachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.activePanel != null)
            {
                Image backgroundImage = new Bitmap(@"..\..\..\Resources\Background\beach.jpg");
                this.activePanel.BackgroundImage = backgroundImage;
                this.activePanel.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void classroomBackgroundToolStrip_Click(object sender, EventArgs e)
        {
            if (this.activePanel != null)
            {
                Image backgroundImage = new Bitmap(@"..\..\..\Resources\Background\classroom.jpg");
                this.activePanel.BackgroundImage = backgroundImage;
                this.activePanel.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void bedroomBackgroundToolStrip_Click(object sender, EventArgs e)
        {
            if (this.activePanel != null)
            {
                Image backgroundImage = new Bitmap(@"..\..\..\Resources\Background\bedroom.jpg");
                this.activePanel.BackgroundImage = backgroundImage;
                this.activePanel.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void kitchenBackgroundToolStrip_Click(object sender, EventArgs e)
        {
            if (this.activePanel != null)
            {
                Image backgroundImage = new Bitmap(@"..\..\..\Resources\Background\kitchen.jpg");
                this.activePanel.BackgroundImage = backgroundImage;
                this.activePanel.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
