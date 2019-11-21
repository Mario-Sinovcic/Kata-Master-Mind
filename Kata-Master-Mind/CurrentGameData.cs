namespace Kata_Master_Mind
{
    public class CurrentGameData
    {
        private string[] currentColours;
        private string[] correctColours;
        private int turnCounter;
        
        public CurrentGameData(string[] correctcolours)
        {
            correctColours = correctcolours;
            turnCounter = 0;

        }
        public CurrentGameData(string[] currentcolours, string[] correctcolours)
        {
            currentColours = currentcolours;
            correctColours = correctcolours;
            turnCounter = 1;
        }
        
        public string[] getCorrectColourList() { return correctColours; }
        
        public string[] getCurrentColourList() { return currentColours; }
        public void setCurrentColourList(string[] value) { currentColours = value; }
        
        public int getTurn() { return turnCounter; }
        public void setTurn(int turn) { turnCounter = turn; }

    }
}