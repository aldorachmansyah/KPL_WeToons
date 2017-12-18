using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.Tools;
using WeeToons.Tools.Background_Tools;
<<<<<<< HEAD
using WeeToons.Tools.Property_Tools;
=======
using WeeToons.Tools.Bubble_Tools;
>>>>>>> 6e9ee3ab3e02042165384078316751f07bb72b8e
using WeeToons.Tools.Character_Tools;
using WeeToons.Tools.Panel_Tools;

namespace WeeToons
{
    public partial class WeeToonsForm : Form
    {
        private IPanelContainer panelGroupContainer;
        private ToolStripDropDownButton bubbleTool;

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
<<<<<<< HEAD
            IToolGroup propertyTool = new PropertyTool();
=======
            IToolGroup bubbleTool = new BubbleTool();
>>>>>>> 6e9ee3ab3e02042165384078316751f07bb72b8e

            this.topToolStrip.Items.Add((ToolStripDropDownButton)panelTool);
            this.topToolStrip.Items.Add((ToolStripDropDownButton)backgroundTool);
            this.leftToolStrip.Items.Add((ToolStripDropDownButton)characterTool);
<<<<<<< HEAD
            this.leftToolStrip.Items.Add((ToolStripDropDownButton)propertyTool);
=======
            this.leftToolStrip.Items.Add((ToolStripDropDownButton)bubbleTool);
>>>>>>> 6e9ee3ab3e02042165384078316751f07bb72b8e
            #endregion

            #region TOOLS
            ITool onePanelLayout = new OnePanelLayout();
            ITool twoPanelLayout = new TwoPanelLayout();
            ITool threePanelLayout = new ThreePanelLayout();
            ITool fourPanelLayout = new FourPanelLayout();
            ITool parkBackground = new ParkBackground();
            ITool beachBackground = new BeachBackground();
            ITool classroomBackground = new ClassroomBackground();
            ITool kitchenBackground = new KitchenBackground();
            ITool bedroomBackground = new BedroomBackground();
            ITool studentCharacter = new StudentCharacter();
<<<<<<< HEAD
            ITool chair = new Chair();
            ITool tree = new Tree();

=======
            ITool swimmerCharacter = new SwimmerCharacter();
            ITool chefCharacter = new ChefCharacter();
            ITool doctorCharacter = new DoctorCharacter();
            ITool grandfatherCharacter = new GrandfatherCharacter();
            ITool basketCharacter = new BasketCharacter();
            ITool leftroundBubble = new LeftRoundBubble();
            ITool leftboxBubble = new LeftBoxBubble();
            ITool rightboxBubble = new RightBoxBubble();
>>>>>>> 6e9ee3ab3e02042165384078316751f07bb72b8e

            onePanelLayout.PanelContainer = this.panelGroupContainer;
            twoPanelLayout.PanelContainer = this.panelGroupContainer;
            threePanelLayout.PanelContainer = this.panelGroupContainer;
            fourPanelLayout.PanelContainer = this.panelGroupContainer;
            parkBackground.PanelContainer = this.panelGroupContainer;
            beachBackground.PanelContainer = this.panelGroupContainer;
            classroomBackground.PanelContainer = this.panelGroupContainer;
            kitchenBackground.PanelContainer = this.panelGroupContainer;
            bedroomBackground.PanelContainer = this.panelGroupContainer;
            studentCharacter.PanelContainer = this.panelGroupContainer;
<<<<<<< HEAD
            chair.PanelContainer = this.panelGroupContainer;
            tree.PanelContainer = this.panelGroupContainer;
=======
            swimmerCharacter.PanelContainer = this.panelGroupContainer;
            chefCharacter.PanelContainer = this.panelGroupContainer;
            doctorCharacter.PanelContainer = this.panelGroupContainer;
            grandfatherCharacter.PanelContainer = this.panelGroupContainer;
            basketCharacter.PanelContainer = this.panelGroupContainer;
            leftroundBubble.PanelContainer = this.panelGroupContainer;
            leftboxBubble.PanelContainer = this.panelGroupContainer;
            rightboxBubble.PanelContainer = this.panelGroupContainer;
>>>>>>> 6e9ee3ab3e02042165384078316751f07bb72b8e

            panelTool.AddTool(onePanelLayout);
            panelTool.AddTool(twoPanelLayout);
            panelTool.AddTool(threePanelLayout);
            panelTool.AddTool(fourPanelLayout);
            backgroundTool.AddTool(parkBackground);
            backgroundTool.AddTool(beachBackground);
            backgroundTool.AddTool(classroomBackground);
            backgroundTool.AddTool(kitchenBackground);
            backgroundTool.AddTool(bedroomBackground);
            characterTool.AddTool(studentCharacter);
<<<<<<< HEAD
            propertyTool.AddTool(chair);
            propertyTool.AddTool(tree);
=======
            characterTool.AddTool(swimmerCharacter);
            characterTool.AddTool(chefCharacter);
            characterTool.AddTool(doctorCharacter);
            characterTool.AddTool(grandfatherCharacter);
            characterTool.AddTool(basketCharacter);
            bubbleTool.AddTool(leftroundBubble);
            bubbleTool.AddTool(leftboxBubble);
            bubbleTool.AddTool(rightboxBubble);
>>>>>>> 6e9ee3ab3e02042165384078316751f07bb72b8e
            #endregion
        }
        
    }
}
