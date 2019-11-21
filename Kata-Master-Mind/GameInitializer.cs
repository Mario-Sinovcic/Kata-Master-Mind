using System;

namespace Kata_Master_Mind
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
        }
        
        private void GenerateRandomColours()
        {
            for (int i = 0; i < _playableColours; i++)
            {
                Random rand = new Random();
                _generatedColourList[i] = _allColourCollection[rand.Next(_allColourCollection.Length)];
            }
            
            foreach(var item in _generatedColourList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}