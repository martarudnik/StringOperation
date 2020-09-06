using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
