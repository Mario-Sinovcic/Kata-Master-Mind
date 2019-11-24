namespace Kata_Master_Mind.Model
{
    public class CurrentGameData
    {
        private string[] _currentColours;
        private readonly string[] _correctColours;
        private readonly int _turnLimit;
        private int _currentTurn;

        public CurrentGameData(string[] correctcolours, int turnLimit)
        { 
            _correctColours = correctcolours;
            _turnLimit = turnLimit;
            _currentTurn = 0;
        }

        
        public string[] GetCorrectColourList() { return _correctColours; }
        
        public string[] GetCurrentColourList() { return _currentColours; }
        public void SetCurrentColourList(string[] value) { _currentColours = value; }
        
        public int GetTurn() { return _currentTurn; }
        public void SetTurn(int turn) { _currentTurn = turn; }
        
        public int GetTurnLimit() { return _turnLimit; }
    }
}