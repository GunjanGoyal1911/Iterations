using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random= new Random();
            const int passwordLength= 10;
            var buffer = new char[passwordLength];
            for (var i = 1; i < passwordLength; i++)
                buffer[i] = ((char)('a'+ random.Next(0,26)));
            var password = new String(buffer);
            Console.WriteLine(password);
            //Console.WriteLine((int)'b');
            Console.ReadLine();
        }
    }
}
