using System;
using System.Collections.Generic;
using System.Text;

namespace permutator
{
    public interface IPermutator <T>{
        List<T[]> GetPermutations { get; }
        void Permutate(int swapPosition);
        int GetNumOfPerms { get; }
        int Factorial(int n);
    }
}
