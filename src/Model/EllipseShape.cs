﻿using System;
using System.Drawing;

namespace Draw.src.Model
{
    [Serializable]
    class EllipseShape : Shape
    {

        #region Constructor
        public EllipseShape(RectangleF rect) : base(rect)
        {
        }

        public EllipseShape(Shape shape) : base(shape)
        {
        }

        #endregion
        public override bool Contains(PointF point)
        {
            float a = Rectangle.Width / 2;
            float b = Rectangle.Height / 2;
            float h = Location.X + a;
            float k = Location.Y + b;

            return ((point.X - h) * (point.X - h) / (a * a)) + ((point.Y - k) * (point.Y - k) / (b * b)) <= 1;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            base.RotateShape(grfx);

            grfx.FillEllipse(new SolidBrush(Color.FromArgb(Transparency, FillColor)),
                              Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(new Pen(Color.FromArgb(Transparency, BorderColor), BorderSize),
                              Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
        }

    }
}
