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
        int totalPieces = 0;
        int difficulty = 0;
        Person person1 = new Person("");
        Person person2 = new Person("");
        Heap heap1 = new Heap(0, false);
        Heap heap2 = new Heap(0, false);
        Heap heap3 = new Heap(0, false);
        Heap heap4 = new Heap(0, false);
        bool computerPlayer = false;
        bool player1Turn = false;

        public GameWindow(int difficulty, bool v)
        {
            InitializeComponent();
            computerPlayer = v;
            switch(difficulty)
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
            NewMain();
        }

        public void NewMain()
        {

        }

        public void DisplayWinner()
        {
            if (computerPlayer)
            {
                if (player1Turn)
                {

                }
                else
                {

                }
            }
            else
            {
                if (player1Turn)
                {

                }
                else
                {

                }
            }
        }

        public bool CheckForLose()
        {
            if (totalPieces == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void IncreaseTake(Heap heap)
        {
            if (heap.Size != 0)
            {
                heap.Size--;
            }
        }

        public void DecreaseTake(Heap heap)
        {
            // Needs validation checking
            heap.Size++;
        }


    }
}
