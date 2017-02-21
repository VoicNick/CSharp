using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment 1 for the Comp2614 class, Summer 2016 term
// Author: Voicu Chirtes
// Version: May 10, 2016

namespace COMP2614Assign01
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX = 20;
            int sum = 0, sumOfSquares = 0, sumOfCubes = 0;

            Console.WriteLine("  number   square     cube");
            Console.WriteLine("--------------------------");

            for(int i = 0; i <= MAX; i++)
            {
                if(i % 2 == 0)
                {
                    int square = i * i;
                    int cube = square * i;

                    Console.WriteLine("{0,8:N0} {1,8:N0} {2,8:N0}", i, square, cube);
                    sum += i;
                    sumOfSquares += square;
                    sumOfCubes += cube;
                }
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("{0,8:N0} {1,8:N0} {2,8:N0}", sum, sumOfSquares, sumOfCubes);
            Console.Read();
        }
    }
}
