using System;
using Kata_Master_Mind.Controller;
using Kata_Master_Mind.Model;

namespace Kata_Master_Mind.View
{
    public class OutputGenerator : InputHandler  //TODO:  change this
    {
        public CurrentGameData _currentGameData;
        
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
        
        public static void GenerateLoss()
        {
            Console.Clear();
            Console.WriteLine("~~~~~ MasterMind ~~~~~\n");  
            Console.WriteLine("Error: you have had more than 60 tries!");
            Console.WriteLine("~~~~~ ~~~~~~~~~~ ~~~~~");
        }

        public static void PromptUser(string[] outputChars, int turn)
        {
            GameHeader(turn);
            DrawHorizontalLine();
            Console.WriteLine("| "+outputChars[0]+" | "+outputChars[1]+" | "+outputChars[2]+" | "+outputChars[3]+" |");
            DrawHorizontalLine();
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

        private static void DrawHorizontalLine()
        {
            Console.WriteLine(" ---------------");
        }
    }
}