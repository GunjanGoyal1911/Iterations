using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var i = 1;
            //while(i<=10)
            //{
            //    if (i % 2 == 0)            
            //        Console.WriteLine(i);
                
            //    i++;              
            //}

            while(true)
            {
                Console.Write("Enter your name: ");
                var input= Console.ReadLine();
                //if (string.IsNullOrEmpty(input))
                //    break;
                //Console.WriteLine("@Echo: "+ input);
                if (!string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }
                Console.ReadLine();
            }
    }
}
