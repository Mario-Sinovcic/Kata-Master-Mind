using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kata_Master_Mind.Model;
using Kata_Master_Mind.View;

namespace Kata_Master_Mind.Controller
{
    public class OutputController : InputHandler
    {
        private readonly CurrentGameData _gameData;
        private OutputGenerator _outputGenerator;
        private readonly string[] _winningOutput = {"b", "b", "b", "b"};
        
        public OutputController(CurrentGameData gameData)
        {
            _gameData = gameData;
            _outputGenerator = new OutputGenerator();
        }

        public void StartGame()
        {
            OutputGenerator.FirstUserPrompt();
            for(var i = 0; i <_gameData.GetTurn(); i++ ) 
            {
                var currentUserInput = Console.ReadLine();
                if (currentUserInput == null) continue;
                var errorCode = CheckInputForErrors(currentUserInput.ToLower().Trim());
                
                if (errorCode == "valid")
                {
                    var firstGuess = InputFormatter(currentUserInput);
                    _gameData.SetCurrentColourList(firstGuess);

                    var result = CalculateResult();
                    if (ConvertStringArrayToString(result).Equals(ConvertStringArrayToString(_winningOutput)))
                    {
                        OutputGenerator.GenerateWin();
                        break;
                    }
                    _outputGenerator.PromptUser(result);
                    foreach (var dee in _gameData.GetCorrectColourList())
                    {
                        Console.WriteLine(dee);
                    }
                }
                else
                {
                    _outputGenerator.PromptUser(errorCode);
                }
            }
        }

        private string[] CalculateResult()
        {
            var guessOutput = new[]{"w","w","w","w"};
            var pos = 0;
            
            for(var i=0;i<_gameData.GetCurrentColourList().Length;i++) 
            {
                var colourGuess = _gameData.GetCurrentColourList()[i];
                if (!colourGuess.Equals(_gameData.GetCorrectColourList()[i])) continue;
                guessOutput[pos] = "b"; 
                pos++;
            }
            var rnd=new Random();
            return guessOutput.OrderBy(x => rnd.Next()).ToArray();  ;
        }
        
        static string ConvertStringArrayToString(IEnumerable<string> array)
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