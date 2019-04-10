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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Rectangle myRect = new Rectangle();
            myRect.Height = 100;
            myRect.Width = 100;
            myRect.Fill = Brushes.Red;
            myRect.Stroke = Brushes.Black;
            myRect.StrokeThickness = 2;
            Canvas.SetLeft(myRect, 100);
            Canvas.SetTop(myRect, 100);
            myCanvas.Children.Add(myRect);
     
            
            Diamond myDiam = new Diamond();
            myDiam.Height = 250;
            myDiam.Width = 100;
            myDiam.Fill = Brushes.Blue;
            myDiam.Stroke = Brushes.LightGreen;
            myDiam.StrokeThickness = 10;
            Canvas.SetLeft(myDiam, 250);
            Canvas.SetTop(myDiam, 350);
            myCanvas.Children.Add(myDiam);

            Diamond D2 = new Diamond();
            D2.Height = 150;
            D2.Width = 100;
            D2.Fill = Brushes.Magenta;
            D2.Stroke = Brushes.LightBlue;
            D2.StrokeThickness = 15;
            Canvas.SetLeft(D2, 400);
            Canvas.SetTop(D2, 200);
            myCanvas.Children.Add(D2);

           

            Diamond D4 = new Diamond();
            D4.Height = 100;
            D4.Width = 100;
            D4.Fill = Brushes.White;
            D4.Stroke = Brushes.Black;
            D4.StrokeThickness = 15;
            Canvas.SetLeft(D4, 500);
            Canvas.SetTop(D4, 500);
            myCanvas.Children.Add(D4);

            Triangle T1 = new Triangle();
            T1.Height = 100;
            T1.Width = 100;
            T1.Fill = Brushes.LightGoldenrodYellow;
            T1.Stroke = Brushes.DarkCyan;
            T1.StrokeThickness = 15;
            Canvas.SetLeft(T1, 450);
            Canvas.SetTop(T1, 450);
            myCanvas.Children.Add(T1);


        }
    }
}
