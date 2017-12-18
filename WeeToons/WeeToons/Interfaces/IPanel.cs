using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeeToons.Tools.Selection_Tools;

namespace WeeToons.Interfaces
{
    public interface IPanel
    {
        KomikObject SelectObjectAt(int x, int y);
        SelectionTool SelectionTool { get; set; }

        void AddComicObject(KomikObject drawingObject);
        void ChangeBorder(BorderStyle borderStyle);
        void SetBackground(Image backgroundImage);
        void Repaint();
    }
}
