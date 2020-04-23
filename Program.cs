using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Reflection.Metadata;
using System.Collections.Concurrent;
using System.Reflection.Emit;
using System.Data;
using Internal;
using System;

namespace Guessing
{
    class Program
    {
        static void Main(string[] args)
        {
             string level = "";
            Random randomNumber = New Random();
            Console.WriteLine("Hello welcome to Start.NG number guess game,there are three levels in the game: easy, medium and hard ");
            Console.Write("Please enter your user name: ");
            Console.Write("Please choose a level: ");
            level = (Console.Readline());
            
            if(level == Easy)
            {
                Console.WriteLine ("You chose easy, You a chance to guess the number between 1 - 10, and you have 6 guesses");
		        int i = 0;
                int a;
                while (i <= 5)
                {
                    numberRandom.Next(1, 11);
                    Console.WriteLine("\nYou have {0} chances left", a = 6 - i);
                    Console.Write("Guess a number: ");
                    int guessNumber =Convert.ToInt32(Console.ReadLine());
                    if (guessNumber==randomNumber.Next(1, 11))
                    {
                        Console.WriteLine("You're Right!");
                    }
                    else
                    {
                        Console.WriteLine("You're Wrong!");
                    }
                    i++;
                }
                Console.WriteLine("\nGame Over!");
            }

            else if(level = Medium)
            {
              Console.WriteLine("You chose Medium, You can guess the number between 1 - 20, and you have 4 guesses");
	            int i = 0;
                int a;
                while (i <= 3)
                {
                    numberRandom.Next(1, 11);
                    Console.WriteLine("\nYou have {0} chances left", a = 4 - i);
                    Console.Write("Guess a number: ");
                    int guessNumber =Convert.ToInt32(Console.ReadLine());
                    if (guessNumber==randomNumber.Next(1, 21))
                    {
                        Console.WriteLine("You're Right!");
                    }
                    else
                    {
                        Console.WriteLine("You're Wrong!");
                    }
                    i++;
                }
                Console.WriteLine("\nGame Over!");
            }

            else (level = Hard)
            {
              Console.WriteLine("You chose Hard, You can guess between 1 - 50, and you have 3 guesses");
	            int i = 0;
                int a;
                while (i <= 2)
                {
                    numberRandom.Next(1, 11);
                    Console.WriteLine("\nYou have {0} chances left", a = 3 - i);
                    Console.Write("Guess a number: ");
                    int guessNumber =Convert.ToInt32(Console.ReadLine());
                    if (guessNumber==randomNumber.Next(1, 51))
                    {
                        Console.WriteLine("You're Right!");
                    }
                    else
                    {
                        Console.WriteLine("You're Wrong!");
                    }
                    i++;
                }
                Console.WriteLine("\nGame Over!");
            } 
        }
    }
}

