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
        //Egar initialization with lazy
        //CLR takes care of thread safe 
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(new Singleton());
        public static Singleton GetInstance => instance.Value;

        public void PrintMessage(string message)
        {
            Console.WriteLine($"Received {message}");
        }
    }
}
