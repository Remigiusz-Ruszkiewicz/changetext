using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changetext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napisz coś:");
            var tekst = Console.ReadLine();
            int lenght = tekst.Length;
            if (tekst.Length >20)
            {
                Console.WriteLine(tekst.Remove(10) + "...");
                Console.Read();

            }
            else
            {
                Console.WriteLine(tekst);
                Console.Read();
            }
            
        }
    }
}
