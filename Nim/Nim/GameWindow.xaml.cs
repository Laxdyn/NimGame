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
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        int totalPieces = 1;
        int difficulty = 0;
        Person person1 = new Person("");
        Person person2 = new Person("");
        Heap heap1 = new Heap(0, false);
        Heap heap2 = new Heap(0, false);
        Heap heap3 = new Heap(0, false);
        Heap heap4 = new Heap(0, false);
        StackPanel heap1Stack, heap2Stack, heap3Stack, heap4Stack;
        Label countTakened;
        bool computerPlayer = false;
        bool player1Turn = false;
        int take1 = 0, take2 = 0, take3 = 0, take4 = 0;

        /// <summary>
        /// Initializes the GameWindow
        /// </summary>
        /// <param name="difficulty">Difficulty 1-easy, 2-medium, 3-hard</param>
        /// <param name="v">True if PvC</param>
        /// <param name="name1">Player 1's name</param>
        /// <param name="name2">Player 2's name</param>
        public GameWindow(int difficulty, bool v, string name1, string name2)
        {
            InitializeComponent();
            computerPlayer = v;
            switch (difficulty)
            {
                case 1:
                    totalPieces = 4;
                    heap1.Size = 2;
                    heap1.IsAlive = true;
                    heap2.Size = 2;
                    heap2.IsAlive = true;
                    break;
                case 2:
                    totalPieces = 14;
                    heap1.Size = 2;
                    heap1.IsAlive = true;
                    heap2.Size = 5;
                    heap2.IsAlive = true;
                    heap3.Size = 7;
                    heap3.IsAlive = true;
                    break;
                case 3:
                    totalPieces = 22;
                    heap1.Size = 2;
                    heap1.IsAlive = true;
                    heap2.Size = 3;
                    heap2.IsAlive = true;
                    heap3.Size = 8;
                    heap3.IsAlive = true;
                    heap4.Size = 9;
                    heap4.IsAlive = true;
                    break;
            }
            this.difficulty = difficulty;
            person1.Name = name1;
            person2.Name = name2;
            SetUpGame();
            Game();
        }

        /// <summary>
        /// Sets up all the buttons and stack panels
        /// </summary>
        public void SetUpGame()
        {
            if (heap1.IsAlive)
            {
                StackPanel firstStackPanel = new StackPanel
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Orientation = Orientation.Horizontal
                };
                MainPanel.Children.Add(firstStackPanel);

                heap1Stack = new StackPanel
                {
                    Width = 200,
                    Height = 60,
                    Orientation = Orientation.Horizontal,
                    HorizontalAlignment = HorizontalAlignment.Left
                };
                firstStackPanel.Children.Add(heap1Stack);

                for (int i = 0; i < heap1.Size; i++)
                {
                    Label objects = new Label
                    {
                        Width = 10,
                        Background = Brushes.Yellow,
                        Margin = new Thickness(5)
                    };
                    heap1Stack.Children.Add(objects);
                }

                Button heap1Decrease = new Button
                {
                    Width = 60,
                    Height = 60,
                    Content = "-",
                    BorderBrush = Brushes.Yellow,
                    Background = Brushes.DarkRed,
                    BorderThickness = new Thickness(1),
                    Foreground = Brushes.Yellow,
                    FontSize = 30

                };
                heap1Decrease.Click += DecreaseTakeOne;

                countTakened = new Label
                {
                    Width = 60,
                    Height = 60,
                    Content = take1,
                    FontSize = 30,
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    Foreground = Brushes.Yellow
                };

                Button heap1Increase = new Button
                {
                    Width = 60,
                    Height = 60,
                    Content = "+",
                    BorderBrush = Brushes.Yellow,
                    Background = Brushes.DarkRed,
                    BorderThickness = new Thickness(1),
                    Foreground = Brushes.Yellow,
                    FontSize = 30
                };
                heap1Increase.Click += IncreaseTakeOne;

                firstStackPanel.Children.Add(heap1Decrease);
                firstStackPanel.Children.Add(countTakened);
                firstStackPanel.Children.Add(heap1Increase);

            }

            if (heap2.IsAlive)
            {
                StackPanel secondStackPanel = new StackPanel
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Orientation = Orientation.Horizontal
                };
                MainPanel.Children.Add(secondStackPanel);

                heap2Stack = new StackPanel
                {
                    Width = 200,
                    Height = 60,
                    Orientation = Orientation.Horizontal,
                    HorizontalAlignment = HorizontalAlignment.Left
                };
                secondStackPanel.Children.Add(heap2Stack);

                for (int i = 0; i < heap2.Size; i++)
                {
                    Label objects = new Label
                    {
                        Width = 10,
                        Background = Brushes.Yellow,
                        Margin = new Thickness(5)
                    };
                    heap2Stack.Children.Add(objects);
                }

                Button heap2Decrease = new Button
                {
                    Width = 60,
                    Height = 60,
                    Content = "-",
                    BorderBrush = Brushes.Yellow,
                    Background = Brushes.DarkRed,
                    BorderThickness = new Thickness(1),
                    Foreground = Brushes.Yellow,
                    FontSize = 30
                };

                countTakened = new Label
                {
                    Width = 60,
                    Height = 60,
                    Content = take2,
                    FontSize = 30,
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    Foreground = Brushes.Yellow
                };

                Button heap2Increase = new Button
                {
                    Width = 60,
                    Height = 60,
                    Content = "+",
                    BorderBrush = Brushes.Yellow,
                    Background = Brushes.DarkRed,
                    BorderThickness = new Thickness(1),
                    Foreground = Brushes.Yellow,
                    FontSize = 30
                };

                secondStackPanel.Children.Add(heap2Decrease);
                secondStackPanel.Children.Add(countTakened);
                secondStackPanel.Children.Add(heap2Increase);
                heap2Increase.Click += IncreaseTakeTwo;
                heap2Decrease.Click += DecreaseTakeTwo;

            }

            if (heap3.IsAlive)
            {
                StackPanel thirdStackPanel = new StackPanel
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Orientation = Orientation.Horizontal
                };
                MainPanel.Children.Add(thirdStackPanel);

                heap3Stack = new StackPanel
                {
                    Width = 200,
                    Height = 60,
                    Orientation = Orientation.Horizontal,
                    HorizontalAlignment = HorizontalAlignment.Left
                };
                thirdStackPanel.Children.Add(heap3Stack);

                for (int i = 0; i < heap3.Size; i++)
                {
                    Label objects = new Label
                    {
                        Width = 10,
                        Background = Brushes.Yellow,
                        Margin = new Thickness(5)
                    };
                    heap3Stack.Children.Add(objects);
                }

                Button heap3Decrease = new Button
                {
                    Width = 60,
                    Height = 60,
                    Content = "-",
                    BorderBrush = Brushes.Yellow,
                    Background = Brushes.DarkRed,
                    BorderThickness = new Thickness(1),
                    Foreground = Brushes.Yellow,
                    FontSize = 30
                };

                countTakened = new Label
                {
                    Width = 60,
                    Height = 60,
                    Content = take3,
                    FontSize = 30,
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    Foreground = Brushes.Yellow
                };

                Button heap3Increase = new Button
                {
                    Width = 60,
                    Height = 60,
                    Content = "+",
                    BorderBrush = Brushes.Yellow,
                    Background = Brushes.DarkRed,
                    BorderThickness = new Thickness(1),
                    Foreground = Brushes.Yellow,
                    FontSize = 30
                };

                thirdStackPanel.Children.Add(heap3Decrease);
                thirdStackPanel.Children.Add(countTakened);
                thirdStackPanel.Children.Add(heap3Increase);
                heap3Increase.Click += IncreaseTakeThree;
                heap3Decrease.Click += DecreaseTakeThree;

            }

            if (heap4.IsAlive)
            {
                StackPanel fourthStackPanel = new StackPanel
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Orientation = Orientation.Horizontal
                };
                MainPanel.Children.Add(fourthStackPanel);

                heap4Stack = new StackPanel
                {
                    Width = 200,
                    Height = 60,
                    Orientation = Orientation.Horizontal,
                    HorizontalAlignment = HorizontalAlignment.Left
                };
                fourthStackPanel.Children.Add(heap4Stack);

                for (int i = 0; i < heap4.Size; i++)
                {
                    Label objects = new Label
                    {
                        Width = 10,
                        Background = Brushes.Yellow,
                        Margin = new Thickness(5)
                    };
                    heap4Stack.Children.Add(objects);
                }

                Button heap4Decrease = new Button
                {
                    Width = 60,
                    Height = 60,
                    Content = "-",
                    BorderBrush = Brushes.Yellow,
                    Background = Brushes.DarkRed,
                    BorderThickness = new Thickness(1),
                    Foreground = Brushes.Yellow,
                    FontSize = 30
                };

                countTakened = new Label
                {
                    Width = 60,
                    Height = 60,
                    Content = take4,
                    FontSize = 30,
                    HorizontalContentAlignment = HorizontalAlignment.Center,
                    Foreground = Brushes.Yellow
                };

                Button heap4Increase = new Button
                {
                    Width = 60,
                    Height = 60,
                    Content = "+",
                    BorderBrush = Brushes.Yellow,
                    Background = Brushes.DarkRed,
                    BorderThickness = new Thickness(1),
                    Foreground = Brushes.Yellow,
                    FontSize = 30
                };

                fourthStackPanel.Children.Add(heap4Decrease);
                fourthStackPanel.Children.Add(countTakened);
                fourthStackPanel.Children.Add(heap4Increase);
                heap4Increase.Click += IncreaseTakeFour;
                heap4Decrease.Click += DecreaseTakeFour;
            }
        }

        /// <summary>
        /// Take out one from Heap1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void IncreaseTakeOne(object sender, RoutedEventArgs e)
        {
            IncreaseTake(heap1);
        }
        /// <summary>
        /// Take out one from Heap2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void IncreaseTakeTwo(object sender, RoutedEventArgs e)
        {
            IncreaseTake(heap2);
        }

        /// <summary>
        /// Take out one from Heap3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void IncreaseTakeThree(object sender, RoutedEventArgs e)
        {
            IncreaseTake(heap3);
        }

        /// <summary>
        /// Take out one from Heap4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void IncreaseTakeFour(object sender, RoutedEventArgs e)
        {
            IncreaseTake(heap4);
        }

        /// <summary>
        /// Adds one to Heap1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DecreaseTakeOne(object sender, RoutedEventArgs e)
        {
            DecreaseTake(heap1);
        }

        /// <summary>
        /// Adds one to Heap2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DecreaseTakeTwo(object sender, RoutedEventArgs e)
        {
            DecreaseTake(heap2);
        }

        /// <summary>
        /// Adds one to Heap3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DecreaseTakeThree(object sender, RoutedEventArgs e)
        {
            DecreaseTake(heap3);
        }

        /// <summary>
        /// Adds one to Heap4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DecreaseTakeFour(object sender, RoutedEventArgs e)
        {
            DecreaseTake(heap4);
        }

        /// <summary>
        /// Displays the Winner of the game
        /// </summary>
        public void DisplayWinner()
        {
            if (computerPlayer)
            {
                if (player1Turn)
                {
                    MessageBox.Show("Sorry You Lose");
                }
                else
                {
                    MessageBox.Show("Congrats " + person1.Name);
                }
            }
            else
            {
                if (player1Turn)
                {
                    MessageBox.Show("Congrats " + person2.Name);
                }
                else
                {
                    MessageBox.Show("Congrats " + person1.Name);
                }
            }
        }

        /// <summary>
        /// Checks to see if current turn lost
        /// </summary>
        public void CheckForLose()
        {
            if (totalPieces == 0)
            {
                DisplayWinner();
            }
        }

        /// <summary>
        /// Called by all the other IncreaseTake methods
        /// </summary>
        /// <param name="heap">Heap from which method removes from</param>
        public void IncreaseTake(Heap heap)
        {
            if (heap.IsAlive)
            {
                if (heap.Size == 0)
                {
                    heap.IsAlive = false;
                }
                else
                {
                    heap.Size--;
                    totalPieces--;
                }
            }

            UpdateGui();
        }

        /// <summary>
        /// Called by all the other DecreaseTake methods
        /// </summary>
        /// <param name="heap">Heap from which method adds to</param>
        public void DecreaseTake(Heap heap)
        {
            if (!heap.IsAlive)
            {
                heap.Size++;
            }
        }

        /// <summary>
        /// Computer's turn
        /// </summary>
        public void PCMove()
        {
            //int random = 0;
            //if (difficulty == 1)
            //{
            //    random = 3.Random(1);
            //    if (random == 1)
            //    {
            //        random = heap1.Size.Random(1);
            //        for (int i = 0; i < random; i++)
            //        {
            //            IncreaseTake(heap1);
            //        }
            //    }
            //    else
            //    {
            //        random = heap2.Size.Random(1);
            //        for (int i = 0; i < random; i++)
            //        {
            //            IncreaseTake(heap2);
            //        }
            //    }
            //}
            //else if (difficulty == 2)
            //{
            //    random = 4.Random(1);
            //    if (random == 1)
            //    {
            //        random = heap1.Size.Random(1);
            //        for (int i = 0; i < random; i++)
            //        {
            //            IncreaseTake(heap1);
            //        }
            //    }
            //    else if (random == 1)
            //    {
            //        random = heap2.Size.Random(1);
            //        for (int i = 0; i < random; i++)
            //        {
            //            IncreaseTake(heap2);
            //        }
            //    }
            //    else
            //    {
            //        random = heap3.Size.Random(1);
            //        for (int i = 0; i < random; i++)
            //        {
            //            IncreaseTake(heap3);
            //        }
            //    }
            //}
            //else if (difficulty == 3)
            //{
            //    random = 5.Random(1);
            //    if (random == 1)
            //    {
            //        random = heap1.Size.Random(1);
            //        for (int i = 0; i < random; i++)
            //        {
            //            IncreaseTake(heap1);
            //        }
            //    }
            //    else if (random == 1)
            //    {
            //        random = heap2.Size.Random(1);
            //        for (int i = 0; i < random; i++)
            //        {
            //            IncreaseTake(heap2);
            //        }
            //    }
            //    else if (random == 3)
            //    {
            //        random = heap3.Size.Random(1);
            //        for (int i = 0; i < random; i++)
            //        {
            //            IncreaseTake(heap3);
            //        }
            //    }
            //    else
            //    {
            //        random = heap4.Size.Random(1);
            //        for (int i = 0; i < random; i++)
            //        {
            //            IncreaseTake(heap4);
            //        }
            //    }
            //}
        }

        /// <summary>
        /// Calls PCMove(); Used as a click event for a button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PCMove(object sender, RoutedEventArgs e)
        {
            PCMove();
        }

        /// <summary>
        /// Method for where the game switches turns
        /// </summary>
        public void Game()
        {
            if (player1Turn)
            {
                player1Turn = !player1Turn;
                CheckForLose();
            }
            else
            {
                PCMove();
                player1Turn = !player1Turn;
                CheckForLose();
            }
        }

        /// <summary>
        /// Updates Gui
        /// </summary>
        public void UpdateGui()
        {

            if (heap1.IsAlive)
            {
                countTakened.Content = take1;
                heap1Stack.Children.Clear();
                for (int i = 0; i < heap1.Size; i++)
                {
                    Label objects = new Label
                    {
                        Width = 10,
                        Background = Brushes.Yellow,
                        Margin = new Thickness(5)
                    };
                    heap1Stack.Children.Add(objects);
                }
            }

            if (heap2.IsAlive)
            {
                countTakened.Content = take2;
                heap2Stack.Children.Clear();
                for (int i = 0; i < heap2.Size; i++)
                {
                    Label objects = new Label
                    {
                        Width = 10,
                        Background = Brushes.Yellow,
                        Margin = new Thickness(5)
                    };
                    heap2Stack.Children.Add(objects);
                }
            }

            if (heap3.IsAlive)
            {
                countTakened.Content = take3;
                heap3Stack.Children.Clear();
                for (int i = 0; i < heap3.Size; i++)
                {
                    Label objects = new Label
                    {
                        Width = 10,
                        Background = Brushes.Yellow,
                        Margin = new Thickness(5)
                    };
                    heap3Stack.Children.Add(objects);
                }
            }

            if (heap4.IsAlive)
            {
                countTakened.Content = take4;
                heap4Stack.Children.Clear();
                for (int i = 0; i < heap4.Size; i++)
                {
                    Label objects = new Label
                    {
                        Width = 10,
                        Background = Brushes.Yellow,
                        Margin = new Thickness(5)
                    };
                    heap4Stack.Children.Add(objects);
                }
            }
        }
    }
}
