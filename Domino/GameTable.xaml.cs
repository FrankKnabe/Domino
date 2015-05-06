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

            StackPanel[] sp= new StackPanel[4];

            ArrayList ObereSteinHälfte = new ArrayList(10);
            ArrayList UntereSteinHälfte = new ArrayList(10);

            int ObereAugenzahl = 0;
            int UntereAugenzahl = 0;

            int zufallszahl;
            Random rnd = new Random();


            for (int i = 0; i < 10; i++)
            {
                ObereSteinHälfte.Add(i);
                UntereSteinHälfte.Add(i);
            }

            List <Dominostein> DStein= new List<Dominostein>();

            for (int o = 0; o < ObereSteinHälfte.Count; o++)
            {
                for (int u = 0; u < UntereSteinHälfte.Count; u++)
                {
                    ObereAugenzahl = Convert.ToInt32(ObereSteinHälfte[o]);
                    UntereAugenzahl = Convert.ToInt32(UntereSteinHälfte[u]);

                    DStein.Add(new Dominostein(ObereAugenzahl, UntereAugenzahl));

                }
            }

            int l = 0;

            //sp2.Children.Add(ds);
            //Grid.SetRow(sp1, 0);

            for (int i = 0; i < 4; i++)
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
                
                for (int j = 0; j < 5; j++)
                {
                  Grid.SetRow(sp[i],j);
                  zufallszahl = rnd.Next(0, DStein.Count);
                  sp[i].Children.Add(DStein[zufallszahl]);
                  DStein.RemoveAt(zufallszahl);
                }


                Spieltisch.Children.Add(sp[i]);
                l += 350;

                //int r = i * 25 + 100;
                //int g = i * 27 + 100;
                //int b = i * 25 + 100;

                //string hexzahl = r.ToString("X") + g.ToString("X") + b.ToString("X");

                //MessageBox.Show(hexzahl);

                //string farbe = "#ff" + hexzahl.ToString();
                //sp[i].Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(farbe));

            }

            sp[0].Background = new SolidColorBrush(Colors.Yellow);
            sp[1].Background = new SolidColorBrush(Colors.Green);
            sp[2].Background = new SolidColorBrush(Colors.Blue);
            sp[3].Background = new SolidColorBrush(Colors.DarkRed);

            //sp1.RenderTransform = new RotateTransform(90);
            
        }
    }
}
