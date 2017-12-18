using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Interfaces;

namespace WeeToons.Tools
{
    public abstract class ToolDropDownObject: ToolStripDropDownButton, IToolGroup
    {
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
