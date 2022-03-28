using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfOOPLab1
{
    public class MyCircle : MyEllipse
    {
        public MyCircle(int width) : base (width, width) { }

    }
}
