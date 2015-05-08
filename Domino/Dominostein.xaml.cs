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
        public Dominostein(int OAugenzahl, int UAugenzahl)
        {
            //Konstruktor für den Dominostein, die Augenzahlen als Parameter übergeben
            //int AugenOben = ObereAugenzahl;
            ObereAugenzahl = OAugenzahl;
            UntereAugenzahl = UAugenzahl;
            InitializeComponent();
            InitDominostein(ObereAugenzahl, UntereAugenzahl);
        }
        public void InitDominostein(int ObereAugenzahl, int UntereAugenzahl)
        {
            //InitializeComponent();
            //Der Rahmen der obere und untere Hälfte des Spielsteines
            Border BorderRot = new Border();
            Border BorderSchwarz = new Border();

            BorderRot.HorizontalAlignment = HorizontalAlignment.Left;
            BorderSchwarz.HorizontalAlignment = HorizontalAlignment.Left;
            BorderRot.Height = 45;
            BorderSchwarz.Height = 45;
            BorderRot.VerticalAlignment = VerticalAlignment.Top;
            BorderSchwarz.VerticalAlignment = VerticalAlignment.Top;
            BorderRot.Width = 45;
            BorderSchwarz.Width = 45;
            BorderRot.BorderBrush = System.Windows.Media.Brushes.Red;
            BorderSchwarz.BorderBrush = System.Windows.Media.Brushes.Black;
            BorderRot.BorderThickness = new Thickness(2);
            BorderSchwarz.BorderThickness = new Thickness(2);
            BorderRot.Margin = new Thickness(0,0,0,0);
            BorderSchwarz.Margin = new Thickness(0,45,0,0);

            //Erstellung der Gitterfelder für die Punkte, die die Augenzahlen repräsentieren
            Grid GridRot = new Grid();
            Grid GridSchwarz = new Grid();

            GridRot.Height = 40;
            GridSchwarz.Height = 40;
            GridRot.Width = 40;
            GridSchwarz.Width = 40;
            //GridRot.is

            //Die Reihen und Zeilen, die ein 3x3 Gitterfeld erzeugen
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


            //Switch-Case-Anweisung für dynamische Erzeugung der Augenzahl, die der Klasse aus der
            //Liste der Dominosteine zugewiesen wird. Die Punkte bekommen eine Position im Gitterfeld
            //und werden dann dem Grid hinzugefügt
                switch (ObereAugenzahl)
                {
                    case 1:
                        setCell(GridRot, 1, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        break;
                    case 2:
                        setCell(GridRot, 0, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        break;
                    case 3:
                        setCell(GridRot, 0, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 1, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        break;
                    case 4:
                        setCell(GridRot, 0, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 0, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        break;
                    case 5:
                        setCell(GridRot, 0, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 0, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 1, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        break;
                    case 6:
                        setCell(GridRot, 0, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 0, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 0, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        break;
                    case 7:
                        setCell(GridRot, 0, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 0, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 0, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 1, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        break;
                    case 8:
                        setCell(GridRot, 0, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 0, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 0, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 1, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 1, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        break;
                    case 9:
                        setCell(GridRot, 0, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 0, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 2, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 0, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 1, 2, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 1, 0, createEllipse(System.Windows.Media.Brushes.Red));
                        setCell(GridRot, 1, 1, createEllipse(System.Windows.Media.Brushes.Red));
                        break;
                }

                switch (UntereAugenzahl)
                {
                    case 1:
                        setCell(GridSchwarz, 1, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        break;
                    case 2:
                        setCell(GridSchwarz, 0, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        break;
                    case 3:
                        setCell(GridSchwarz, 0, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 1, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        break;
                    case 4:
                        setCell(GridSchwarz, 0, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 0, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        break;
                    case 5:
                        setCell(GridSchwarz, 0, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 0, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 1, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        break;
                    case 6:
                        setCell(GridSchwarz, 0, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 0, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 0, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        break;
                    case 7:
                        setCell(GridSchwarz, 0, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 0, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 0, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 1, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        break;
                    case 8:
                        setCell(GridSchwarz, 0, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 0, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 0, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 1, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 1, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        break;
                    case 9:
                        setCell(GridSchwarz, 0, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 0, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 2, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 0, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 1, 2, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 1, 0, createEllipse(System.Windows.Media.Brushes.Black));
                        setCell(GridSchwarz, 1, 1, createEllipse(System.Windows.Media.Brushes.Black));
                        break;
                }

                //Das Gitterfeld wird dem Rahmen zugefügt und der Rahmen dem Spielstein    
                BorderRot.Child = GridRot;
                BorderSchwarz.Child = GridSchwarz;
                stein.Children.Add(BorderRot);
                stein.Children.Add(BorderSchwarz);
                
        }

        //Methode zur Bestimmung der Position des Punktes für die Augenzahlen
        private static void setCell(Grid grid, int column, int row, Ellipse ellipse)
        {
            Grid.SetColumn(ellipse, column);
            Grid.SetRow(ellipse, row);

            grid.Children.Add(ellipse);
        }

        //Erstellung eines Punktes, der die Augenzahl repräsentieren soll
        private static Ellipse createEllipse(SolidColorBrush farbe)
        {
            Ellipse ellipse = new Ellipse();

            ellipse.Fill = farbe;
            ellipse.HorizontalAlignment = HorizontalAlignment.Center;
            ellipse.Height = 5;
            ellipse.Stroke = farbe;
            ellipse.VerticalAlignment = VerticalAlignment.Center;
            ellipse.Width = 5;
            return ellipse;
        }

        public int ObereAugenzahl {
            get { return _ObereAugenzahl; }
            set { _ObereAugenzahl = value; /*InitDominostein(value, UntereAugenzahl);*/ }
        }

        public int UntereAugenzahl { 
            get{ return _UnterAugenzahl;}
            set { _UnterAugenzahl = value; /*InitDominostein(ObereAugenzahl, value);*/ }
        }

    }
}
