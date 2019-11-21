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
            var firstGuess = inputFormater(Console.ReadLine());
            _gameData.setCurrentColourList(firstGuess);
        }
        
        
        
        //check input
        //diff constructors for diff inputs
        
        //update currentGameData object
        //run outputview
    }
}