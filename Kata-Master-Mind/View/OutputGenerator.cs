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

        public void generateWin()
        {
            
            Console.Clear();
            Console.WriteLine("~~~~~ MasterMind ~~~~~\n");  
            Console.WriteLine("Well done!\n\nYOU WON");
            Console.WriteLine("~~~~~ ~~~~~~~~~~ ~~~~~");
        }
        
        public void promptUser(string[] outputChars)
        {
            gameHeader();
            drawHorizontalLine();
            Console.WriteLine("| "+outputChars[0]+" | "+outputChars[1]+" | "+outputChars[2]+" | "+outputChars[3]+" |");
            drawHorizontalLine();
            Console.WriteLine("\nNot quite, enter another guess:");
        }
        
        public void promptUser(string errorValue)
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

        private void drawHorizontalLine()
        {
            Console.WriteLine(" ---------------");
        }
    }
}