using BunnyHunter.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyHunter
{
    class CLevel : CImageBase
    {
        public CLevel():base(Resources.Level1_1) { }

        public void Animated(int frame, ref bool isLevel1, ref bool isLevel2, ref  bool isLevel3, ref bool isBonus)
        {
            if (isLevel1)
            {
                if (frame == 2)
                {
                    this.ChangeResource(Resources.Level1_1);
                }
                if (frame == 4)
                {
                    this.ChangeResource(Resources.Level1_2);
                }
                if (frame == 6)
                {
                    this.ChangeResource(Resources.Level1_3);
                }
                if (frame == 8)
                {
                    this.ChangeResource(Resources.Level1_4);
                }
                if (frame == 10)
                {
                    this.ChangeResource(Resources.Level1_5);
                }
                if (frame == 12)
                {
                    this.ChangeResource(Resources.Level1_6);
                }
                if (frame == 14)
                {
                    this.ChangeResource(Resources.Level1_7);
                }
                if (frame == 16)
                {
                    this.ChangeResource(Resources.Level1_8);
                }
                if (frame == 18)
                {
                    this.ChangeResource(Resources.Level1_9);
                    isLevel1 = false;
                }
            }
            else if (isLevel2)
            {
                if (frame == 2)
                {
                    this.ChangeResource(Resources.Level2_1);
                }
                if (frame == 4)
                {
                    this.ChangeResource(Resources.Level2_2);
                }
                if (frame == 6)
                {
                    this.ChangeResource(Resources.Level2_3);
                }
                if (frame == 8)
                {
                    this.ChangeResource(Resources.Level2_4);
                }
                if (frame == 10)
                {
                    this.ChangeResource(Resources.Level2_5);
                }
                if (frame == 12)
                {
                    this.ChangeResource(Resources.Level2_6);
                }
                if (frame == 14)
                {
                    this.ChangeResource(Resources.Level2_7);
                }
                if (frame == 16)
                {
                    this.ChangeResource(Resources.Level2_8);
                }
                if (frame == 18)
                {
                    this.ChangeResource(Resources.Level2_9);
                    isLevel2 = false;
                }
            }
            else if (isLevel3)
            {
                if (frame == 2)
                {
                    this.ChangeResource(Resources.Level3_1);
                }
                if (frame == 4)
                {
                    this.ChangeResource(Resources.Level3_2);
                }
                if (frame == 6)
                {
                    this.ChangeResource(Resources.Level3_3);
                }
                if (frame == 8)
                {
                    this.ChangeResource(Resources.Level3_4);
                }
                if (frame == 10)
                {
                    this.ChangeResource(Resources.Level3_5);
                }
                if (frame == 12)
                {
                    this.ChangeResource(Resources.Level3_6);
                }
                if (frame == 14)
                {
                    this.ChangeResource(Resources.Level3_7);
                }
                if (frame == 16)
                {
                    this.ChangeResource(Resources.Level3_8);
                }
                if (frame == 18)
                {
                    this.ChangeResource(Resources.Level3_9);
                    isLevel3 = false;
                }
            }
            else if (isBonus)
            {
                if (frame == 2)
                {
                    this.ChangeResource(Resources.Level1_1);
                }
                if (frame == 4)
                {
                    this.ChangeResource(Resources.Level1_2);
                }
                if (frame == 6)
                {
                    this.ChangeResource(Resources.Level1_3);
                }
                if (frame == 8)
                {
                    this.ChangeResource(Resources.Level1_4);
                }
                if (frame == 10)
                {
                    this.ChangeResource(Resources.Level1_5);
                }
                if (frame == 12)
                {
                    this.ChangeResource(Resources.Level1_6);
                }
                if (frame == 14)
                {
                    this.ChangeResource(Resources.Level1_7);
                }
                if (frame == 16)
                {
                    this.ChangeResource(Resources.Level1_8);
                }
                if (frame == 18)
                {
                    this.ChangeResource(Resources.Level1_9);
                    isBonus = false;
                }
            }
        }

         
    }
}
