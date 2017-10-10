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
    /// Interaction logic for DifficultyWindow.xaml
    /// </summary>
    public partial class DifficultyWindow : Window
    {
        public DifficultyWindow()
        {
            InitializeComponent();
        }

        private void Easy(object sender, RoutedEventArgs e)
        {
            GameTypeWindow gtw = new GameTypeWindow(1);
            gtw.Show();
            this.Close();
        }

        private void Medium(object sender, RoutedEventArgs e)
        {
            GameTypeWindow gtw = new GameTypeWindow(2);
            gtw.Show();
            this.Close();
        }

        private void Hard(object sender, RoutedEventArgs e)
        {
            GameTypeWindow gtw = new GameTypeWindow(3);
            gtw.Show();
            this.Close();

        }

        private void BackToMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
