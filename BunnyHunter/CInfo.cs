using BunnyHunter.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyHunter
{
    class CInfo : CImageBase
    {
        public CInfo() : base(Resources.Update_1 ) { }

        public override void Animated(int frame)
        {
            if (frame == 1)
            {
                this.ChangeResource(Resources.Update_1, 45, 45);
            }
            if (frame == 2)
            {
                this.ChangeResource(Resources.Update_2, 45, 45);
            }
            if (frame == 3)
            {
                this.ChangeResource(Resources.Update_3, 45, 45);
            }
            if (frame == 4)
            {
                this.ChangeResource(Resources.Update_4, 45, 45);
            }
            if (frame == 5)
            {
                this.ChangeResource(Resources.Update_5, 45, 45);
            }
            if (frame == 6)
            {
                this.ChangeResource(Resources.Update_6, 45, 45);
            }
            if (frame == 7)
            {
                this.ChangeResource(Resources.Update_7, 45, 45);
            }
            if (frame == 8)
            {
                this.ChangeResource(Resources.Update_8, 45, 45);
            }
            if (frame == 9)
            {
                this.ChangeResource(Resources.Update_9, 45, 45);
            }
            if (frame == 10)
            {
                this.ChangeResource(Resources.Update_10, 45, 45);
            }
            if (frame == 11)
            {
                this.ChangeResource(Resources.Update_11, 45, 45);
            }
            if (frame == 12)
            {
                this.ChangeResource(Resources.Update_12, 45, 45);
            }
        }
    }
}
