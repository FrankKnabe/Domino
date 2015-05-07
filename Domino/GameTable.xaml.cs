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
            StackPanel[] sp= new StackPanel[4];

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
                sp[i].Name = "Spieler" + i+1;
                sp[i].HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                sp[i].VerticalAlignment = System.Windows.VerticalAlignment.Top;
                sp[i].Height = 100;
                sp[i].Width = 230;
                
                //Hinzufügen eines Grids, indem die Spielsteine hinzugefügt werden sollen. Dabei werden
                //sie zufällig aus der Listen gezogen und entsprechend auch aus der Liste gelöscht
                for (int j = 0; j < 5; j++)
                {
                  Grid.SetRow(sp[i], j);
                  zufallszahl = rnd.Next(0, DStein.Count);
                  sp[i].Children.Add(DStein[zufallszahl]);
                  DStein.RemoveAt(zufallszahl);
                }

                //Die Spielfläche/StackPanel werden am Spieltisch angebracht 
                Spieltisch.Children.Add(sp[i]);
                //Die Position der nächsten Spielfläche wird bestimmt
                l += 350;

                //Hier sollten die Farben der Spielflächen dynamisch erstellt werden, da aber das Ergebnis
                //unbefriedigend war, wurde diese Idee erst einmal verworfen
                int r = (i + 1) * 50 + 10;
                int g = i * 50 + 50;
                int b = i * 50 + 20;

                string hexzahl = r.ToString("X") + g.ToString("X") + b.ToString("X");

                string farbe = "#ff" + hexzahl.ToString();
                sp[i].Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(farbe));

            }
            //Statische Farbzuweisung der Spielflächen
            //sp[0].Background = new SolidColorBrush(Colors.Yellow);
            //sp[1].Background = new SolidColorBrush(Colors.Green);
            //sp[2].Background = new SolidColorBrush(Colors.Blue);
            //sp[3].Background = new SolidColorBrush(Colors.DarkRed);

            //sp1.RenderTransform = new RotateTransform(90);
            
        }
    }
}
