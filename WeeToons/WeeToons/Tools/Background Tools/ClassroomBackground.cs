using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;

namespace WeeToons.Tools.Background_Tools
{
    class ClassroomBackground : ToolStripMenuItem, ITool
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

        public ClassroomBackground()
        {
            this.Text = "Classroom";
            this.Name = "classroomBackgroundToolStrip";
            this.Click += new EventHandler(this.tool_Click);
            this.Image = new Bitmap(@"..\..\..\Resources\Background\classroom.jpg");
        }

        public void tool_Click(object sender, EventArgs e)
        {
            IPanel activePanel = this.panelContainer.ActivePanel;
            if (activePanel != null)
            {
                Image backgroundImage = new Bitmap(@"..\..\..\Resources\Background\classroom.jpg");
                activePanel.SetBackground(backgroundImage);
            }
        }
    }
}
