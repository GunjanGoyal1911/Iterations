using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Gunjan Goyal";
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            // Differce b/w For loop and foreach loop
            foreach (var character in name)
                Console.WriteLine(character);
            //Foreach loop with array
            var name1 = new string[] { "Ginni","Vedant", "Siddhant" };
            foreach(var names in name1 )
                Console.WriteLine(names);

            var number = new int[] { 1, 2, 3, 4, 5 };
            foreach(var numbers in number)
                Console.WriteLine(numbers);
            Console.ReadLine(); 
            
        }
    }
}
