using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int karakterekSzama;
        List<string> betuk = new List<string>();
        List<string> szamok = new List<string>();
        List<string> szimbolumLista = new List<string>();
        string jelszo = "";

        public MainWindow()
        {
            InitializeComponent();
            for (char betu = 'a'; betu <= 'z'; betu++)
            {
                betuk.Add(betu.ToString());
            }
            betuk.Add("á");
            betuk.Add("é");
            betuk.Add("í");
            betuk.Add("ó");
            betuk.Add("ö");
            betuk.Add("ő");
            betuk.Add("ú");
            betuk.Add("ü");
            betuk.Add("ű");
            
            for (int i = 0; i <= 9; i++)
            {
                szamok.Add(i.ToString());
            }

            szimbolumLista.Add("!");
            szimbolumLista.Add("@");
            szimbolumLista.Add("#");
            szimbolumLista.Add("$");
            szimbolumLista.Add("%");
            szimbolumLista.Add("^");
            szimbolumLista.Add("&");
            szimbolumLista.Add("*");
            szimbolumLista.Add("(");
            szimbolumLista.Add(")");
            szimbolumLista.Add("-");
            szimbolumLista.Add("_");
            szimbolumLista.Add("+");
            szimbolumLista.Add("=");
            szimbolumLista.Add("{");
            szimbolumLista.Add("}");
            szimbolumLista.Add("[");
            szimbolumLista.Add("]");
            szimbolumLista.Add(":");
            szimbolumLista.Add(";");
            szimbolumLista.Add("'");
            szimbolumLista.Add("<");
            szimbolumLista.Add(">");
            szimbolumLista.Add(",");
            szimbolumLista.Add(".");
            szimbolumLista.Add("/");
            szimbolumLista.Add("?");
            szimbolumLista.Add("|");

        }
        private void sliHossz_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblHossz.Content = sliHossz.Value;
            karakterekSzama = (int)sliHossz.Value;
        }

        private void btnGeneral_Click(object sender, RoutedEventArgs e)
        {
            jelszo = "";
            Random rnd = new();            
            for (int i = 0; i < karakterekSzama; i++)
            {
                int kituggya = rnd.Next(0, 3);
                if (kituggya == 0)
                {
                jelszo += betuk[rnd.Next(betuk.Count)];
                }
                else if (kituggya == 1)
                {
                    jelszo += betuk[rnd.Next(betuk.Count)].ToUpper();
                }
                else if (kituggya == 2)
                {
                    jelszo += szamok[rnd.Next(szamok.Count)];
                }
                else
                {
                    jelszo += szimbolumLista[rnd.Next(szimbolumLista.Count)];
                }
            }
            lblJelszo.Content = jelszo;
        }
    }
}
