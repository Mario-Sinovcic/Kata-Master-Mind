using System;

namespace Kata_Master_Mind
{
    public class OutputView : InputHandler  //TODO:  change this
    {
        //default output "no errors"
        protected void response(string[] currentGuess)
        {
            //just display the ooutput
        }

        protected void errorResponse(int errorCode)
        {
            //if statements
            //just display the output
        }

        protected void firstUserPrompt()
        {
            Console.Clear();
            Console.WriteLine("~~~~~ MasterMind ~~~~~\n");
            Console.WriteLine("Welcome to the Mastermind game.");
            Console.WriteLine("Please inter your first guess (e.g., r g b b)");
            Console.WriteLine("Your guess: ");
        }
        
        public void promptUser()
        {
            gameHeader();
            drawHorizontalLine();
            Console.WriteLine("| - | - | - | - |");
            drawHorizontalLine();
            Console.WriteLine("\nNot quite, enter another guess:");
        }
        
        public void promptUser(string errorValue)
        {
            gameHeader();
            Console.WriteLine("ERROR");
            Console.WriteLine("Error Details: "+errorValue);
            Console.WriteLine("\n\nPlease re-enter you guess:");
        }
        
        private void gameHeader()
        {
            Console.Clear();
            Console.WriteLine("~~~~~ MasterMind ~~~~~\n");  
            //Console.WriteLine("Turns: \n");
        }
        
        public void drawHorizontalLine()
        {
            Console.WriteLine(" ---------------");
        }
    }
}