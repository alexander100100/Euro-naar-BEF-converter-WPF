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

namespace oefening1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // global variables
        // constanten
        const double EXCHANGE_RATE = 40.3399;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        { // inlezen user value
            double euro = double.Parse(euroTextBox.Text);

            // converten
            double bef = euro * EXCHANGE_RATE;

            // uitlezen
            BEFTextBox.Text = bef.ToString("F2");
        }

        private void wissenButton_Click(object sender, RoutedEventArgs e)
        {
            // alle textboxen terug op '0' zetten
            euroTextBox.Text = 0.ToString();
            BEFTextBox.Text = 0.ToString();
        }
    }
}

        