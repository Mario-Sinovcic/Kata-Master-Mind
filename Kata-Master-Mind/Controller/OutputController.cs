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
                    
                    foreach(var item in _gameData.getCurrentColourList())
                    {
                        Console.WriteLine(item);
                    }
                    
                    promptUser();
                }
                else
                {
                    Console.WriteLine(errorCode);
                    errorHandler(errorCode);
                }
                

            }


            //errorhandler with while loop
  
        }
        
            //check current guess for errors
            //output as such
            //check current guess against correct 
            //generate rng output based on check
            
            //update game object and repeat
    }
}