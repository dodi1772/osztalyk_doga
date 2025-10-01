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

namespace osztalyk_doga
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int osszpenz = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

		private void hozzClick(object sender, RoutedEventArgs e)
		{
            diakLista.Items.Add($"{diakNev.Text + " - " + befizetettMennyiseg + " Ft"}");

		}
	}
}