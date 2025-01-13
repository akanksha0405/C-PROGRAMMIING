using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace akanksha123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NUMBER");
            int num=Convert.ToInt32(Console.ReadLine());
            
            if (num > 0) {
                if (num % 2 == 0) {
                    Console.WriteLine("number is positive and its even also");
                }
                else {
                    Console.WriteLine("number is positive and odd also");
                } }
            else if (num < 0)
            {
                Console.WriteLine("number is negative");
            }
            else
            {
                Console.WriteLine("number is Zero");
            }
        }
    }
}
