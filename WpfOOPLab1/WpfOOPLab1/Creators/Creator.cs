using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfOOPLab1
{
    public abstract class Creator
    {
        public abstract Shape DrawShape(MyShape myShape);
        public abstract MyShape CreateMyShape(int width, int height);
    }
}
