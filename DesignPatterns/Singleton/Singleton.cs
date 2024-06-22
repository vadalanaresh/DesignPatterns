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

        private static object obj = new object();

        private Singleton()
        {
            Counter++;
            Console.WriteLine($"counter {Counter}");
        }
        private static readonly Singleton instance = new Singleton();

        public static Singleton GetInstance => instance;

        public void PrintMessage(string message)
        {
            Console.WriteLine($"Received {message}");
        }
    }
}
