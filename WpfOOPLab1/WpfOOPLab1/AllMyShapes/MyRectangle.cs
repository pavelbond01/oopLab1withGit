using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfOOPLab1
{
    public class MyRectangle: MyShape
    {
        public MyRectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
