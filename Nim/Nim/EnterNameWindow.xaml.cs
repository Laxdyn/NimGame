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
    /// Interaction logic for EnterNameWindow.xaml
    /// </summary>
    public partial class EnterNameWindow : Window
    {
        string name1 = "", name2 = "";
        int diff = 0;
        bool comp = false;

        /// <summary>
        /// Initializes the EnterNameWindow
        /// </summary>
        /// <param name="difficulty">Difficulty setting</param>
        /// <param name="v">True if player chose PvC</param>
        public EnterNameWindow(int difficulty, bool v)
        {
            InitializeComponent();
            diff = difficulty;
            comp = v;
            DynamicFormField(v);
        }

        /// <summary>
        /// Forms to get names
        /// </summary>
        /// <param name="comp">True if PvC</param>
        public void DynamicFormField(bool comp)
        {
            if(comp)
            {
                StackPanel sp = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    Margin = new Thickness(5),
                    Height = 40
                };
                Page.Children.Add(sp);

                Label name1Label = new Label
                {
                    Foreground = Brushes.Yellow,
                    Width = 100,
                    Height = 50,
                    Content = "Player 1 name"
                };
                sp.Children.Add(name1Label);

                TextBox tb = new TextBox
                {
                    Width = 200
                };
                sp.Children.Add(tb);

            }
            else
            {
                StackPanel sp = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    Margin = new Thickness(5),
                    Height = 40
                };
                Page.Children.Add(sp);

                Label name1Label = new Label
                {
                    Foreground = Brushes.Yellow,
                    Width = 100,
                    Height = 50,
                    Content = "Player 1 name"
                };
                sp.Children.Add(name1Label);

                TextBox tb = new TextBox
                {
                    Width = 200
                };
                sp.Children.Add(tb);


                StackPanel sp2 = new StackPanel
                {
                    Orientation = Orientation.Horizontal,
                    Margin = new Thickness(5),
                    Height = 40
                };
                Page.Children.Add(sp2);

                Label name2Label = new Label
                {
                    Foreground = Brushes.Yellow,
                    Width = 100,
                    Height = 50,
                    Content = "Player 2 name"
                };
                sp2.Children.Add(name2Label);

                TextBox tb2 = new TextBox
                {
                    Width = 200
                };
                sp2.Children.Add(tb2);
            }

            Button button = new Button
            {
                Height = 50,
                Width = 75,
                Content = "Submit",
                BorderBrush = Brushes.Yellow,
                Background = Brushes.DarkRed,
                BorderThickness = new Thickness(1),
                Foreground = Brushes.Yellow,
                FontSize = 15
            };

            Page.Children.Add(button);
            button.Click += NextPage;
        }

        /// <summary>
        /// Sends information to the next page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void NextPage(object sender, RoutedEventArgs e)
        {
            GameWindow gw = new GameWindow(diff, comp, name1, name2);
            gw.Show();
            this.Close();
        }
    }
}
