namespace Kata_Master_Mind.Model
{
    public class CurrentGameData
    {
        private string[] currentColours;
        private string[] correctColours;
        private int turnLimit;

        public CurrentGameData(string[] correctcolours)
        { 
            correctColours = correctcolours;
            turnLimit = 60;
        }
        public CurrentGameData(string[] currentcolours, string[] correctcolours)
        {
            currentColours = currentcolours;
            correctColours = correctcolours;
            turnLimit = 60;
        }
        
        public string[] getCorrectColourList() { return correctColours; }
        
        public string[] getCurrentColourList() { return currentColours; }
        public void setCurrentColourList(string[] value) { currentColours = value; }
        
        public int getTurn() { return turnLimit; }
        public void setTurn(int turn) { turnLimit = turn; }

    }
}