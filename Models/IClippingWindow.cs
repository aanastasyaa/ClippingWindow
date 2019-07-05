using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineClippingWindow.Models
{
    public interface IClippingWindow
    {
        bool IsPointInWindow(Point point);
        bool IsSegmentIntersectsWindow(Point A, Point B);
    }
}
