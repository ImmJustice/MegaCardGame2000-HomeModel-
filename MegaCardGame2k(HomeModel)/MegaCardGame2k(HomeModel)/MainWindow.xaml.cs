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
using _2kClasses;

namespace MegaCardGame2k_HomeModel_
{

    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameWindow Gw;

        public MainWindow()
        {

            InitializeComponent();
            
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            Gw = new GameWindow('W');
            Gw.imgPlayer.Source = new BitmapImage(new Uri(@"D:\MegaCardGame2000-HomeModel-\MegaCardGame2k(HomeModel)\MegaCardGame2k(HomeModel)\Resources\Warrior.png"));
            this.Hide();
            Gw.Show();
        }

        private void Mage_Click(object sender, RoutedEventArgs e)
        {
            Gw = new GameWindow('M');
            Gw.imgPlayer.Source = new BitmapImage(new Uri(@"D:\MegaCardGame2000-HomeModel-\MegaCardGame2k(HomeModel)\MegaCardGame2k(HomeModel)\Resources\Mage.png"));
            this.Hide();
            Gw.Show();
        }

        private void Thief_Click(object sender, RoutedEventArgs e)
        {
            Gw = new GameWindow('T');
            Gw.imgPlayer.Source = new BitmapImage(new Uri(@"D:\MegaCardGame2000-HomeModel-\MegaCardGame2k(HomeModel)\MegaCardGame2k(HomeModel)\Resources\Thief.png"));
            this.Hide();
            Gw.Show();
        }
    }
}
