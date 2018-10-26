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

namespace EventRoutingTest2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string mouseActivity = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_PriviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseActivity = "PMD Window \n";
            MessageBox.Show(mouseActivity);
        }

        private void Button_PriviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseActivity = "PMD Button \n";
            MessageBox.Show(mouseActivity);
        }

        private void StackPanel_PriviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseActivity = "PMDs StackPanel \n";
            MessageBox.Show(mouseActivity);
        }
    }
}
