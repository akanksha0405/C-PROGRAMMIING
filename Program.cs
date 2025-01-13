using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akanksha123
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // float num=Convert.ToSingle(Console.ReadLine());
           int num=Convert.ToInt32(Console.ReadLine());
            string mem=Console.ReadLine();
            int FinalAmt;
        
            if (mem == "GoldM")
            {
                FinalAmt = num - (num*20/100);
                Console.WriteLine("Discount of 20% final amount:{0}",FinalAmt );
            }
            else if (mem == "SilverM")
                    {
               FinalAmt = num - (num *10/100);
                Console.WriteLine("discount of 10%.final amount:{0}",FinalAmt);     
            }
            else
            {
                Console.WriteLine("No discount");
            }
        }
    }
}
