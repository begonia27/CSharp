using System;
using Windows.Devices.Bluetooth;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    abstract class DrawingShape
    {
        protected int _size;
        protected int locX = 0, locY = 0;
        protected Shape shape = null;

        protected DrawingShape(int size)
        {
            this._size = size;
        }

        public void SetLocation(int xCoord, int yCoord)
        {
            this.locX = xCoord;
            this.locY = yCoord;
        }

        public void SetColor(Color color)
        {
            if (this.shape is not null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.shape.Fill = brush;
            }
        }

        public virtual void Draw(Canvas canvas)
        {
            if (this.shape is null)
            {
                throw new InvalidOperationException("Shape is null");
            }

            this.shape.Height = _size;
            this.shape.Width = _size;

            Canvas.SetTop(this.shape, this.locY);
            Canvas.SetLeft(this.shape, this.locX);
            canvas.Children.Add(this.shape);
        }
    }
}
