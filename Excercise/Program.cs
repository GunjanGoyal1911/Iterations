using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    internal class Program
    {
        /// <summary>
        /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        /// Display the result on the console.
        /// </summary>
      public static void Exercise1()
        {
            var count = 0;
            for(int i=1; i<=100; i++)
            {
                if(i%3==0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers dvisible by 3 between 1 and 100." , count);
        }

        /// <summary>
        /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
        /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
        /// </summary>
        public static void Exercise2()
        {
            var sum = 0;
            while (true)
            {                
                Console.Write("Enter a number (or `ok` to exit):");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is:" + sum);

        }

        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>
       
        public static void Exercise3()
        {
            Console.Write("Enter the number: ");
            var input= Convert.ToInt32(Console.ReadLine());

            var fact = 1;
            for(var i=1; i<=input; i++)
            {
                fact = fact*i;               
            }
            Console.WriteLine("Factorial of {0} is: {1}", input, fact);
        }


        /// <summary>
        /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
        /// If the user guesses the number, display “You won". Otherwise, display “You lost".
        /// </summary>
        public static void Exercise4()
        {
            var number= new Random().Next(1, 10);
            Console.WriteLine("Secret number:" + number);

            for(var i =1; i<=4; i++)
            {
                Console.WriteLine("Guess the secret number:");
                var guess = Convert.ToInt32(Console.ReadLine());
                if(guess == number)
                {
                    Console.WriteLine("You Won!");
                    return;
                }
            }
            Console.WriteLine("You lost!");
        }

        public static void Exercise5()
        {
            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);

        }

        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            Exercise5();
            Console.ReadLine();

        }
    }
}
