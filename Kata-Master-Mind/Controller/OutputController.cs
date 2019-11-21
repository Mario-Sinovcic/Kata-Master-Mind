using System;

namespace Kata_Master_Mind
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
            Console.WriteLine(_gameData.getTurn() + "test");
        }
        
        
        
        //check input
        //diff constructors for diff inputs
        
        //update currentGameData object
        //run outputview
    }
}