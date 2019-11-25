namespace Kata_Master_Mind.Controller
{
    public interface IInputHandler
    {
        string[] WinningStringCreator(int coloursPicked);
        string[] DefaultStringCreator(int coloursPicked);

        string[] InputFormatter(string userInput, int coloursPicked);
        
    }
}