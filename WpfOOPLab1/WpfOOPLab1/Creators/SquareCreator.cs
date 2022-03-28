using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfOOPLab1
{
    public class SquareCreator : RectangleCreator
    {
        public override Shape DrawShape(MyShape myShape)
        {
            return new Rectangle() { Fill = Brushes.Indigo, Height = myShape.Width, Width = myShape.Width };
        }
        public override MyShape CreateMyShape(int width, int height)
        {
            MyShape mySquare = new MySquare(width);
            return mySquare;
        }
    }
}