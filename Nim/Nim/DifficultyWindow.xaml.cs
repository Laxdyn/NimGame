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

        /// <summary>
        /// Initializes the Difficulty Window
        /// </summary>
        public DifficultyWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sends the next window the information for easy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Easy(object sender, RoutedEventArgs e)
        {
            GameTypeWindow gtw = new GameTypeWindow(1);
            gtw.Show();
            this.Close();
        }

        /// <summary>
        /// Sends the next window the information for medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Medium(object sender, RoutedEventArgs e)
        {
            GameTypeWindow gtw = new GameTypeWindow(2);
            gtw.Show();
            this.Close();
        }

        /// <summary>
        /// Sends the next window the information for hard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hard(object sender, RoutedEventArgs e)
        {
            GameTypeWindow gtw = new GameTypeWindow(3);
            gtw.Show();
            this.Close();

        }

        /// <summary>
        /// Goes back to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
