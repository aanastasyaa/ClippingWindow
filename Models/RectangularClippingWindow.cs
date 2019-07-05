using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineClippingWindow.Models
{
    public class RectangularClippingWindow : IClippingWindow
    {
        public Point TopLeft { get; private set; }
        public Point TopRight { get; private set; }
        public Point BottomLeft { get; private set; }
        public Point BottomRight { get; private set; }
        private int ymin = 0, ymax = 0, xmin = 0, xmax = 0;

        public RectangularClippingWindow(Point topLeft, int width, int length)
        {
            TopLeft = topLeft;
            TopRight = new Point(topLeft.X + width, TopLeft.Y);
            BottomLeft = new Point(topLeft.X, topLeft.Y + length);
            BottomRight = new Point(topLeft.X + width, topLeft.Y + length);
            ymin = topLeft.Y;
            ymax = ymin + length;
            xmin = topLeft.X;
            xmax = xmin + width;
        }

        public void SetSize(int width, int length)
        {
            TopRight = new Point(TopLeft.X + width, TopLeft.Y);
            BottomLeft = new Point(TopLeft.X, TopLeft.Y + length);
            BottomRight = new Point(TopLeft.X + width, TopLeft.Y + length);
            ymin = TopLeft.Y;
            ymax = ymin + length;
            xmin = TopLeft.X;
            xmax = xmin + width;
        }

        //находится ли точка внутри прямоугольника или на его стороне
        public bool IsPointInWindow(Point point)
        {
            return point.X >= xmin && point.X <= xmax && point.Y >= ymin && point.Y <= ymax;
        }

        //проверка на пересечение отрезком одной из сторон прямоугольника
        private bool IsSegmentIntersectsSide(Point A, Point B, Point S1, Point S2)
        {
            //граничный случай: отрезки лежат на одной прямой
            if ((A.X == B.X && S1.X == S2.X && A.X == S1.X) || (A.Y == B.Y && S1.Y == S2.Y && A.Y == S1.Y))
                return false;
            //векторные произведения
            int abs1 = (B.X - A.X) * (S1.Y - A.Y) - (B.Y - A.Y) * (S1.X - A.X);
            int abs2 = (B.X - A.X) * (S2.Y - A.Y) - (B.Y - A.Y) * (S2.X - A.X);
            int as1s2 = (S2.X - S1.X) * (A.Y - S1.Y) - (S2.Y - S1.Y) * (A.X - S1.X);
            int bs1s2 = (S2.X - S1.X) * (B.Y - S1.Y) - (S2.Y - S1.Y) * (B.X - S1.X);

            // векторные произведения должны быть разных знаков, 
            // это означает, что конца одного отрезка находятся по разные стороны от другого
            // может быть переполнение, поэтому применяется Math.Sign
            return (Math.Sign(as1s2) != Math.Sign(bs1s2) || as1s2 == 0 || bs1s2 == 0) 
                && (Math.Sign(abs2) != Math.Sign(abs1) || abs2 == 0 || abs1 == 0);
        }

        public bool IsSegmentIntersectsWindow(Point A, Point B)
        {
            if (IsPointInWindow(A) || IsPointInWindow(B))
                return true;
            if (IsSegmentIntersectsSide(A, B, TopLeft, TopRight) || IsSegmentIntersectsSide(A, B, BottomLeft, BottomRight))
                return true;
            if (IsSegmentIntersectsSide(A, B, TopLeft, BottomLeft) || IsSegmentIntersectsSide(A, B, TopRight, BottomRight))
                return true;
            return false;
        }
    }
}
