using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStylesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Style styleRed = new Style();
            styleRed.Setters.Add(
                new Setter()
                {
                    Property = Control.FontSizeProperty,
                    Value = 30.0
                });
            styleRed.Setters.Add(
                new Setter()
                {
                    Property = Control.BackgroundProperty,
                    Value = new SolidColorBrush(Colors.DarkRed)
                });
            styleRed.Setters.Add(
                new Setter()
                {
                    Property = Control.ForegroundProperty,
                    Value = new SolidColorBrush(Colors.White)
                });
            styleRed.Setters.Add(new EventSetter()
            {
                Event = Button.ClickEvent,
                Handler = new RoutedEventHandler( Button_Click )
            });

            Button btn3 = new Button() { Content = "Click me 3" };
            btn3.Style = styleRed;

            //stack.Children.Add(btn3);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (sender as Button).Content.ToString();
            MessageBox.Show($"Press button {str}");
        }
    }
}