using System;
using System.Drawing;
using System.Windows.Forms;
using WeeToons.Interfaces;

namespace WeeToons
{
    class DefaultToolGroup : ToolStrip, IToolGroup
    {
        
        public void AddSeparator()
        {
            this.Items.Add(new ToolStripSeparator());
        }

        public void AddTool(ITool tool)
        {
            ToolStripItem toolstripItem = (ToolStripItem)tool;
            this.Items.Add(toolstripItem);
        }

        public void AddToolGroup(IToolGroup toolGroup)
        {
            ToolStripItem toolstripItem = (ToolStripItem)toolGroup;
            this.Items.Add(toolstripItem);
        }

        public void RemoveTool(ITool tool)
        {
            foreach (ToolStripItem item in this.Items)
            {
                if (item is ITool)
                {
                    if (item.Equals(tool))
                    {
                        this.Items.Remove(item);
                    }
                }
            }
        }
    }
}