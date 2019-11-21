using System;

namespace Kata_Master_Mind
{
    public class InputHandler
    {
        //attach to interface

        protected string[] inputFormater(string userInput)
        {
            //potentially add regex here to get rid of all white spaces
            
            var formattedInput = new string[4];
            var answerCounter = 0;
            
            for (int i = 0; i < userInput.Trim().Length; i++)
            {
                if (userInput[i] != ' ')
                {
                    formattedInput[answerCounter] = convertLetter(userInput[i]);
                    answerCounter++;
                }
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