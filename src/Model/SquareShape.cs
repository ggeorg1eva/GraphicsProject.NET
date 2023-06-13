using System;
using System.Drawing;

namespace Draw.src.Model
{
    [Serializable]
    class SquareShape : Shape
    {
        #region Constructor
        public SquareShape()
        {
        }

        public SquareShape(RectangleF rect) : base(rect)
        {
        }

        public SquareShape(Shape shape) : base(shape)
        {
        }
        #endregion
        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            base.RotateShape(grfx);

            grfx.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, FillColor)),
                    Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(new Pen(Color.FromArgb(Transparency, BorderColor), BorderSize),
                                Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
        }
    }
}
