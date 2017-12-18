using System;
using System.Collections.Generic;
using WeeToons.Interfaces;

namespace WeeToons
{
    public interface IPanelContainer
    {
        IPanel ActivePanel { get; set; }
        String Text { get; set; }

        void SetActivePanel(IPanel panel);
        void AddPanel(IPanel panel);
        void RemoveAllPanel();
        void panel_Click(object sender, EventArgs e);
    }
}