using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfOOPLab1
{
    public class EllipsCreator : Creator
    {
        public override Shape DrawShape(MyShape myShape)
        {
            return new Ellipse() { Fill = Brushes.Gold, Height = myShape.Height, Width =myShape.Width };          
        }
        public override MyShape CreateMyShape(int width, int height)
        {
            MyShape myEllipse = new MyEllipse(width, height);
            return myEllipse;
        }
    }
}
