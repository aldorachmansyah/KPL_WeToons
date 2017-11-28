using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons
{
    class Canvas
    {
        private List<KomikObject> objects;

        public Canvas(List<KomikObject> objects)
        {
            this.objects= objects;
        }

        public void AddKomikObject(KomikObject obj)
        {
            this.objects.Add(obj);
        }

        public void RemoveKomikObject(int objIndex)
        {
            this.objects.RemoveAt(objIndex);
        }

        public void RenderKomikObject()
        {
            //Render object action
        }
    }
}
