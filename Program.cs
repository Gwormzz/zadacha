using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Program hello = new Program();
            hello.WriteHello();
          
        }
        public void WriteHello()
        {
            Console.WriteLine("Hello, C#!");
        }
    }
}
