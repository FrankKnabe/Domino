using System;
using System.Collections.Generic;
using System.Collections;
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

namespace Domino
{
    /// <summary>
    /// Interaction logic for Dominostein.xaml
    /// </summary>
    public partial class Dominostein : UserControl
    {
        int _UnterAugenzahl = 0;
        int _ObereAugenzahl = 0;
        public Dominostein()
        {
            InitializeComponent();
        }
        public Dominostein(int ObereAugenzahl, int UntereAugenzahl)
        {
            InitializeComponent();
            InitDominostein(ObereAugenzahl, UntereAugenzahl);
        }
        public void InitDominostein(int ObereAugenzahl, int UntereAugenzahl)
        {
            //InitializeComponent();

            Border BorderRot = new Border();
            Border BorderSchwarz = new Border();

            BorderRot.HorizontalAlignment = HorizontalAlignment.Left;
            BorderSchwarz.HorizontalAlignment = HorizontalAlignment.Left;
            BorderRot.Height = 40;
            BorderSchwarz.Height = 40;
            BorderRot.VerticalAlignment = VerticalAlignment.Top;
            BorderSchwarz.VerticalAlignment = VerticalAlignment.Top;
            BorderRot.Width = 40;
            BorderSchwarz.Width = 40;
            BorderRot.BorderBrush = System.Windows.Media.Brushes.Red;
            BorderSchwarz.BorderBrush = System.Windows.Media.Brushes.Black;
            BorderRot.BorderThickness = new Thickness(2);
            BorderSchwarz.BorderThickness = new Thickness(2);
            BorderRot.Margin = new Thickness(0,0,0,0);
            BorderSchwarz.Margin = new Thickness(0,40,0,0);

            Grid GridRot = new Grid();
            Grid GridSchwarz = new Grid();

            GridRot.Height = 44;
            GridSchwarz.Height = 44;
            GridRot.Width = 44;
            GridSchwarz.Width = 44;

            ColumnDefinition[] colDef = new ColumnDefinition[3];
            RowDefinition[] rowDef = new RowDefinition[3];

            for (int i = 0; i < 3; i++)
            {
                colDef[i] = new ColumnDefinition();
                rowDef[i] = new RowDefinition();
                GridRot.ColumnDefinitions.Add(colDef[i]);
                GridRot.RowDefinitions.Add(rowDef[i]);

                GridSchwarz.ColumnDefinitions.Add(new ColumnDefinition());
                GridSchwarz.RowDefinitions.Add(new RowDefinition());
            }

            Ellipse RoteEllipse = new Ellipse();
            Ellipse SchwarzeEllipse = new Ellipse();


                RoteEllipse.Fill = System.Windows.Media.Brushes.Red;
                SchwarzeEllipse.Fill = System.Windows.Media.Brushes.Black;
                RoteEllipse.HorizontalAlignment = HorizontalAlignment.Center;
                SchwarzeEllipse.HorizontalAlignment = HorizontalAlignment.Center;
                RoteEllipse.Height = 5;
                SchwarzeEllipse.Height = 5;
                RoteEllipse.Stroke = System.Windows.Media.Brushes.Red;
                SchwarzeEllipse.Stroke = System.Windows.Media.Brushes.Black;
                RoteEllipse.VerticalAlignment = VerticalAlignment.Center;
                SchwarzeEllipse.VerticalAlignment = VerticalAlignment.Center;
                RoteEllipse.Width = 5;
                SchwarzeEllipse.Width = 5;
                //RoteEllipse.Visibility = Visibility.Hidden;
                //SchwarzeEllipse.Visibility = Visibility.Hidden;



                switch (ObereAugenzahl)
                {
                    case 1:
                        Grid.SetColumn(RoteEllipse, 1);
                        Grid.SetRow(RoteEllipse, 1);

                        GridRot.Children.Add(RoteEllipse);
                        break;
                    case 2:
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 2);

                        GridRot.Children.Add(RoteEllipse);
                        break;
                    case 3:
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 1);
                        Grid.SetRow(RoteEllipse, 1);

                        GridRot.Children.Add(RoteEllipse);
                        break;
                    case 4:
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 2);

