﻿using System;
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

        /// <summary>
        /// Initializes GameTypeWindow
        /// </summary>
        /// <param name="difficulty"></param>
        public GameTypeWindow(int difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;
        }

        /// <summary>
        /// Goes back to previous window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToDifficulty(object sender, RoutedEventArgs e)
        {
            DifficultyWindow dw = new DifficultyWindow();
            dw.Show();
            this.Close();
        }

        /// <summary>
        /// Select this if there are 2 players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PvP(object sender, RoutedEventArgs e)
        {
            EnterNameWindow gw = new EnterNameWindow(difficulty, false);
            gw.Show();
            this.Close();
        }

        /// <summary>
        /// Select this if there is only 1 player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PvC(object sender, RoutedEventArgs e)
        {
            EnterNameWindow gw = new EnterNameWindow(difficulty, true);
            gw.Show();
            this.Close();
        }
    }
}
