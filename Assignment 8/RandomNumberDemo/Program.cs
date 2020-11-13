using System;
using System.Linq;
using BinaryTreeImplementation;

//Ethan Smith

namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>();
            var cnt = 0;
            while (cnt < 10)
            {
                Random rnd = new Random();
                tree.Add(rnd.Next(0, 101));
                cnt++;
            }

            // print the number of words
            Console.WriteLine($"{tree.Count} numbers");

            // and print each word using the default (in-order) enumerator
            var numsInOrder = "";
            foreach (int num in tree)
            {
                Console.Write($"^{num}^ ");
            }

            Console.WriteLine();

            foreach (int num in tree.OrderBy(i => i))
            {
                numsInOrder += $"{num}, ";
            }


            Console.WriteLine($"In order: {numsInOrder}");

            Console.WriteLine();

            tree.Clear();
        }
    }
}
