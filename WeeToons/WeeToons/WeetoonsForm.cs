using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeToons
{
    public partial class WeeToonsForm : Form
    {
        private Point firstPoint = new Point();
        Image targetImage;
        int height;
        int width;

        public WeeToonsForm()
        {
            InitializeComponent();
            
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
            if (this.activePanel != null)
            {
                this.activePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel.Controls.Add(pictureBox1);
            
            
            this.activePanel = panel;


        }

        private void removeAllPanel()
        {
            if (this.panelGroup != null)
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

        private void happyBoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image imageBox = new Bitmap(@"..\..\..\Resources\Character\boy.png");
            this.pictureBox1.Image = imageBox;
           
            pictureBox1.BackColor = Color.Transparent;
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //something
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            { firstPoint = Control.MousePosition; }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point temp = Control.MousePosition;
                Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                pictureBox1.Location = new Point(pictureBox1.Location.X - res.X, pictureBox1.Location.Y - res.Y);

                firstPoint = temp;
            }
        }

        private void shrinkButton_Click(object sender, EventArgs e)
        {
            targetImage = pictureBox1.Image;
            height =  targetImage.Height - 10;
            width = targetImage.Width - 10;
            pictureBox1.Image = ResizeNow(width, height);
        }

        private Bitmap ResizeNow (int target_height, int target_width)
        {
            Rectangle dest_rect = new Rectangle(0, 0, target_width, target_height);
            Bitmap destImage = new Bitmap(target_width, target_height);
            destImage.SetResolution(targetImage.HorizontalResolution, targetImage.VerticalResolution);
            using (var g = Graphics.FromImage(destImage))
            {
                g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (var wrapmode = new ImageAttributes())
                {
                    wrapmode.SetWrapMode(WrapMode.TileFlipXY);
                    g.DrawImage(targetImage, dest_rect, 0, 0, targetImage.Width, targetImage.Height, GraphicsUnit.Pixel, wrapmode);
                }
            }
            return destImage;
        }

        private void expandButton_Click(object sender, EventArgs e)
        {
            targetImage = pictureBox1.Image;
            height = targetImage.Height + 10;
            width = targetImage.Width + 10;
            pictureBox1.Image = ResizeNow(width, height);
        }
    }
}
