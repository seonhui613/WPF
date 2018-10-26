using System.Windows;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class DPTest : DependencyObject
    {
        public static readonly DependencyProperty TestProperty = DependencyProperty.Register(
            "Test",
            typeof(string),
            typeof(DPTest),
            new PropertyMetadata("Dependency Property Initial Value",
                OnTestPropertyChanged));

        public string Test
        {
            get
            {
                Debug.WriteLine("Test GetValue");
                return (string)GetValue(TestProperty);
            }
            set
            {
                Debug.WriteLine("Test SetValue");
                SetValue(TestProperty, value);
            }
        }
        private static void OnTestPropertyChanged(DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("Property changed : {0}", e.NewValue);
        }

    }
}
