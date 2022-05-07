using System.Collections;
using System.Collections.Generic;

namespace Test.Algorithms
{
    class Program : ProgramBase
    {

        static void Main(string[] args)
        {
            var Service = new ProgramBase();
            var algo  = (IAlgorithmResolver)Service.Builder().GetService(typeof(IAlgorithmResolver));
            IEnumerable algo1 = Service.GetServices<IAlgorithmResolver>();
             
            
            algo.Solve<bool, int[]>(new int[] { 1, 2, 8,8, 5 });

            foreach (var item in algo1)
            {
                var solver = (IAlgorithmResolver)item;
                if (item.GetType() == typeof(ContainsDuplicate))
                {

                    solver.Solve<bool, int[]>(new int[] { 1, 2, 3, 4, 5 });
                }
                if (item.GetType() == typeof(ValidAnagram))
                {
                    solver.Solve("anagram","nagrama");

                }
                if (item.GetType() == typeof(TwoSum))
                {
                    solver.Solve(new[] {1,20,99,100,2,7,11 },9);

                }
                if (item.GetType() == typeof(GroupAnagrams))
                {
                    solver.Solve(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

                }
            }
        }
    }
}
