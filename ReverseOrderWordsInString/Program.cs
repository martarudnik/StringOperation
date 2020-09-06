using System;

namespace ReverseOrderWordsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Welcome in my project";
            StringOperationClass stringOperation = new StringOperationClass();
            string outputReverseOrderWordsInString = stringOperation.ReverseOrderWordsInString(inputString);
            Console.WriteLine(outputReverseOrderWordsInString);
            Console.ReadKey();
        }
    }
}
