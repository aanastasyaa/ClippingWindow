using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineClippingWindow.Models
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool IsEqual(Point point, int precision)
        {
            return X <= point.X + precision && X >= point.X - precision && Y <= point.Y + precision && Y >= point.Y - precision;
        }
    }
}
