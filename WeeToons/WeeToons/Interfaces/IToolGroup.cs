using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons.Interfaces
{
    public interface IToolGroup
    {
        void AddTool(ITool tool);
        void RemoveTool(ITool tool);
        void AddSeparator();
        void AddToolGroup(IToolGroup toolGroup);
    }
}
