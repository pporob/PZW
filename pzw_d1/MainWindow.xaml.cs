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

namespace pzw_d1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _selectedIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Left.Click += new RoutedEventHandler(Left_Click);
            this.Right.Click += new RoutedEventHandler(Right_Click);
        }

        void Left_Click(object sender, RoutedEventArgs e)
        {
            AddOrangeRectangle();
        }
        void Right_Click(object sender, RoutedEventArgs e)
        {
            AddRedRectangle();
        }


        void AddRedRectangle()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 350;
            rectangle.Height = 50;
            rectangle.Margin = new Thickness(10);
            rectangle.Fill = Brushes.Red;
            rectangle.Stroke = Brushes.Black;

            this.RedRectangleContainer.Children.Add(rectangle);
        }

        void AddOrangeRectangle()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 100;
            rectangle.Height = 100;
            rectangle.Margin = new Thickness(10);
            rectangle.Fill = Brushes.Orange;

            this.OrangeRectangleContainer.Children.Add(rectangle);
        }

    }

}
