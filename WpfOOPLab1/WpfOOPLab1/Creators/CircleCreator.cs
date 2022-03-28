using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfOOPLab1
{
    public class CircleCreator : EllipsCreator
    {
        public override Shape DrawShape(MyShape myShape)
        {
            return new Ellipse() { Fill = Brushes.Green, Height = myShape.Width, Width = myShape.Width };
        }
        public override MyShape CreateMyShape(int width, int height)
        {
            MyShape myEllipse = new MyCircle(width);
            return myEllipse;
        }
    }
}
