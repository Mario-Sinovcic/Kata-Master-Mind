using System;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void StartGame()
        {
            firstUserPrompt();
            for(var i = 0; i <_gameData.getTurn(); i++ ) 
            {
                var currentUserInput = Console.ReadLine();
                var errorCode = checkInputForErrors(currentUserInput.ToLower().Trim());
                
                if (errorCode == "valid")
                {
                    var firstGuess = InputFormater(currentUserInput);
                    _gameData.setCurrentColourList(firstGuess);

                    var result = CalculateResult();
                    if (ConvertStringArrayToString(result).Equals(ConvertStringArrayToString(_winningOutput)))
                    {
                        generateWin();
                        break;
                    }
                    promptUser(result);
                    foreach (var dee in _gameData.getCorrectColourList())
                    {
                        Console.WriteLine(dee);
                    }
                }
                else
                {
                    //errorHandler(errorCode);
                    promptUser(errorCode);
                }
            }
        }

        private string[] CalculateResult()
        {
            string[] guessOutput = new string[]{"w","w","w","w"};
            var pos = 0;
            
            for(var i=0;i<_gameData.getCurrentColourList().Length;i++) //(string colourGuess in _gameData.getCurrentColourList())
            {
                var colourGuess = _gameData.getCurrentColourList()[i];
                if (!colourGuess.Equals(_gameData.getCorrectColourList()[i])) continue;
                guessOutput[pos] = "b"; 
                pos++;
            }
            var rnd=new Random();
            return guessOutput.OrderBy(x => rnd.Next()).ToArray();  ;
        }
        
        static string ConvertStringArrayToString(string[] array)
        {
            
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }
    }
}