using LineClippingWindow.Models;
using LineClippingWindow.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineClippingWindow.Presenters
{
    public class MainViewPresenter
    {
        private IMainView _view;
        private List<Point> _points=new List<Point>();
        private IClippingWindow _clippingWindow;

        public MainViewPresenter(IMainView view)
        {
            _view = view;
        }

        public void SetClippingWindow(int topLeftX, int topLeftY, int width, int height)
        {
            Point topLeft = new Point(topLeftX, topLeftY);
            _clippingWindow = new RectangularClippingWindow(topLeft, width, height);
        }

        public void SetClippingWindow(decimal topLeftX, decimal topLeftY, decimal width, decimal height)
        {
            Point topLeft = new Point(Convert.ToInt32(topLeftX), Convert.ToInt32(topLeftY));
            _clippingWindow = new RectangularClippingWindow(topLeft, Convert.ToInt32(width), Convert.ToInt32(height));
        }
        
        public void FindSegmentsInArea() 
        {
            List<Point> selected = new List<Point>(); // список отрезков, попадающих в области
            Point prevPoint = null;
            foreach (Point point in _points)
            {
                if (prevPoint != null)
                {
                    if (_clippingWindow.isSegmentIntersectsWindow(prevPoint, point))
                    {
                        selected.Add(prevPoint);
                        selected.Add(point);
                    }
                }
                prevPoint = point;
            }
            _view.ShowPoints(_points, _clippingWindow);
            _view.BoldSegmentsInArea(selected);
        }
                   
        //Добавление новой точки
        public void AddNewSegment(int X, int Y)
        {
            Point newPoint = new Point(X, Y);
            int n = _points.Count;
            if (n == 0)
                _points.Add(newPoint);
            //новая точка не должна быть равна предыдущей или n-2ой
            else if (!((n > 0 && newPoint.IsEqual(_points[n - 1], 5)) || (n > 1 && newPoint.IsEqual(_points[n - 2], 5))))
            {
                _points.Add(newPoint);                
            }
            _view.ShowPoints(_points, _clippingWindow);
        }

        public bool IsLineClosed()
        {
            return _points.Count > 3 && _points[0].IsEqual(_points[_points.Count - 1],0);
        }
        public void DisplaySegments()
        {
            _view.ShowPoints(_points, _clippingWindow);
        }

        public void ClearPoints()
        {
            _points.Clear();
            _view.ShowPoints(_points, _clippingWindow);
        }
    }
}
