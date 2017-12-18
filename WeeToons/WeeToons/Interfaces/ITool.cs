using System;

namespace WeeToons.Interfaces
{
    public interface ITool
    {
        IPanelContainer PanelContainer { get; set; }

        void tool_Click(object sender, EventArgs e);
    }
}