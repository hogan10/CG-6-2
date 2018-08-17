using System;
using System.Text;

namespace CG_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user to enter a sentence and hold on to the answer
            Console.WriteLine("Please type a sentence: ");
            string mySentence = Console.ReadLine();
            //use the user's input and convert it to all caps and return that on screen
            string upperSentence = mySentence.ToUpper();
            Console.WriteLine(upperSentence);
            Console.ReadLine();
           
        }
        
    }
}
