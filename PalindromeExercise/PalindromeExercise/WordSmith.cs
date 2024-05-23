using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string example)
        {
            if (string.IsNullOrEmpty(example))
            {
                return false;
            }
            else
            {
                string exampleTrim = example.Replace(" ", "").ToLower();

                return exampleTrim.SequenceEqual(exampleTrim.Reverse());

            }
        }
    }
}
