using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    public class Heap
    {
        public Heap(int size, bool live)
        {
            Size = size;
            IsAlive = live;
        }

        public int Size { get; set; }
        public bool IsAlive { get; set; }

        public void IncreaseTake()
        {
            Size--;
        }

        public void DecreaseTake()
        {
            Size++;
        }
    }
}
