using System.Windows;
using System.Windows.Controls;

namespace WpfDemo
{
    internal class Clicker
    {
        Label _label;
        int _count;
        public StackPanel Panel { get; }

        public Clicker()
        {
            var button = new Button { Content = "Trykk på meg!" };
            button.Click += ButtonClick;
            _label = new Label { Content = "0" };
            Panel = new StackPanel { Orientation = Orientation.Horizontal };
            Panel.Children.Add(button);
            Panel.Children.Add(_label);
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            _count++;
            _label.Content = _count;
        }
    }
}
