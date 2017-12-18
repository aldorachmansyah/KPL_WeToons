using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons
{
    public class EditingState : State
    {
        private static State instance;

        public static State GetInstance()
        {
            if (instance == null)
            {
                instance = new EditingState();
            }
            return instance;
        }

        public override void Draw(KomikObject obj)
        {
            obj.RenderOnEditingView();
        }

        public override void Deselect(KomikObject obj)
        {
            obj.ChangeState(StaticState.GetInstance());
        }

    }
}
