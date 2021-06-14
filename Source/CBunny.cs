using BunnyHunter.Properties;
using System.Drawing;

namespace BunnyHunter
{
    class CBunny : CImageBase
    {
        protected Rectangle hotSpot = new Rectangle();
        public CBunny(Bitmap resources, int height, int width) : base(resources)
        {
            hotSpot.X = Left;
            hotSpot.Y = Top;
            hotSpot.Width = width;
            hotSpot.Height = height;
        }
        public void Update(int x, int y)
        {
            Left = x;
            Top = y;
            hotSpot.X = Left;
            hotSpot.Y = Top;
        }

        public bool Hit(int x, int y)
        {
            Rectangle c = new Rectangle(x, y, 1, 1);

            if (hotSpot.Contains(c))
            {
                return true;
            }

            return false;       
        }
    }
}
