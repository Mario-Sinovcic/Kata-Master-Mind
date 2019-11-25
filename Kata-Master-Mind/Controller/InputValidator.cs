using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kata_Master_Mind.Controller
{
    public abstract class InputValidator 
    {
        public static string CheckInputForErrors(string userInput, int coloursPicked)
        {
            if (userInput.Length != (coloursPicked + coloursPicked - 1))
            {
                return "Error: you must pass 4 colours!";
            }
            
            return userInput.Any(colour => colour!='r'&&colour!='g'&&colour!='b'&&colour!='o'&&colour!='p'&&colour!='y'&&colour!=' ') ? "Error: you have given an invalid colour!" : "valid";
        }
    }
}