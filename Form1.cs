using LineClippingWindow.Models;
using LineClippingWindow.Presenters;
using LineClippingWindow.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LineClippingWindow
{
    public partial class Form1 : Form, IMainView
    {
        private readonly MainViewPresenter _presenter;
        private System.Drawing.Bitmap _bitmap;
        public Form1()
        {
            InitializeComponent();
            windowTopLeftY_numericUpDown.Maximum = pictureBox.Size.Height;
            windowTopLeftX_numericUpDown.Maximum = pictureBox.Size.Width;
            windowWidth_numericUpDown.Maximum = pictureBox.Size.Width;
            windowLength_numericUpDown.Maximum = pictureBox.Size.Height;
            _presenter = new MainViewPresenter(this);
            _presenter.SetClippingWindow(
                windowTopLeftX_numericUpDown.Value, windowTopLeftY_numericUpDown.Value,
                windowWidth_numericUpDown.Value, windowLength_numericUpDown.Value
                );
            _presenter.DisplaySegments();
        }
        
        public void BoldSegmentsInArea(List<Point> segments)
        {
            //выделение на pictureBox входящих в область отрезков
            _bitmap = new System.Drawing.Bitmap(pictureBox.Image);
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(_bitmap))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                for (int i = 0; i < segments.Count - 1; i += 2)
                {
                    Point p1 = segments[i];
                    Point p2 = segments[i + 1];
                    g.FillEllipse(System.Drawing.Brushes.Red, p1.X - 6/2, p1.Y - 6/2, 6, 6);
                    g.FillEllipse(System.Drawing.Brushes.Red, p2.X - 6/2, p2.Y - 6/2, 6, 6);
                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Brushes.Red, 2), p1.X, p1.Y, p2.X, p2.Y);                    
                }
            }
            pictureBox.Refresh();
        }

        public void ShowPoints(List<Point> points, IClippingWindow window)
        {
            _bitmap = new System.Drawing.Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(_bitmap))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                for (int i = 0; i < points.Count; i++)
                {
                    g.FillEllipse(System.Drawing.Brushes.Black, points[i].X-5/2, points[i].Y-5/2, 5, 5);
                    if(i > 0)
                    {
                        g.DrawLine(new System.Drawing.Pen(System.Drawing.Brushes.Black, 1), points[i - 1].X, points[i - 1].Y, points[i].X, points[i].Y);
                    }
                }
                DrawClippingWindow(window, g);
            }
            pictureBox.Refresh();
        } 

        public void DrawClippingWindow(IClippingWindow window, System.Drawing.Graphics g)
        {
            RectangularClippingWindow rectWindow = window as RectangularClippingWindow;
            if (rectWindow != null)
            {
                g.DrawRectangle(new System.Drawing.Pen(System.Drawing.Brushes.Blue, 1),
                    rectWindow.TopLeft.X, rectWindow.TopLeft.Y,
                    rectWindow.TopRight.X - rectWindow.TopLeft.X,
                    rectWindow.BottomLeft.Y - rectWindow.TopLeft.Y);
            }
        }

        private void CleanPictureBox_btn_Click(object sender, EventArgs e)
        {
            _presenter.ClearPoints();
        }

        private void FindSegmentInArea_btn_Click(object sender, EventArgs e)
        {
            _presenter.FindSegmentsInArea();
        }
        
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _presenter.AddNewSegment(e.X, e.Y); // отрисовка новой точки и соединение с предыдущей
                
            }
            pictureBox.Refresh();
        }

        private System.Drawing.Point mouseLocation;
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            mouseLocation = e.Location;
            mouseLocation_lbl.Text = "(" + e.X + "," + e.Y + ")";
        }
        
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            pictureBox.Image = _bitmap;
        }

        private void ChangeWindowParameters_btn_Click(object sender, EventArgs e)
        {
            String errorMsg = "";
            errorMsgs_richTextBox.Text = "";
            if (windowLength_numericUpDown.Value > pictureBox.Size.Height || windowWidth_numericUpDown.Value > pictureBox.Size.Width)
            {
                errorMsg += ("Заданы слишком большие размеры прямоугольной области. \nДлина должна быть меньше "
                    + pictureBox.Size.Height + ", а ширина меньше " + pictureBox.Size.Width + "\n");
            }
            if(windowTopLeftX_numericUpDown.Value + windowWidth_numericUpDown.Value >= pictureBox.Size.Width)
            {
                errorMsg += ("Прямоугольное окно не вписывается в область рисования по ширине\n");
            }
            if(windowTopLeftY_numericUpDown.Value + windowLength_numericUpDown.Value >= pictureBox.Size.Height)
            {
                errorMsg += ("Прямоугольное окно не вписывается в область рисования по длине\n");
            }
            if (errorMsg != "")
            {
                errorMsgs_richTextBox.SelectionColor = System.Drawing.Color.Red;
                errorMsgs_richTextBox.AppendText(errorMsg);                
            }
            else
            {
                _presenter.SetClippingWindow(
                    windowTopLeftX_numericUpDown.Value, windowTopLeftY_numericUpDown.Value,
                    windowWidth_numericUpDown.Value, windowLength_numericUpDown.Value
                    );
                _presenter.DisplaySegments();
            }
        }
    }
}
