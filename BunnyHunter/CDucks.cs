using BunnyHunter.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyHunter
{
    class CDucks : CImageBase
    {
        public CDucks():base(Resources.Ducks_1){}

        public override void Animated(int frame)
        {
            if (frame == 1)
            {
                this.ChangeResource(Resources.Ducks_1);
            }
            if (frame == 2)
            {
                this.ChangeResource(Resources.Ducks_2);
            }
            if (frame == 3)
            {
                this.ChangeResource(Resources.Ducks_3);
            }
            if (frame == 4)
            {
                this.ChangeResource(Resources.Ducks_4);
            }
            if (frame == 5)
            {
                this.ChangeResource(Resources.Ducks_5);
            }

        }

    }
}
