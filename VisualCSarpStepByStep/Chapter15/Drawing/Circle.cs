using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Circle: DrawingShape, IDraw, IColor
    {
        public Circle(int diameter): base(diameter)
        {
            
        }

        public override void Draw(Canvas canvas)
        {
            // 判断是否非空
            if (this.shape is not null)
            {
                // 如果不为空就移除
                canvas.Children.Remove(this.shape);
            }
            else
            {
                // 否则就创建一个新的椭圆实例
                this.shape = new Ellipse();
            }
            
            base.Draw(canvas);
        }
    }
}
