using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kata_Master_Mind.Controller
{
    public class InputValidator //uses error config
    {
        protected string checkInputForErrors(string userInput)
        {
            //string allowableLetters = "rgbopy"; //pulled from game config
            
            if (userInput.Length != 7)
            {
                return "Error: you must pass 4 colours!";
            }
            
            //Regex regex = new Regex("r|g|b|o|p|y|␣");
            foreach (char colour in userInput)
            {
                if(colour!='r'&&colour!='g'&&colour!='b'&&colour!='o'&&colour!='p'&&colour!='y'&&colour!=' ')
                //if (!(Regex.IsMatch(colour.ToString(), @"r|g|b|o|p|y|␣")))
                {
                    return "Error: you have given an invalid colour!";
                }
            }
            return "valid";
        }
        
        protected string errorHandler(string errorCode)
        {
            //implement config for this
            return "Error: you have given an invalid colour!";
        }
    }
}