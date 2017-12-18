﻿using System;
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
            ITool threePanelLayout = new ThreePanelLayout();
            ITool fourPanelLayout = new FourPanelLayout();
            ITool parkBackground = new ParkBackground();
            ITool studentCharacter = new StudentCharacter();

            onePanelLayout.PanelContainer = this.panelGroupContainer;
            twoPanelLayout.PanelContainer = this.panelGroupContainer;
            threePanelLayout.PanelContainer = this.panelGroupContainer;
            fourPanelLayout.PanelContainer = this.panelGroupContainer;
            parkBackground.PanelContainer = this.panelGroupContainer;
            studentCharacter.PanelContainer = this.panelGroupContainer;

            panelTool.AddTool(onePanelLayout);
            panelTool.AddTool(twoPanelLayout);
            panelTool.AddTool(threePanelLayout);
            panelTool.AddTool(fourPanelLayout);
            backgroundTool.AddTool(parkBackground);
            characterTool.AddTool(studentCharacter);
            #endregion
        }
        
    }
}
