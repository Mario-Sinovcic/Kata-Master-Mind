using System;
using Kata_Master_Mind.Model;

namespace Kata_Master_Mind.Controller
{
    public class GameInitializer
    {
        private readonly string[] _allColourCollection;
        private readonly int _playableColours;
        private readonly string[] _generatedColourList;

        public GameInitializer()
        {
            _allColourCollection = new[]{"RED", "BLUE", "GREEN", "ORANGE", "PURPLE", "YELLOW"};
            _playableColours = 4;
            _generatedColourList = new string[4];
            
            GenerateRandomColours();
            
            CurrentGameData gameDataObject = new CurrentGameData(_generatedColourList);
            OutputController outputController = new OutputController(gameDataObject);
            outputController.StartGame();
        }
        
        public GameInitializer(string config)
        {
//            _allColourCollection = new[]{"RED", "BLUE", "GREEN", "ORANGE", "PURPLE", "YELLOW"};
//            _playableColours = 4;
//            _generatedColourList = new string[4];
//            
//            GenerateRandomColours();
//            
//            CurrentGameData gameDataObject = new CurrentGameData(_generatedColourList);
//            OutputController outputController = new OutputController(gameDataObject);
//            outputController.StartGame();
        }
        
        

        private void GenerateRandomColours()
        {
            for (var i = 0; i < _playableColours; i++)
            {
                var rand = new Random();
                _generatedColourList[i] = _allColourCollection[rand.Next(_allColourCollection.Length)];
            }
        }
    }
}