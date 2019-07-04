using LineClippingWindow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineClippingWindow.Views
{
    public interface IMainView
    {
        void BoldSegmentsInArea(List<Point> segments);
        void ShowPoints(List<Point> points, IClippingWindow window);
    }
}
