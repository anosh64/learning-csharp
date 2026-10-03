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

namespace downcastingScenario
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(
            //    "installed a horrific malware that will absolutely annihilate your system to the extent you will want to self-annihilate.");
            var button = sender as Button; // downcasting!!
            button.FontSize = 50.75;

            if (button != null)
            {
                MessageBox.Show(button.ActualHeight.ToString());
            }
        }
    }
}