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
      //  private IToolbox toolbox;
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

        }

        private void onePanelToolStrip_Click(object sender, EventArgs e)
        {
            this.editor.RemoveSelectedCanvas();
            Canvas canvas1 = new Canvas(0, 0, 660, 660);
            canvas1.Name = "Full Single Panel";
            this.editor.AddCanvas(canvas1);
        }

        private void twoPanelToolStrip_Click(object sender, EventArgs e)
        {
            this.editor.RemoveSelectedCanvas();
            Canvas canvas1 = new Canvas(0, 0, 320, 320);
            canvas1.Name = "Left Double Panel";
            this.editor.AddCanvas(canvas1);
            Canvas canvas2 = new Canvas(330, 0, 320, 320);
            canvas1.Name = "Right Double Panel";
            this.editor.AddCanvas(canvas2);
        }

        private void threePanelToolStrip_Click(object sender, EventArgs e)
        {
            this.editor.RemoveSelectedCanvas();
            Canvas canvas1 = new Canvas(0, 0, 200, 200);
            canvas1.Name = "Top Left";
            this.editor.AddCanvas(canvas1);
            Canvas canvas2 = new Canvas(0, 210, 200, 200);
            canvas1.Name = "Bottom Left";
            this.editor.AddCanvas(canvas2);
            Canvas canvas3 = new Canvas(210, 0, 420, 420);
            canvas1.Name = "Right";
            this.editor.AddCanvas(canvas3);
        }

        private void fourPanelToolStrip_Click(object sender, EventArgs e)
        {
            this.editor.RemoveSelectedCanvas();
            Canvas canvas1 = new Canvas(0, 0, 320, 320);
            canvas1.Name = "Top Left";
            this.editor.AddCanvas(canvas1);
            Canvas canvas2 = new Canvas(330, 0, 320, 320);
            canvas1.Name = "Bottom Left";
            this.editor.AddCanvas(canvas2);
            Canvas canvas3 = new Canvas(0, 330, 320, 320);
            canvas1.Name = "Right";
            this.editor.AddCanvas(canvas3);
            Canvas canvas4 = new Canvas(330, 330, 320, 320);
            canvas1.Name = "bottom right";
            this.editor.AddCanvas(canvas4);
        }

       

       

        private void removeAllPanel()
        {
           /* if (this.panelGroup != null)
            {
                foreach (FlowLayoutPanel panel in this.panelGroup)
                {
                    this.Controls.Remove(panel);
                }
            }*/
        }

        /*private void panel_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            activatePanel(panel);
        }*/

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
