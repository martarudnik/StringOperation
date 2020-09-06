using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ReverseOrderWordsInString
{
    public class StringOperationClass
    {
        public string ReverseOrderWordsInString(string input)
        {
            StringBuilder output = new StringBuilder();
            var splitArray = input.Split(' ');

            for (int i = splitArray.Length - 1; i < splitArray.Length; i--)
            {
                if (i >= 0)
                {
                    output.Append(splitArray[i] + ' ');
                }
            }

            return output.ToString();
        }
        public bool CheckIfPalindrome(string input)
        {
            for (int i = 0, j = input.Length - 1; i < input.Length / 2; i++, j--)
            {
                if (input[i] == input[j])
                {
                    return true;
                }
            }
            return false;
        }
        public string ReverseString(string input)
        {
            var inputArray = input.ToCharArray();
            StringBuilder output = new StringBuilder();
            for (int i = inputArray.Length - 1; i < inputArray.Length; i--)
            {
                if (i >= 0)
                    output.Append(inputArray[i]);
            }
            return output.ToString();
        }
        public string PossibleSubstringInString(string input)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < input.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(input.Length - i);
                for (int j = i; j < input.Length; ++j)
                {
                    subString.Append(input[j]);
                    output.Append(subString + " ");
                }
            }
            return output.ToString();
        }
        public string RemoveDuplicateCharactersInString(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }
        public string CountTheOccurrenceEachCharacterInString(string input)
        {
            StringBuilder output = new StringBuilder();
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }
            }

            foreach (var character in characterCount)
            {
                output.AppendFormat("{0} - {1} {2}", character.Key, character.Value, Environment.NewLine);
            }

          return output.ToString();
        }
    }
}