                        GridRot.Children.Add(RoteEllipse);
                        break;
                    case 5:
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 1);
                        Grid.SetRow(RoteEllipse, 1);


                        GridRot.Children.Add(RoteEllipse);
                        break;
                    case 6:
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 1);
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 1);

                        GridRot.Children.Add(RoteEllipse);
                        break;
                    case 7:
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 1);
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 1);
                        Grid.SetColumn(RoteEllipse, 1);
                        Grid.SetRow(RoteEllipse, 1);

                        GridRot.Children.Add(RoteEllipse);
                        break;
                    case 8:
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 1);
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 1);
                        Grid.SetColumn(RoteEllipse, 1);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 1);
                        Grid.SetRow(RoteEllipse, 0);

                        GridRot.Children.Add(RoteEllipse);
                        break;
                    case 9:
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 2);
                        Grid.SetRow(RoteEllipse, 1);
                        Grid.SetColumn(RoteEllipse, 0);
                        Grid.SetRow(RoteEllipse, 1);
                        Grid.SetColumn(RoteEllipse, 1);
                        Grid.SetRow(RoteEllipse, 2);
                        Grid.SetColumn(RoteEllipse, 1);
                        Grid.SetRow(RoteEllipse, 0);
                        Grid.SetColumn(RoteEllipse, 1);
                        Grid.SetRow(RoteEllipse, 1);

                        GridRot.Children.Add(RoteEllipse);
                        break;
                }

                switch (UntereAugenzahl)
                {
                    case 1:
                        Grid.SetColumn(SchwarzeEllipse, 1);
                        Grid.SetRow(SchwarzeEllipse, 1);

                        GridSchwarz.Children.Add(SchwarzeEllipse);
                        break;
                    case 2:
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 2);

                        GridSchwarz.Children.Add(SchwarzeEllipse);
                        break;
                    case 3:
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 1);
                        Grid.SetRow(SchwarzeEllipse, 1);

                        GridSchwarz.Children.Add(SchwarzeEllipse);
                        break;
                    case 4:
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 2);

                        GridSchwarz.Children.Add(SchwarzeEllipse);
                        break;
                    case 5:
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 1);
                        Grid.SetRow(SchwarzeEllipse, 1);


                        GridSchwarz.Children.Add(SchwarzeEllipse);
                        break;
                    case 6:
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 1);
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 1);

                        GridSchwarz.Children.Add(SchwarzeEllipse);
                        break;
                    case 7:
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 1);
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 1);
                        Grid.SetColumn(SchwarzeEllipse, 1);
                        Grid.SetRow(SchwarzeEllipse, 1);

                        GridSchwarz.Children.Add(SchwarzeEllipse);
                        break;
                    case 8:
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 1);
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 1);
                        Grid.SetColumn(SchwarzeEllipse, 1);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 1);
                        Grid.SetRow(SchwarzeEllipse, 0);

                        GridSchwarz.Children.Add(SchwarzeEllipse);
                        break;
                    case 9:
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 2);
                        Grid.SetRow(SchwarzeEllipse, 1);
                        Grid.SetColumn(SchwarzeEllipse, 0);
                        Grid.SetRow(SchwarzeEllipse, 1);
                        Grid.SetColumn(SchwarzeEllipse, 1);
                        Grid.SetRow(SchwarzeEllipse, 2);
                        Grid.SetColumn(SchwarzeEllipse, 1);
                        Grid.SetRow(SchwarzeEllipse, 0);
                        Grid.SetColumn(SchwarzeEllipse, 1);
                        Grid.SetRow(SchwarzeEllipse, 1);

                        GridSchwarz.Children.Add(SchwarzeEllipse);
                        break;
                }

                //BorderRot.IsAncestorOf(GridRot);
                //BorderSchwarz.IsAncestorOf(GridSchwarz);
                stein.Children.Add(BorderRot);
                stein.Children.Add(BorderSchwarz);
        }

        public int ObereAugenzahl {
            get { return _ObereAugenzahl; }
            set { _ObereAugenzahl = value; InitDominostein(value, UntereAugenzahl); }
        }

        public int UntereAugenzahl { 
            get{ return _UnterAugenzahl;}
            set { _UnterAugenzahl = value; InitDominostein(ObereAugenzahl, value); }
        }

    }
}
