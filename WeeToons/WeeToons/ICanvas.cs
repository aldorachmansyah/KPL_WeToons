using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons
{
    public interface ICanvas
    {
        String Name { get; set; }
        void Activate();
        void Deactivate();
        void SetBackground(Image image);
        ITool GetActiveTool();
        void SetActiveTool(ITool tool);
        void Repaint();
        void SetBackgroundColor(Color color);
        Point GetCanvasLocation();
        void AddDrawingObject(KomikObject drawingObject);
        /*void RemoveDrawingObject(KomikObject drawingObject);

        KomikObject GetObjectAt(int x, int y);
        KomikObject SelectObjectAt(int x, int y);*/
        void DeselectAllObjects();
    }
}
