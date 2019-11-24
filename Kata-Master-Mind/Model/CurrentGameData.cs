namespace Kata_Master_Mind.Model
{
    public class CurrentGameData
    {
        private string[] _currentColours;
        private readonly string[] _correctColours;
        private int _turnLimit;

        public CurrentGameData(string[] correctcolours)
        { 
            _correctColours = correctcolours;
            _turnLimit = 60;
        }
        public CurrentGameData(string[] currentcolours, string[] correctcolours)
        {
            _currentColours = currentcolours;
            _correctColours = correctcolours;
            _turnLimit = 60;
        }
        
        public string[] GetCorrectColourList() { return _correctColours; }
        
        public string[] GetCurrentColourList() { return _currentColours; }
        public void SetCurrentColourList(string[] value) { _currentColours = value; }
        
        public int GetTurn() { return _turnLimit; }
        public void SetTurn(int turn) { _turnLimit = turn; }

    }
}