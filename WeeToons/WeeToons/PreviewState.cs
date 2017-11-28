using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeToons
{
    public class PreviewState : State
    {
        private static State instance;

        private static State GetInstance()
        {
            if (instance == null)
            {
                instance = new PreviewState();
            }
            return instance;
        }

        public override void Draw(KomikObject obj)
        {
            throw new NotImplementedException();
        }

        public override void Select(KomikObject obj)
        {
            obj.ChangeState(EditState.GetInstance());
        }

    }
}
