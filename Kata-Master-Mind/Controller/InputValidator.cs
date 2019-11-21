namespace Kata_Master_Mind.Controller
{
    public class InputValidator //uses error config
    {
        protected string checkInputForErrors(string userInput)
        {
            if (userInput.Length != 7)
            {
                return "inputLengthError";
            }
            
//            string allowableLetters = "rgbopy"; //pulled from game config
//
//            foreach(char c in userInput)
//            {
//                if (!allowableLetters.Contains(c.ToString()))
//                    return "invalidColour";
//            }
//            return "valid";
            return "valid";

        }
        
        protected string errorHandler(string errorCode)
        {
            //implement config for this
            return "Error: you have given an invalid colour!";
        }
    }
}