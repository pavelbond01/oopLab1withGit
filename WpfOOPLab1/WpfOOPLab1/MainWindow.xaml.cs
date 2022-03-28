using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfOOPLab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Creator _currentShape;

        private void circleOption_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = new CircleCreator();
        }
        private void ellipseOption_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = new EllipsCreator();
        }

        private void rectOption_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = new RectangleCreator();
        }
        private void squareOption_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = new SquareCreator();
        }
        private void lineOption_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = new LineCreator();
        }

        private void canvasDrawingArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Shape shapeToRender = null;
            //switch (_currentShape)
            //{
            //    case SelectedShape.Circle:
            //        shapeToRender = new Ellipse() { Fill = Brushes.Green, Height = 35, Width = 35 };
            //        break;
            //    case SelectedShape.Rectangle:
            //        shapeToRender = new Rectangle() { Fill = Brushes.Red, Height = 35, Width = 35 };
            //        break;
            //    default:
            //        return;
            //}

            if (int.TryParse(txtHeight.Text, out int height) && int.TryParse(txtWidth.Text, out int width))
            {
                MyShape sameShape = _currentShape.CreateMyShape(width, height);
                shapeToRender = _currentShape.DrawShape(sameShape);

                Canvas.SetLeft(shapeToRender, e.GetPosition(canvasDrawingArea).X);
                Canvas.SetTop(shapeToRender, e.GetPosition(canvasDrawingArea).Y);

                canvasDrawingArea.Children.Add(shapeToRender);
            }
        }

        
    }
}
