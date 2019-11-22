using System;
using Kata_Master_Mind.Model;

namespace Kata_Master_Mind.Controller
{
    public class OutputController : OutputView
    {
        private CurrentGameData _gameData;
        
        public OutputController(CurrentGameData gameData)
        {
            _gameData = gameData;
        }

        public void startGame()
        {
            firstUserPrompt();
            bool gameFinished = false;

            while (!gameFinished)
            {
                string currentUserInput = Console.ReadLine();
                string errorCode = checkInputForErrors(currentUserInput.ToLower().Trim());
                
                if (errorCode == "valid")
                {
                    var firstGuess = InputFormater(currentUserInput);
                    _gameData.setCurrentColourList(firstGuess);

                    //calculateResult();
                    promptUser();

                }
                else
                {
                    //errorHandler(errorCode);
                    promptUser(errorCode);
                }
            }
        }

        private string[] calculateResult()
        {
            string[] guessOutput = new string[]{"w","w","w","w"};
            var i = 0;
            
            foreach (string colourGuess in _gameData.getCurrentColourList())
            {
                foreach (string correctColour in _gameData.getCorrectColourList())
                {
                    if (correctColour == colourGuess)
                    {
                        guessOutput[i] = "b";
                        i++;
                    }
                }
            }

            foreach (string val in guessOutput)
            {
                Console.WriteLine(val);
            }
            
            return guessOutput;
        }
    }
}