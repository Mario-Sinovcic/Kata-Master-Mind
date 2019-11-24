using System;
using Kata_Master_Mind.Controller;

namespace Kata_Master_Mind.View
{
    public class OutputGenerator : InputHandler  //TODO:  change this
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

        public void PromptUser(string[] outputChars)
        {
            gameHeader();
            DrawHorizontalLine();
            Console.WriteLine("| "+outputChars[0]+" | "+outputChars[1]+" | "+outputChars[2]+" | "+outputChars[3]+" |");
            DrawHorizontalLine();
            Console.WriteLine("\nNot quite, enter another guess:");
        }

        public void PromptUser(string errorValue)
        {
            gameHeader();
            Console.WriteLine("ERROR");
            Console.WriteLine("|| "+errorValue +"\n||");
            Console.WriteLine("\nPlease re-enter you guess:");
        }
        
        private void gameHeader()
        {
            Console.Clear();
            Console.WriteLine("~~~~~ MasterMind ~~~~~\n");  
            Console.WriteLine("Turns:");
        }

        private static void DrawHorizontalLine()
        {
            Console.WriteLine(" ---------------");
        }
    }
}