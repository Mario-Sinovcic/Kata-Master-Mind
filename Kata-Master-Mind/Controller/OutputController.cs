using System;
using Kata_Master_Mind.Model;

namespace Kata_Master_Mind.Controller
{
    public class OutputController : OutputView
    {
        private readonly CurrentGameData _gameData;
        private readonly string[] _winningOutput = new string[]{"b", "b", "b", "b"};
        
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

                    var result = calculateResult();
                    if (result.Equals(_winningOutput))
                    {
                        gameFinished = true;
                        Console.WriteLine("yay");
                    }
                    else
                    {
                        promptUser(result);
                    }
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
            var pos = 0;
            
            for(int i=0;i<_gameData.getCurrentColourList().Length;i++) //(string colourGuess in _gameData.getCurrentColourList())
            {
                string colourGuess = _gameData.getCurrentColourList()[i];
                if (colourGuess.Equals(_gameData.getCorrectColourList()[i]))
                {
                        guessOutput[pos] = "b"; 
                        pos++;
                }
            }
            return guessOutput;
        }
    }
}