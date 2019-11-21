using System;

namespace Kata_Master_Mind
{
    public class OutputView
    {
        //default output "no errors"
        public OutputView()
        {
            
        }
        
        //default output "no errors"
        public OutputView(int errorCode)
        {
            
        }

        public void drawHorizontalLine()
        {
            Console.WriteLine("- -- -- -- -- -\n");
        }

        public void gameHeader()
        {
            Console.WriteLine("Turns: \n");
        }
    }
}