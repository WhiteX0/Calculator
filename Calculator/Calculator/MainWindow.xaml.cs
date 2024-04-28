using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow : Window
    {

        double numb1;
        double numb2;
        char op;
        double ergebnis;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            textbox.Text += btn.Content.ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = "";
        }

        private void multiplikation_Click(object sender, RoutedEventArgs e)
        {
            ergebnis = numb1 * numb2;
        }
    }
}
