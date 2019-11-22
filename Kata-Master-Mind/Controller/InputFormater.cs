using System;
using Kata_Master_Mind.Controller;

namespace Kata_Master_Mind
{
    public class InputHandler : InputValidator
    {
        //attach to interface

        protected string[] InputFormater(string userInput) 
        {
            var formattedInput = new string[4];
            var answerCounter = 0;

            foreach (var guess in userInput.Split(' '))
            {
                formattedInput[answerCounter] = convertLetter(Convert.ToChar(guess));
                answerCounter++;
            }

            return formattedInput;
        }

        private string convertLetter(char letter)
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