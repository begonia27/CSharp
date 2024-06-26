﻿using System;
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
        protected int _x = 0, _y = 0;
        protected Shape shape = null;

        protected DrawingShape(int size)
        {
            this._size = size;
        }

        public int X
        {
            get => this._x;
            set => this._x = value;
        }

        public int Y
        {
            get => this._y;
            set => this._y = value;
        }

        public Color Color
        {
            set
            {
                if (this.shape != null)
                {
                    SolidColorBrush brush = new SolidColorBrush(value);
                    this.shape.Fill = brush;
                }
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

            Canvas.SetTop(this.shape, this._y);
            Canvas.SetLeft(this.shape, this._x);
            canvas.Children.Add(this.shape);
        }
    }
}
