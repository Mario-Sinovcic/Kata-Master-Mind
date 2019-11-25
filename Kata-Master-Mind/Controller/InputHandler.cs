using System;
using System.Linq;

namespace Kata_Master_Mind.Controller
{
    public class InputHandler : IInputHandler
    {
        public string[] WinningStringCreator(int coloursPicked)
        {
            var winningSequence= new string [coloursPicked];
            for (var i = 0; i < coloursPicked; i++)
            {
                winningSequence[i] = "b";
            }

            return winningSequence;
        }
        
        public string[] DefaultStringCreator(int coloursPicked)
        {
            var initSequence= new string [coloursPicked];
            for (var i = 0; i < coloursPicked; i++)
            {
                initSequence[i] = "w";
            }

            return initSequence;
        }
        
        
        public string[] InputFormatter(string userInput, int coloursPicked) 
        {
            var formattedInput = new string[coloursPicked];
            var answerCounter = 0;

            foreach (var guess in userInput.Trim().Split(' '))
            {
                formattedInput[answerCounter] = ConvertLetter(Convert.ToChar(guess));
                answerCounter++;
            }
            return formattedInput;
        }

        private static string ConvertLetter(char letter)
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