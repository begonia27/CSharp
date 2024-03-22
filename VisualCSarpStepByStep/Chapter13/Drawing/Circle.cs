using System.Threading;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;
using Drawing;

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
