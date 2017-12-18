using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WeeToons.Interfaces;
using WeeToons.Tools;

namespace WeeToons
{
    class PanelTool : ToolDropDownObject
    {
        public PanelTool()
        {
            this.Name = "panelToolStrip";
            this.Text = "Panel";
            this.Image = Bitmap.FromFile(@"..\..\..\Resources\Icon\panels.png");
        }
    }
}