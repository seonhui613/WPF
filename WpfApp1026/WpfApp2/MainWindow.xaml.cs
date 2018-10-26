﻿using System;
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

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Title = "Vary the Background";
            Width = 384;
            Height = 384;
            Background = brush;
    }
        SolidColorBrush brush = Brushes.Black.Clone();

        protected override void OnMouseMove(MouseEventArgs args)
        {
            double width = ActualWidth - 2 * SystemParameters.ResizeFrameVerticalBorderWidth;
            double height = ActualHeight - 2 * SystemParameters.ResizeFrameHorizontalBorderHeight - SystemParameters.CaptionHeight;

            Point ptMouse = args.GetPosition(this);
            Point ptCenter = new Point(width / 2, height / 2);

            Vector vectMouse = ptMouse - ptCenter;
            double angle = Math.Atan2(vectMouse.Y, vectMouse.X);

            Vector vectEllipse = new Vector(width / 2 * Math.Cos(angle),
                                                           height / 2 * Math.Sin(angle));
            Byte byLevel = (byte)(255 * (1 - Math.Min(1, vectMouse.Length / vectEllipse.Length)));

            Color clr = brush.Color;

            clr.R = clr.G = clr.B = byLevel;
            brush.Color = clr;
        }
    }
}