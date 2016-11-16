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

namespace WpfApplication7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            CreateLines();
        }

        public void CreateLines()
        {
            double opacityVal = 0.0;


            for (double i = 0; i < 360; i += 0.5)
            {
                Line sweepLine = new Line();
                sweepLine.X1 = 197.0;
                sweepLine.Y1 = 186.0;
                sweepLine.X2 = 120.0;
                sweepLine.Y2 = 120.0;
                sweepLine.Stroke = new SolidColorBrush(Colors.Black);
                sweepLine.StrokeThickness = 1.0;
                sweepLine.RenderTransformOrigin = new Point(0.5, 0.5);
                sweepLine.Opacity = opacityVal;
                opacityVal += 0.00138;

                TransformGroup xformGroup = new TransformGroup();
                RotateTransform rotateXform = new RotateTransform(i);
                ScaleTransform scaleXform = new ScaleTransform();
                SkewTransform skewXform = new SkewTransform();
                TranslateTransform translateXform = new TranslateTransform();

                xformGroup.Children.Add(scaleXform);
                xformGroup.Children.Add(skewXform);
                xformGroup.Children.Add(rotateXform);
                xformGroup.Children.Add(translateXform);

                sweepLine.RenderTransform = xformGroup;

                appGrid.Children.Add(sweepLine);
            }
        }
    }
}
