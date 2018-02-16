using System;
using System.Drawing;

namespace BunnyHunter
{
    class CImageBase : IDisposable
    {
        bool disposed = false;
        protected Bitmap bitmap;
        private int X;
        private int Y;

        public int Left { get { return X; } set { X = value; } }

        public int Top { get { return Y; } set { Y = value; } }

        public CImageBase(Bitmap resource)
        {
            bitmap = new Bitmap(resource);
        }

        public virtual void Animated(int frame) { }

        public void ChangeResource(Bitmap resource)
        {
            bitmap = resource;
        }

        public void ChangeResource(Bitmap resources, int width, int height)
        {
            bitmap = new Bitmap(resources, width, height);
        }

        public void DrawImage(Graphics frame)
        {
            frame.DrawImage(bitmap, X, Y); 
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if (disposing)
            {
                bitmap.Dispose();
            }

            disposed = true;
        }
    }
}
