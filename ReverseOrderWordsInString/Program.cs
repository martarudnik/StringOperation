using System;

namespace ReverseOrderWordsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Welcome in my project";
            string inpitPolodrome = "madam";
            string inputString1 = "abcd";
            string inputString2 = "hello world";

            StringOperationClass stringOperation = new StringOperationClass();

            string outputReverseOrderWordsInString = stringOperation.ReverseOrderWordsInString(inputString);
            bool outputPolidrome = stringOperation.CheckIfPalindrome(inpitPolodrome);
            string outputReverseString = stringOperation.ReverseString(inputString);
            string possibleSubstringInString = stringOperation.PossibleSubstringInString(inputString1);
            string removeDuplicateCharactersInString = stringOperation.RemoveDuplicateCharactersInString(inputString);
            string countTheOccurrenceEachCharacterInString = stringOperation.CountTheOccurrenceEachCharacterInString(inputString2);

            Console.WriteLine(outputReverseOrderWordsInString);
            Console.WriteLine(outputPolidrome);
            Console.WriteLine(outputReverseString);
            Console.WriteLine(possibleSubstringInString);
            Console.WriteLine(removeDuplicateCharactersInString);
            Console.WriteLine(countTheOccurrenceEachCharacterInString);

            Console.ReadKey();
        }
    }
}
