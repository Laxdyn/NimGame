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

namespace Nim
{
    /// <summary>
    /// Interaction logic for GameTypeWindow.xaml
    /// </summary>
    public partial class GameTypeWindow : Window
    {
        int difficulty = 0;
        public GameTypeWindow(int difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;
        }

        private void BackToDifficulty(object sender, RoutedEventArgs e)
        {
            DifficultyWindow dw = new DifficultyWindow();
            dw.Show();
            this.Close();
        }

        private void PvP(object sender, RoutedEventArgs e)
        {
            GameWindow gw = new GameWindow(difficulty, false);
            gw.Show();
            this.Close();
        }

        private void PvC(object sender, RoutedEventArgs e)
        {
            GameWindow gw = new GameWindow(difficulty, true);
            gw.Show();
            this.Close();
        }
    }
}
