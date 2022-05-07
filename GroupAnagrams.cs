using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.Algorithms
{
    //GroupAnagrams
    public class GroupAnagrams : IAlgorithmResolver
    {
        /*
         Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

 

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
Example 2:

Input: strs = [""]
Output: [[""]]
Example 3:

Input: strs = ["a"]
Output: [["a"]]
 

Constraints:

1 <= strs.length <= 104
0 <= strs[i].length <= 100
strs[i] consists of lowercase English letters.
         */
        public override List<string[]> Solve(string[] strs)
        {
            try
            {
                //validate data
                if (1 <= strs.Length && strs.Length <= 104)
                {
                }
                else
                {
                    throw new InvalidOperationException("Invalid input");
                }
                strs.ToList().ForEach(x =>
                {
                    if (0 <= x.Length && x.Length <= 100)
                    {
                        // all good
                    }
                    else
                    {
                        throw new InvalidOperationException("Invalid input");
                    }

                });
                //perform operation
                var output = new List<string[]>();
                var sortedList = new Dictionary<string, string>();
                foreach (var item in strs)
                {
                    var word = new string(item.ToCharArray().OrderBy(x => x).ToArray());

                    sortedList.Add(item, word);
                }
                sortedList.GroupBy(x => x.Value).Select(x => {
                    output.Add(x.OrderBy(x=>x.Key).Select(x => x.Key).ToArray());
                    return output;
                }).ToList();
                Console.WriteLine( JsonConvert.SerializeObject(output.OrderBy(x => x.Count()).ToList()));

                return output.OrderBy(x => x.Count()).ToList();
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
