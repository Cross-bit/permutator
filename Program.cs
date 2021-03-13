using System;
using System.Collections;
using System.Collections.Generic;

namespace permutator
{
    class Car{
        public string color = "";
        public Car(string color) {
            this.color = color;
        }
    }

    class Program
    {
        static void Main(string[] args) {

            /*IPermutator<Car> permutator = new Permutator<Car>(new Car[3] { new Car("R"), new Car("G"), new Car("B") });
            List<Car[]> permutations = permutator.GetPermutations;
            Console.WriteLine(permutator.GetNumOfPerms);

            foreach (var item in permutations){
                Array.ForEach(item, i => Console.Write(" : " + i.color + " : "));
                Console.WriteLine();
            }*/

        }
    }
}
