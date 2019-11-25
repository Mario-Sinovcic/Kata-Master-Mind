using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Kata_Master_Mind.Model;
using Newtonsoft.Json;

namespace Kata_Master_Mind.Controller
{
    public class GameInitializer
    {
        private readonly string[] _allColourCollection;
        private readonly int _playableColours;
        private readonly string[] _generatedColourList;
        private GameRuleConfig _configFile;

        public GameInitializer(string configPath)
        {
            LoadJson(configPath);
            _allColourCollection = _configFile.ColourList;
            _playableColours = _configFile.TotalColoursPicked;
            _generatedColourList = new string[_playableColours];
            GenerateRandomColours();
            
            var gameDataObject = new CurrentGameData(_generatedColourList,_playableColours ,_configFile.TurnLimit);
            var outputController = new OutputController(gameDataObject);
            outputController.StartGame();
        }
        
        private void LoadJson(string path)
        {
            using var r = new StreamReader(path);
            var json = r.ReadToEnd();
            _configFile = JsonConvert.DeserializeObject<List<GameRuleConfig>>(json).First();
            Console.Write(_configFile.ColourList[2]);
        }

        private class GameRuleConfig
        {
            public string[] ColourList { get; set; }
            public int TotalColoursPicked { get; set; }
            public int TurnLimit { get; set; }
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