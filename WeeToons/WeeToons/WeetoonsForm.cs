using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.Tools;
using WeeToons.Tools.Background_Tools;
using WeeToons.Tools.Character_Tools;
using WeeToons.Tools.Panel_Tools;

namespace WeeToons
{
    public partial class WeeToonsForm : Form
    {
        private IPanelContainer panelGroupContainer;

        public WeeToonsForm()
        {
            InitializeComponent();
            InitUI();
        }

        public void InitUI()
        {
            #region CONTAINER
            this.panelGroupContainer = new DefaultPanelContainer();
            this.Controls.Add((GroupBox)panelGroupContainer);
            #endregion

            #region TOOL DROPDOWN
            IToolGroup panelTool = new PanelTool();
            IToolGroup backgroundTool = new BackgroundTool();
            IToolGroup characterTool = new CharacterTool();

            this.topToolStrip.Items.Add((ToolStripDropDownButton)panelTool);
            this.topToolStrip.Items.Add((ToolStripDropDownButton)backgroundTool);
            this.leftToolStrip.Items.Add((ToolStripDropDownButton)characterTool);
            #endregion

            #region TOOLS
            ITool onePanelLayout = new OnePanelLayout();
            ITool twoPanelLayout = new TwoPanelLayout();
            ITool parkBackground = new ParkBackground();
            ITool studentCharacter = new StudentCharacter();

            onePanelLayout.PanelContainer = this.panelGroupContainer;
            twoPanelLayout.PanelContainer = this.panelGroupContainer;
            parkBackground.PanelContainer = this.panelGroupContainer;
            studentCharacter.PanelContainer = this.panelGroupContainer;

            panelTool.AddTool(onePanelLayout);
            panelTool.AddTool(twoPanelLayout);
            backgroundTool.AddTool(parkBackground);
            characterTool.AddTool(studentCharacter);
            #endregion
        }

        //private void onePanelToolStrip_Click(object sender, EventArgs e)
        //{
        //    removeAllPanel();
        //    IPanel newPanel = new DefaultPanel(this, 49, 37, 660, 660, "Full Single Panel");
        //    activatePanel(newPanel);
        //}

        //private void twoPanelToolStrip_Click(object sender, EventArgs e)
        //{
        //    removeAllPanel();
        //    IPanel leftPanel = new DefaultPanel(this, 49, 37, 320, 320, "left double panel");
        //    IPanel rightPanel = new DefaultPanel(this, 375, 37, 320, 320, "right double panel");
        //    activatePanel(leftPanel);
        //}

        //private void threePanelToolStrip_Click(object sender, EventArgs e)
        //{
        //    removeAllPanel();
        //    IPanel leftPanelTop = new DefaultPanel(this, 49, 37, 200, 200, "Top Left Triple Panel");
        //    IPanel leftPanelBottom = new DefaultPanel(this, 49, 257, 200, 200, "Bottom Left Triple Panel");
        //    IPanel rightPanel = new DefaultPanel(this, 265, 37, 420, 420, "Right Triple Panel");
        //    activatePanel(leftPanelTop);
        //}

        //private void fourPanelToolStrip_Click(object sender, EventArgs e)
        //{
        //    removeAllPanel();
        //    IPanel leftTopPanel = new DefaultPanel(this, 49, 37, 320, 320, "Top Left Quartet Panel");
        //    IPanel rightTopPanel = new DefaultPanel(this, 375, 37, 320, 320, "Top Right Quartet Panel");
        //    IPanel leftBottomPanel = new DefaultPanel(this, 47, 370, 320, 320, "Bottom Left Quartet Panel");
        //    IPanel rightBottomPanel = new DefaultPanel(this, 375, 370, 320, 320, "Bottom Right Quartet Panel");
        //    activatePanel(leftTopPanel);
        //}
    }
}
