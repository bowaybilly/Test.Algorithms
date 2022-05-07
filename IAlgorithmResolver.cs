using System.Collections.Generic;

namespace Test.Algorithms
{
    public abstract class IAlgorithmResolver : ISolver
    {
        public virtual bool Solve<T, U>(U input) =>false;
        public virtual bool Solve(string word, string anagramWord) => false;
        public virtual int[] Solve(int[] nums, int target) => default;
        public virtual List<string[]> Solve(string[] inputs) => default;
    }
}