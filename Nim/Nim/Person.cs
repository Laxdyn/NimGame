using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    /// <summary>
    /// Person Class
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Person Class Constructor
        /// </summary>
        /// <param name="name">Person's Name</param>
        public Person(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Name for person
        /// </summary>
        public string Name { get; set; }
    }
}
