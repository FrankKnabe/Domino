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

namespace Domino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdStart_Click(object sender, RoutedEventArgs e)
        {
            int player = Convert.ToInt32(numud.Child.Text);
            int aiplayer = Convert.ToInt32(numud1.Child.Text);

            var newWindow = new GameTable(player, aiplayer);
            newWindow.Show();

        }

    }
}
