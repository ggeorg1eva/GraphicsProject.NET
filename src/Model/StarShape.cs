using System;
using System.Drawing;

namespace Draw.src.Model
{
    [Serializable]
    class StarShape : Shape
    {
        private PointF[] points = new PointF[10];

        #region Constructor

        public StarShape(RectangleF rect) : base(rect)
        {
        }

        public StarShape(StarShape star) : base(star)
        {
        }

        #endregion

        public override bool Contains(PointF point)
        {
            PointF pt = new PointF(9999, point.Y);
            int count = 0;
            int i = 0;

            do
            {
                Line side = new Line(points[i], points[(i + 1) % 10]);
                if (isIntersect(side.p1, side.p2, point, pt))
                {
                    if (direction(side.p1, point, side.p2) == 0)
                        return isOnLine(side.p1, side.p2, point);
                    count++;
                }
                i = (i + 1) % 10;
            } while (i != 0);

            if (count % 2 != 0)
                return true;
            else
                return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            base.RotateShape(grfx);

            // {(rcos(2πk/5+π/2),rsin(2πk/5+π/2))∣k=0,...,4} For outter/inner points

            for (int i = 0; i < 5; i++)
            {
                this.points[i * 2] = new PointF(this.GetXNthStarPoint(true, i), this.GetYNthStarPoint(true, i));
                this.points[i * 2 + 1] = new PointF(this.GetXNthStarPoint(false, i), this.GetYNthStarPoint(false, i));
            }

            grfx.FillPolygon(new SolidBrush(Color.FromArgb(Transparency, FillColor)), points);
            grfx.DrawPolygon(new Pen(Color.FromArgb(Transparency, BorderColor), BorderSize), points);
        }

        private float GetXNthStarPoint(bool isTip, int n)
        {
            float radius = isTip ? Rectangle.Height / 2 : Rectangle.Height / 4;
            double theta = Math.PI - 2 * Math.PI * (n + (isTip ? 0 : 0.5)) / 5 + Math.PI / 10;

            return Rectangle.X + (float)(radius * Math.Cos(theta));
        }

        private float GetYNthStarPoint(bool isTip, int n)
        {
            float radius = isTip ? Rectangle.Height / 2 : Rectangle.Height / 4;
            double theta = Math.PI - 2 * Math.PI * (n + (isTip ? 0 : 0.5)) / 5 + Math.PI / 10;

            return Rectangle.Y + (float)(radius * Math.Sin(theta));
        }
    }
}
