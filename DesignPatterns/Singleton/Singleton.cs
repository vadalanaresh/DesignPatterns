using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static int Counter = 0;

        public Singleton()
        {
            Counter++;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine($"counter {Counter}");
            Console.WriteLine($"Received {message}");
        }
    }
}
