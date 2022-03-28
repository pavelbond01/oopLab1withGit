using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfOOPLab1
{
    public class RectangleCreator : Creator
    {
        public override Shape DrawShape(MyShape myShape)
        {
            return new Rectangle() { Fill = Brushes.Red, Height = myShape.Height, Width = myShape.Width };
        }
        public override MyShape CreateMyShape(int width, int height)
        {
            MyShape myRectangle = new MyRectangle(width, height);
            return myRectangle;
        }
    }
}
