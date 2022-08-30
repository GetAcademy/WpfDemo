using System.Windows;
using System.Windows.Controls;

namespace WpfDemo
{
    internal class Clicker2 : StackPanel
    {
        Label _label;
        int _count;

        public Clicker2()
        {
            var button = new Button { Content = "Trykk på meg!" };
            button.Click += ButtonClick;
            _label = new Label { Content = "0" };
            Orientation = Orientation.Horizontal;
            Children.Add(button);
            Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
