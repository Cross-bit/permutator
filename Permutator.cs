using System;
using System.Collections.Generic;
using System.Text;

namespace permutator
{
    public class Permutator<T> : IPermutator<T>
    {
        private T[] _arr;

        private List<T[]> _permutations = new List<T[]>();

        public List<T[]> GetPermutations { get {
                if (_permutations.Count == 0) {
                    Permutate(0);
                }
                return _permutations;
            } private set { _permutations = value; } }

        private int _factorial = 0;

        public int GetNumOfPerms { 
            get { 
                if (_factorial == 0) 
                    _factorial = Factorial(_arr.Length);
                return _factorial;
            } private set {_factorial = value;}}

        public Permutator(T[] toPermutate) {
            this._arr = toPermutate;
        }

        public void Permutate(int swapPosition = 0) {
            if (swapPosition == _arr.Length - 1) {
                addPermutationToList();
                return;
            }

            for (int i = swapPosition; i < _arr.Length; i++) {
                (_arr[swapPosition], _arr[i]) = (_arr[i], _arr[swapPosition]);
                Permutate(swapPosition + 1);
                (_arr[swapPosition], _arr[i]) = (_arr[i], _arr[swapPosition]);
            }
        }

        private void addPermutationToList() {
            var arrTemp = new T[_arr.Length];
            _arr.CopyTo(arrTemp, 0);
            _permutations.Add(arrTemp);
        }

        public int Factorial(int n) => (n <= 1) ? n : Factorial(n - 1) * n;
    }
}
