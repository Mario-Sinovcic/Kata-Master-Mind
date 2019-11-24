using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kata_Master_Mind.Controller
{
    public class InputValidator //uses error config
    {
        protected static string CheckInputForErrors(string userInput)
        {
            if (userInput.Length != 7)
            {
                return "Error: you must pass 4 colours!";
            }
            
            
            return userInput.Any(colour => colour!='r'&&colour!='g'&&colour!='b'&&colour!='o'&&colour!='p'&&colour!='y'&&colour!=' ') ? "Error: you have given an invalid colour!" : "valid";
        }
    }
}