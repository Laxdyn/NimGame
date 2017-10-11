using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    /// <summary>
    /// Heap Class
    /// </summary>
    public class Heap
    {
        /// <summary>
        /// Constructor for the Heap class
        /// </summary>
        /// <param name="size">Heap size</param>
        /// <param name="live">Heap live state</param>
        public Heap(int size, bool live)
        {
            Size = size;
            IsAlive = live;
        }

        /// <summary>
        /// Size of the Heap
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Checks to see if Heap is alive
        /// </summary>
        public bool IsAlive { get; set; }

    }
}
