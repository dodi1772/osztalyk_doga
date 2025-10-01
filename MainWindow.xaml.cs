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
			diakNev.Focus();
		}

		private void hozzClick(object sender, RoutedEventArgs e)
		{
			if (int.TryParse(befizetettMennyiseg.Text, out _)==false)
			{
                MessageBox.Show("Kérlek a befizetett mennyiség mezőbe számot írj csak.");
			}
            else
            {
				string[] nevSzam= diakNev.Text.Split(" ");
				if (nevSzam.Length>1)
				{

					int befizSzam = int.Parse(befizetettMennyiseg.Text);
					if (befizSzam<0)
					{
						MessageBox.Show("Csak nemnegatív számot adj meg.");
					}
					else
					{
						diakLista.Items.Add($"{diakNev.Text} - {befizSzam} Ft");
						osszpenz += befizSzam;
						osszBefizetett.Text = $"{osszpenz} Ft";
					}
				}
				else
				{
					MessageBox.Show("Kérlek a név mezőbe írj legalább egy kereszt és egy vezeték nevet.");
				}

			}
		}

		private void ceClick(object sender, RoutedEventArgs e)
		{
			diakLista.Items.Clear();
			osszpenz = 0;
			osszBefizetett.Text = "0 Ft";
		}

		private void cClick(object sender, RoutedEventArgs e)
		{
			diakNev.Text = "";
			befizetettMennyiseg.Text = "";
		}

		private void kijButtClick(object sender, RoutedEventArgs e)
		{
			if (diakLista.SelectedItem!=null)
			{
				string[] sor = diakLista.SelectedItem.ToString().Split(" ");
				osszpenz -= int.Parse(sor[3]);
				osszBefizetett.Text = $"{osszpenz} Ft";
				diakLista.Items.Remove(diakLista.SelectedItem);
			}
			else
			{
				MessageBox.Show("Kérlek jelölj ki egy elemet a listából.");
			}
		}
	}
}