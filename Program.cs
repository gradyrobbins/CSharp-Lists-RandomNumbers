using System;
using System.Collections.Generic;

namespace CSharp_Lists_RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
            };

            // Use a for loop to iterate over all numbers between 0 and numbers.Count - 1.
            // Inside the body of the for loop determine if the current loop index is contained inside of the numbers list. Print a message to the console indicating whether the index is in the list.
            for(int i = 0; i <= numbers.Count -1 ; i++){
                if(numbers.Contains(i)){
                    Console.WriteLine($"Numbers list has {i}");
                } else {
                    Console.WriteLine($"{numbers[i]} sucks");
                }
            }
        }
    }
}
