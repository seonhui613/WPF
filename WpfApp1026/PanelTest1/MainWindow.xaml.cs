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

namespace PanelTest1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Panel Test1";

            SizeToContent = SizeToContent.WidthAndHeight;
            ResizeMode = ResizeMode.CanResize;

            StackPanel stack1 = new StackPanel();
            stack1.Orientation = Orientation.Horizontal;
            stack1.Margin = new Thickness(5);
            Content = stack1;

            Random rand = new Random();
            for(int i = 0; i<4; i++)
            {
                Button btn = new Button();
                btn.Name = ((char)('A' + i)).ToString();
                btn.FontSize += rand.Next(10);
                btn.Content = "Button" + btn.Name + "says 'Click me'";
                btn.Click += ButtonOnClick;
                stack1.Children.Add(btn);
            }
            StackPanel stack2 = new StackPanel();
            stack1.Children.Add(stack2);

            stack2.AddHandler(Button.ClickEvent, new RoutedEventHandler(ButtonOnClick2));
            Button b = new Button();
            b.Name = "MyButton";
            b.Content = "MyButton";
            b.FontSize = 32;
            stack2.Children.Add(b);
        }

        private void ButtonOnClick2(object sender, RoutedEventArgs args)
        {
            Button btn = args.Source as Button;
            MessageBox.Show("Button " + btn.Name + "has been clicked", "ButtonClick");
        }

        private void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            Button btn = args.Source as Button;
            MessageBox.Show("Button " + btn.Name + " has been clicked",
 "Button Click");        }
    }
}
