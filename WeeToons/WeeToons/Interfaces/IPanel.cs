using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeToons.Interfaces
{
    public interface IPanel
    {
        void ChangeBorder(BorderStyle borderStyle);
        void SetBackground(Image backgroundImage);
    }
}
