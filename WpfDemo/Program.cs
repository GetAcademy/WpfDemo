using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfDemo
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var clicker1 = new Clicker2();
            var clicker2 = new Clicker2();
            var clicker3 = new Clicker2();

            var panel = new StackPanel();
            panel.Children.Add(clicker1);
            panel.Children.Add(clicker2);
            panel.Children.Add(clicker3);            
            
            //var clicker1 = new Clicker();
            //var clicker2 = new Clicker();
            //var clicker3 = new Clicker();

            //var panel = new StackPanel();
            //panel.Children.Add(clicker1.Panel);
            //panel.Children.Add(clicker2.Panel);
            //panel.Children.Add(clicker3.Panel);

            window.Content = panel;
            app.Run(window);
        }

        /*
         * v1:
        static Label _label;
        static int _count;

        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            var button = new Button { Content = "Trykk på meg!" };
            button.Click += ButtonClick;
            _label = new Label { Content = "0" };
            var panel = new StackPanel { Orientation = Orientation.Horizontal };
            panel.Children.Add(button);
            panel.Children.Add(_label);
            window.Content = panel;
            app.Run(window);
        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }         
         */
    }
}
