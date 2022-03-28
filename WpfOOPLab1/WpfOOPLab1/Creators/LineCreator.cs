using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfOOPLab1
{
    public class LineCreator : Creator
    {
        public override Shape DrawShape(MyShape myShape)
        {
            return new Line() { Stroke = Brushes.Black, StrokeThickness = 10, X2 = myShape.Width, Y2 = myShape.Height };
        }
        public override MyShape CreateMyShape(int width, int height)
        {
            MyShape myLine = new MyLine(width, height);
            return myLine;
        }
    }
}
