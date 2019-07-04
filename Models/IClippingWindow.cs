using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineClippingWindow.Models
{
    public interface IClippingWindow
    {
        bool isPointInWindow(Point point);
        bool isSegmentIntersectsWindow(Point A, Point B);
    }
}
