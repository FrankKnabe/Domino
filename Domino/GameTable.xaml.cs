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
using System.Windows.Shapes;

namespace Domino
{
    /// <summary>
    /// Interaction logic for GameTable.xaml
    /// </summary>
    public partial class GameTable : Window
    {
        public GameTable(int player, int aiplayer)
        {
            InitializeComponent();

            StackPanel[] sp= new StackPanel[4];
            StackPanel sp1 = new StackPanel();
            StackPanel sp2 = new StackPanel();
            StackPanel sp3 = new StackPanel();
            StackPanel sp4 = new StackPanel();


          
            
            sp2.Name = "Spieler2";
            sp3.Name = "Spieler3";
            sp4.Name = "Spieler4";

            int l = 10;

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
                  Grid.SetRow(sp[i], j);
                  sp[i].Children.Add(new Dominostein());
                }
                Spieltisch.Children.Add(sp[i]);
                l += 350;

                int r = i * 10 + 10;
                int g = i * 15 + 10;
                int b = i * 10 + 10;

                string farbe = "#ff" + r.ToString() + g.ToString() + b.ToString();
                sp[i].Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(farbe));

            }
            /*
            sp[0].Background = new SolidColorBrush(Colors.Yellow);
            sp[1].Background = new SolidColorBrush(Colors.Green);
            sp[2].Background = new SolidColorBrush(Colors.Blue);
            sp[3].Background = new SolidColorBrush(Colors.Red);
            */



            //sp1.RenderTransform = new RotateTransform(90);
            
        }
    }
}
