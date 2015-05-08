using System;
using System.Collections;
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
using System.Windows.Shapes;

namespace Domino
{
    /// <summary>
    /// Interaction logic for GameTable.xaml
    /// </summary>
    public partial class GameTable : Window
    {
        public GameTable(int player)
        {
            InitializeComponent();
            //Initialisierung der Variabeln
            //Die StackPanel dienen als Spielflächen, erstmal für maximal 4 Spieler
            StackPanel[] sp= new StackPanel[player];

            int ObereAugenzahl = 0;
            int UntereAugenzahl = 0;

            int zufallszahl;
            Random rnd = new Random();


            List <Dominostein> DStein= new List<Dominostein>();

            //Erstellen der oberen und unteren Augenzahl des Dominosteins, anschließend werden diese
            //der Klasse Dominostein zugewiesen und in eine Liste gepackt
            for (int o = 0; o < 10; o++)
            {
                for (int u = 0; u <= o; u++)
                {
                    ObereAugenzahl = o;
                    UntereAugenzahl = u;
                    DStein.Add(new Dominostein(ObereAugenzahl, UntereAugenzahl));
                }
            }

            //Positionsvariabel für die Position von links aus gesehen
            int l = 0;

            //Erstellung des StackPanel-Arrays für die Spielflächen der 4 Spieler
            for (int i = 0; i < player; i++)
            {
                sp[i] = new StackPanel();
                Canvas.SetLeft(sp[i], l);
                Canvas.SetTop(sp[i], 10);
                sp[i].Orientation = Orientation.Horizontal;
                sp[i].Name = String.Format("Spieler_{0}",i+1);
                sp[i].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                sp[i].VerticalAlignment = System.Windows.VerticalAlignment.Top;
                sp[i].Height = 100;
                sp[i].Width = 230;
                sp[i].Visibility = Visibility.Hidden;
                
                //Hinzufügen eines Grids, indem die Spielsteine hinzugefügt werden sollen. Dabei werden
                //sie zufällig aus der Listen gezogen und entsprechend auch aus der Liste gelöscht
                for (int j = 0; j < 5; j++)
                {
                    Grid.SetRow(sp[i], j);
                    zufallszahl = rnd.Next(0, DStein.Count);
                    sp[i].Children.Add(DStein[zufallszahl]);
                    Label lblPlayer = new Label();
                    Canvas.SetLeft(lblPlayer, l);
                    Canvas.SetTop(lblPlayer, 120);
                    lblPlayer.FontSize = 18;
                    lblPlayer.Content = "Spieler " + (i+1); 
                    Spieltisch.Children.Add(lblPlayer);
                    DStein.RemoveAt(zufallszahl);
                }

                //Die Spielfläche/StackPanel werden am Spieltisch angebracht 
                Spieltisch.Children.Add(sp[i]);
                //Die Position der nächsten Spielfläche wird bestimmt
                l += 350;
                string farbe = "";

                //Hier werden die Farben der Spielflächen dynamisch erstellt
                switch (i)
                {
                     case 0:
                        farbe = "#0000FF";
                        break;
                    case 1:
                        farbe = "#EEEE00";
                        break;
                    case 2:
                        farbe = "#008B00";
                        break;
                    case 3:
                        farbe = "#8B0000";
                        break;

                }

                sp[i].Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(farbe));


            }

            //Das Feld für den ersten Spielstein wird erzeugt
            StackPanel Ausgangsfeld = new StackPanel();
            Canvas.SetLeft(Ausgangsfeld, 585);
            Canvas.SetTop(Ausgangsfeld, 490);
            Ausgangsfeld.Orientation = Orientation.Horizontal;
            Ausgangsfeld.Width = 90;
            Ausgangsfeld.Height = 50;
            Ausgangsfeld.HorizontalAlignment = HorizontalAlignment.Left;
            Ausgangsfeld.VerticalAlignment = VerticalAlignment.Top;
            Ausgangsfeld.Background = new SolidColorBrush(Colors.Gray);
            Spieltisch.Children.Add(Ausgangsfeld);

            //Der Anfangsspielstein wird auf das Spielfeld platziert
            zufallszahl = rnd.Next(0, DStein.Count);
            Canvas.SetLeft(DStein[zufallszahl], 585);
            Canvas.SetTop(DStein[zufallszahl], 490);
            DStein[zufallszahl].LayoutTransform = new RotateTransform(90);
            Spieltisch.Children.Add(DStein[zufallszahl]);
            DStein.RemoveAt(zufallszahl);

            //Ein Stapel-Objekt wird erzeugt, das beim Anklicken einen neuen Spielstein aus der Liste zieht
            Dominostein Stapel = new Dominostein(0,0);
            Canvas.SetLeft(Stapel, 4);
            Canvas.SetTop(Stapel, 490);
            Spieltisch.Children.Add(Stapel);
            Label lblStapel = new Label();
            lblStapel.FontSize = 14;
            lblStapel.FontWeight = FontWeights.Bold;
            lblStapel.Content = "Stapel";
            Canvas.SetLeft(lblStapel, 4);
            Canvas.SetTop(lblStapel, 450);
            Spieltisch.Children.Add(lblStapel);

            //Anfangsspieler wird ermittelt
            int aktiverSpieler = 0;
            int maxWert = 0;
            for (int z = 0; z < sp.Count(); z++)
            {
                
                foreach(Dominostein spielstein in sp[z].Children)
                {
                    if (spielstein.ObereAugenzahl == spielstein.UntereAugenzahl)
                    {
                        int gesamtaugenzahl = spielstein.ObereAugenzahl + spielstein.UntereAugenzahl;
                        if (gesamtaugenzahl > maxWert)
                        {
                            maxWert = gesamtaugenzahl;
                            aktiverSpieler = z;
                        }

                    }

                }

            }
            sp[aktiverSpieler].Visibility = Visibility.Visible;
        }
    }
}
