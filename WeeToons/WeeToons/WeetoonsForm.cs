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

namespace WeeToons
{
    public partial class WeeToonsForm : Form
    {
<<<<<<< HEAD
        public WeeToonsForm()
        {
            InitializeComponent();
=======
        private Point firstPoint = new Point();
        Image targetImage;
        int height;
        int width;
        private IToolbox toolbox;
        private IEditor editor;
        //private IToolbar toolbar;
        //private IMenubar menubar;

        public WeeToonsForm()
        {
            InitializeComponent();
            InitUI();
            
        }

        private void InitUI()
        {
            #region Editor and Canvas
            Debug.WriteLine("Loading canvas...");
            this.editor = new DefaultEditor();
            this.pictureBox1.Controls.Add((Control)this.editor);
            #endregion

            #region Toolbox

            // Initializing toolbox
            Debug.WriteLine("Loading toolbox...");
            this.toolbox = new DefaultToolbox();
            this.toolStripContainer1.Dock = DockStyle.Right;
            this.toolStripContainer1.RightToolStripPanel.Controls.Add((Control)this.toolbox);
            this.editor.Toolbox = toolbox;

            #endregion

            #region Tools

            // Initializing tools
            Debug.WriteLine("Loading tools...");
            this.toolbox.AddTool(new SelectionTool());
            this.toolbox.ToolSelected += Toolbox_ToolSelected;



            #endregion

        }

        private void Toolbox_ToolSelected(ITool tool)
        {
            if (this.editor != null)
            {
                Debug.WriteLine("Tool " + tool.Name + " is selected");
                ICanvas canvas = this.editor.GetSelectedCanvas();
                if(canvas != null)
                {
                    canvas.SetActiveTool(tool);
                    tool.TargetCanvas = canvas;
                }
      
            }
>>>>>>> cd5a23864417c3949bb8b40c4e1e591551afc650
        }

        private void onePanelToolStrip_Click(object sender, EventArgs e)
        {
            removeAllPanel();
            FlowLayoutPanel newPanel = renderPanel(49, 37, 660, 660, "Full Single Panel");
            activatePanel(newPanel);
        }

        private void twoPanelToolStrip_Click(object sender, EventArgs e)
        {
            removeAllPanel();
            FlowLayoutPanel leftPanel = renderPanel(49, 37, 320, 320, "Left Double Panel");
            FlowLayoutPanel rightPanel = renderPanel(375, 37, 320, 320, "Right Double Panel");
            activatePanel(leftPanel);
        }

        private void threePanelToolStrip_Click(object sender, EventArgs e)
        {
            removeAllPanel();
            FlowLayoutPanel leftPanelTop = renderPanel(49, 37, 200, 200, "Top Left Triple Panel");
            FlowLayoutPanel leftPanelBottom = renderPanel(49, 257, 200, 200, "Bottom Left Triple Panel");
            FlowLayoutPanel rightPanel = renderPanel(265, 37, 420, 420, "Right Triple Panel");
            activatePanel(leftPanelTop);
        }

        private void fourPanelToolStrip_Click(object sender, EventArgs e)
        {
            removeAllPanel();
            FlowLayoutPanel leftTopPanel = renderPanel(49, 37, 320, 320, "Top Left Quartet Panel");
            FlowLayoutPanel rightTopPanel = renderPanel(375, 37, 320, 320, "Top Right Quartet Panel");
            FlowLayoutPanel leftBottomPanel = renderPanel(47, 370, 320, 320, "Bottom Left Quartet Panel");
            FlowLayoutPanel rightBottomPanel = renderPanel(375, 370, 320, 320, "Bottom Right Quartet Panel");
            activatePanel(leftTopPanel);
        }

        private FlowLayoutPanel renderPanel(int xPosition, int yPosition, int width, int height, string panelName = "Unknown Panel")
        {
            System.Windows.Forms.FlowLayoutPanel panel;
            panel = new System.Windows.Forms.FlowLayoutPanel();

            panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.Location = new System.Drawing.Point(xPosition, yPosition);
            panel.Name = panelName;
            panel.Size = new System.Drawing.Size(height, width);
            panel.TabIndex = 2;
            panel.Click += new System.EventHandler(this.panel_Click);

            this.Controls.Add(panel);
            this.panelGroup.Add(panel);

            return panel;
        }

        private void activatePanel(FlowLayoutPanel panel)
        {
            if(this.activePanel != null)
            {
                this.activePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activePanel = panel;
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

        private void panel_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
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

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
