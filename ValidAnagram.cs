using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Test.Algorithms
{
    /*
     Given two strings s and t, return true if t is an anagram of s, and false otherwise.

    An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
    typically using all the original letters exactly once.

 

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false
 

Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.
     */
    public class ValidAnagram : IAlgorithmResolver
    {

        public override bool Solve(string word, string anagramWord)
        {
            try
            {
                //validate
                IList<string> inputs = new List<string>() { word, anagramWord };
                inputs.ToList().ForEach(item =>
                {
                    if (item.Length <= 1 || item.Length >= 5 * 104)
                        throw new Exception("Invalid world");
                });
                Array.Sort(word.ToCharArray());
                var wordSorted = word.ToLower().ToCharArray().OrderBy(x => x);
                var anagramWordSorted = anagramWord.ToLower().ToCharArray().OrderBy(x => x);
                bool answer = wordSorted.SequenceEqual(anagramWordSorted);
                if (answer)
                {
                    Console.WriteLine($"{anagramWord}=> is anagram of {word}");
                }
                else
                {
                    Console.WriteLine($"{anagramWord}=> is not anagram of {word}");

                }
                return answer;
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
