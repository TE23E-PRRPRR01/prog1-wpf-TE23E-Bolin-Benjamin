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

namespace BrannBollApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    //Skapa variabler för lagen
    int poängInne = 0;
    int poängUte = 0;

    public MainWindow()
    {
        InitializeComponent();

    }

    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {
        //Lägg till 5 poäng
        poängInne += 5;

        //Skriv ut poängen
        txbInne.Text = $"{poängInne}";
    }

    private void KlickBränning(object sender, RoutedEventArgs e)
    {
        poängUte +=2;

        txbUte.Text = $"{poängUte}";
    }

    private void KlickLyra(object sender, RoutedEventArgs e)
    {
        poängUte += 3;
        
        txbUte.Text = $"{poängUte}";
    }

    private void KlickVarv(object sender, RoutedEventArgs e)
    {
        poängInne += 5;

        txbInne.Text = $"{poängInne}";

        //Vad är tiden
        DateTime nu = DateTime.Now;

        //skriv i historiken
        txbHistorik.Text = $"\n {nu.ToString("HH:mm:ss")} Lag inne +5, totalt: {poängInne}";
    }

}