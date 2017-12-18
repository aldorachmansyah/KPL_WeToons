using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons
{ 
    public class StaticState : State
    {
        private static State instance;

        public static State GetInstance()
        {
            if (instance == null)
            {
                instance = new StaticState();
            }
            return instance;
        }

        public override void Draw(KomikObject obj)
        {
            throw new NotImplementedException();
        }

        public override void Select(KomikObject obj)
        {
            obj.ChangeState(ActiveState.GetInstance());
        }
    }
}
