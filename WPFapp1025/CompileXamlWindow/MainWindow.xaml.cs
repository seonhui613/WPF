using System;
using System.Reflection;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows.Controls;


namespace CompileXamlWindow
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (PropertyInfo prop in typeof(Brushes).GetProperties())
                lstbox.Items.Add(prop.Name);
        }
        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            Button b = sender as Button;
            MessageBox.Show(b.Content.ToString());
        }
        void ListBoxOnSelection(object sender, SelectionChangedEventArgs args)
        {
            ListBox listBox = sender as ListBox;
            string items = listBox.SelectedItem as string;
            PropertyInfo plnfo = typeof(Brushes).GetProperty(items);
            elips.Fill = (Brush)plnfo.GetValue(null, null);
        }
    }

}
