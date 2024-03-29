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
        private readonly string[] _winningOutput;
        private int _turnCounter;
        
        public OutputController(CurrentGameData gameData)
        {
            _gameData = gameData;
            _turnCounter = 0;
            _winningOutput = WinningStringCreator(_gameData.GetColoursPicked());
        }

        public void StartGame()
        {
            OutputGenerator.FirstUserPrompt();
            while(_gameData.GetTurn()< _gameData.GetTurnLimit()) 
            {
                var currentUserInput = Console.ReadLine();
                if (currentUserInput == null) continue;
                var errorCode = InputValidator.CheckInputForErrors(currentUserInput.ToLower().Trim(), _gameData.GetColoursPicked());
                
                if (errorCode == "valid")
                {
                    var currentGuess = InputFormatter(currentUserInput, _gameData.GetColoursPicked());
                    _gameData.SetCurrentColourList(currentGuess);

                    var result = CalculateResult();
                    if (ConvertStringArrayToString(result).Equals(ConvertStringArrayToString(_winningOutput)))
                    {
                        OutputGenerator.GenerateWin();
                        return;
                    }
                    _turnCounter++;
                    _gameData.SetTurn(_turnCounter);
                    OutputGenerator.PromptUser(result, _gameData.GetTurn());
                }
                else
                {
                    OutputGenerator.PromptUser(errorCode, _gameData.GetTurn());
                }
            }
            OutputGenerator.GenerateLoss(_gameData.GetTurnLimit());
        }

        private string[] CalculateResult()
        {
            var guessOutput = DefaultStringCreator(_gameData.GetColoursPicked());
            var position = 0;
            
            for(var i=0;i<_gameData.GetCurrentColourList().Length;i++) 
            {
                var colourGuess = _gameData.GetCurrentColourList()[i];
                if (!colourGuess.Equals(_gameData.GetCorrectColourList()[i])) continue;
                guessOutput[position] = "b"; 
                position++;
            }
            var rnd=new Random();
            return guessOutput.OrderBy(x => rnd.Next()).ToArray();  ;
        }

        private static string ConvertStringArrayToString(IEnumerable<string> array)
        {
            
            StringBuilder builder = new StringBuilder();
            foreach (var value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }
    }
}