using System;

namespace Kata_Master_Mind.Controller
{
    public class InputHandler : InputValidator
    {
        //attach to interface

        protected string[] InputFormatter(string userInput) 
        {
            var formattedInput = new string[4];
            var answerCounter = 0;

            foreach (var guess in userInput.Trim().Split(' '))
            {
                formattedInput[answerCounter] = ConvertLetter(Convert.ToChar(guess));
                answerCounter++;
            }
            return formattedInput;
        }

        private string ConvertLetter(char letter)
        {
            if (letter == 'r')
            {
                return "RED";
            }
            if (letter == 'b')
            {
                return "BLUE";
            }
            if (letter == 'g')
            {
                return "GREEN";
            }
            if (letter == 'o')
            {
                return "ORANGE";   
            }
            if (letter == 'p')
            {
                return "PURPLE";
            }
            if (letter == 'y')
            {
                return "YELLOW";
            }
            return "e";
        }
    }
}