using System;
using System.Drawing;

namespace Draw.src.Model
{
    [Serializable]
    class CircleShape : Shape
    {
        #region Constructor
        public CircleShape(RectangleF rect) : base(rect)
        {
        }

        public CircleShape(Shape shape) : base(shape)
        {
        }
        #endregion

        public override bool Contains(PointF point)
        {
            // (x-h)^2/a^2 + (y-k)^2/b^2 <= 1
            float a = Rectangle.Width / 2;
            float b = Rectangle.Height / 2;
            float h = Location.X + a;
            float k = Location.Y + b;

            if (Math.Pow((point.X - h), 2) / Math.Pow(a, 2) + Math.Pow((point.Y - k), 2) / Math.Pow(b, 2) <= 1)
                return true;
            else
                return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            base.RotateShape(grfx);

            Pen pen = new Pen(Color.FromArgb(Transparency, BorderColor), BorderSize);
            SolidBrush brush = new SolidBrush(Color.FromArgb(Transparency, FillColor));


            grfx.FillEllipse(brush,
                              Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(pen,
                              Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
        }
    }
}
