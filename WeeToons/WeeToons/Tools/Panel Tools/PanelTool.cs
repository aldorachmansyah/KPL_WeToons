using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WeeToons.Interfaces;

namespace WeeToons
{
    class PanelTool : ToolStripDropDownButton, IToolGroup
    {

        public PanelTool()
        {
            this.Name = "panelToolStrip";
            this.Size = new Size(79, 34);
            this.Text = "Panel";
        }

        public void AddSeparator()
        {
            this.DropDownItems.Add(new ToolStripSeparator());
        }

        public void AddTool(ITool tool)
        {
            
            this.DropDownItems.Add((ToolStripItem)tool);
        }

        public void AddToolGroup(IToolGroup toolGroup)
        {
            ToolStripItem toolstripItem = (ToolStripItem)toolGroup;
            this.DropDownItems.Add(toolstripItem);
        }

        public void RemoveTool(ITool tool)
        {
            foreach (ToolStripItem item in this.DropDownItems)
            {
                if (item is ITool)
                {
                    if (item.Equals(tool))
                    {
                        this.DropDownItems.Remove(item);
                    }
                }
            }
        }
    }
}