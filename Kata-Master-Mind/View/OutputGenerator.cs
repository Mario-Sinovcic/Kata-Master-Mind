using System;
using System.Linq;
using Kata_Master_Mind.Controller;

namespace Kata_Master_Mind.View
{
    public static class OutputGenerator  
    {
        public static void FirstUserPrompt()
        {
            Console.Clear();
            Console.WriteLine("~~~~~ MasterMind ~~~~~\n");
            Console.WriteLine("Welcome to the Mastermind game.");
            Console.WriteLine("Please inter your first guess (e.g., r g b b)");
            Console.WriteLine("Your guess: ");
        }

        public static void GenerateWin()
        {
            Console.Clear();
            Console.WriteLine("~~~~~ MasterMind ~~~~~\n");  
            Console.WriteLine("Well done!\n\nYOU WON");
            Console.WriteLine("~~~~~ ~~~~~~~~~~ ~~~~~");
        }
        
        public static void GenerateLoss(int turnLimit)
        {
            Console.Clear();
            Console.WriteLine("~~~~~ MasterMind ~~~~~\n");  
            Console.WriteLine("Error: you have had more than "+ turnLimit +" tries!");
            Console.WriteLine("~~~~~ ~~~~~~~~~~ ~~~~~");
        }

        public static void PromptUser(string[] outputChars, int turn)
        {
            GameHeader(turn);
            DrawHorizontalLine(outputChars.Length);
            var outputString = outputChars.Aggregate("|", (current, guess) => current + " " + guess + " |");
            Console.WriteLine(outputString);
            DrawHorizontalLine(outputChars.Length);
            Console.WriteLine("\nNot quite, enter another guess:");
        }

        public static void PromptUser(string errorValue, int turn)
        {
            GameHeader(turn);
            Console.WriteLine("ERROR");
            Console.WriteLine("|| "+errorValue +"\n||");
            Console.WriteLine("\nPlease re-enter you guess:");
        }
        
        private static void GameHeader(int turn)
        {
            Console.Clear();
            Console.WriteLine("~~~~~ MasterMind ~~~~~");  
            Console.WriteLine("Turns: " + turn +"\n");
        }

        private static void DrawHorizontalLine(int amountOfChars)
        {
            var outputLine = " ";
            for (var i = 0; i < amountOfChars; i++)
            {
               outputLine += "----";
            }
            Console.WriteLine(outputLine);
        }
    }
}