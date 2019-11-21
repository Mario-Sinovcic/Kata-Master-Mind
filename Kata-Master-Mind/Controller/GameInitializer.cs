using System;
using Kata_Master_Mind.Model;

namespace Kata_Master_Mind.Controller
{
    public class GameInitializer
    {
        private string[] _allColourCollection;
        private int _playableColours;
        private string[] _generatedColourList;

        public GameInitializer()
        {
            _allColourCollection = new[]{"RED", "BLUE", "GREEN", "ORANGE", "PURPLE", "YELLOW"};
            _playableColours = 4;
            _generatedColourList = new string[4];
            
            GenerateRandomColours();
            
            CurrentGameData gameDataObject = new CurrentGameData(_generatedColourList);
            OutputController outputController = new OutputController(gameDataObject);
            outputController.startGame();
        }

        private void GenerateRandomColours()
        {
            for (int i = 0; i < _playableColours; i++)
            {
                Random rand = new Random();
                _generatedColourList[i] = _allColourCollection[rand.Next(_allColourCollection.Length)];
            }
        }
    }
}