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


namespace Nim
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

        private void StartGameButton(object sender, RoutedEventArgs e)
        {
            DifficultyWindow dw = new DifficultyWindow();
            dw.Show();
            this.Close();
        }

        private void InstructionsButton(object sender, RoutedEventArgs e)
        {
            InstructionsWindow iw = new InstructionsWindow();
            iw.Show();
            this.Close();
        }

        private void ExitGame(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
