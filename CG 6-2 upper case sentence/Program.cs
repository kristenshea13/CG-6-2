using System;

namespace CG_6_2_upper_case_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user to type sentence
            Console.Write("Please type a sentence: ");

            //declare variable as string, input user sentence and convert to uppercase
            string userSentence = Console.ReadLine().ToUpper();
            
            //print it to console
            Console.WriteLine(userSentence);

            Console.ReadLine();

        }
    }
}
