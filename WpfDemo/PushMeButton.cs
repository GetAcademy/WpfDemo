using System.Windows.Controls;
using System.Windows.Media;

namespace WpfDemo
{
    internal class PushMeButton : Button
    {
        public PushMeButton()
        {
            Content = "Trykk på meg!";
            Background = new SolidColorBrush(Colors.DeepPink);
        }
    }
}
