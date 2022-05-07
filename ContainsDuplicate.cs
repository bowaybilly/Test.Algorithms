using System;
using System.Linq;

namespace Test.Algorithms
{
    /*
      Given an integer array nums, return true if any value appears
      at least twice in a the array, and return false if every element
      is distinct
     */
    public   class ContainsDuplicate : IAlgorithmResolver 
    {
        public override  bool  Solve<T, U>(U nums)
        {
            int[] intArr = nums as int[];
            bool isDuplicate = intArr.Distinct().Count() != intArr.Count();
            if (isDuplicate)
            {
                Console.WriteLine(true + "==> is Duplicate");
                return true;
            }
            else
            {
                Console.WriteLine(false+ "==> is Not Duplicate");
                return false;
            }


        }

        
    }
}
