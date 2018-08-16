using System;

namespace CG_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for sentence
            Console.Write("Please write a sentence: ");
            
            // convert user input into variable to call on later
            var mySentence = Console.ReadLine();
            
            // call on the variable and write it in all caps with ToUpper
            // put the user sentence on a new line under my message by using backslash n for new line :) 
            Console.WriteLine("TA-DA" + " now your sentece is all uppercase\n" + mySentence.ToUpper());
            Console.ReadLine();
        }
    }
}
