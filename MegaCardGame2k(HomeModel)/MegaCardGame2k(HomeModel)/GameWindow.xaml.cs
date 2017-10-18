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
using _2kClasses;

namespace MegaCardGame2k_HomeModel_
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        GameControl vGC;

        public GameWindow(char p)
        {
            vGC = new GameControl();
            vGC.ClassChoice(p);
            InitializeComponent();

            lblNpcDamage.Content = vGC.enemy.BaseDamage.ToString();
            lblPlayerDamage.Content = vGC.player.BaseDamage.ToString();
            lblNpcHp.Content = vGC.enemy.Hp.ToString();
            lblPlayerHp.Content = vGC.player.Hp.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vGC.AttackCall('N');
            lblNpcHp.Content = (vGC.enemy.Hp).ToString();
            lblPlayerHp.Content = (vGC.player.Hp).ToString();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            vGC.AttackCall('S');
            lblNpcHp.Content = (vGC.enemy.Hp).ToString();
            lblPlayerHp.Content = (vGC.player.Hp).ToString();
        }
    }
}
