using System.Windows.Controls;

namespace WpfDemo
{
    internal class ClickerPanel : StackPanel
    {
        public ClickerPanel(int clickerCount)
        {
            for (var i = 0; i < clickerCount; i++)
            {
                Children.Add(new Clicker2());
            }
        }
    }
}
