using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons
{
    public abstract class State
    {
        public State WeState
        {
            get
            {
                return this.state;
            }
        }

        private State state;

        public abstract void Draw(KomikObject obj);

        public virtual void Deselect(KomikObject obj)
        {
            //default implementation, no state transition
        }

        public virtual void Select(KomikObject obj)
        {
            //default implementation, no state transition
        }
    }
}
