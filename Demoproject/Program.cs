using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello word from cg");
            Console.ReadLine();
            Program p = new Program();
            p.printName();
        }
        /// <summary>
        /// it is a first code
        /// </summary>

        public void printName()
        {
            Console.WriteLine("hello word");
            Console.ReadLine();
        }
    }
}
