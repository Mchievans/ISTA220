using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 11;
            numbers[1] = 22;
            numbers[2] = 33;
            numbers[3] = 44;
            numbers[4] = 55;

            int len = numbers.Length;
            Console.WriteLine($"variable len has the value {len}");
            Console.WriteLine($"this is the for loop");
            for (int i = 0; i < len; i++)
            {
               // Console.WriteLine($"element {i} is {numbers[i]}");
                //Console.WriteLine($"element {i % 2} is {numbers[i % 2]}");
                //Console.WriteLine($"element {i} is {numbers[i % 3]}");
                //Console.WriteLine($"element {i} is {numbers[i % 5]}");
                Console.WriteLine($"element {i} is {numbers[(i + 2) % 5]}");
            }

            Console.WriteLine("this is a foreach loop");
            foreach (int e in numbers)
            {
                Console.WriteLine($"element is {e}");
            }

            Console.WriteLine($"variable len has the value {len}");
            Console.WriteLine($"this is the for loop");
            for (int i = --len; i >= 0; i--)
            {
                Console.WriteLine($"element {i} is {numbers[i]}");
                //Console.WriteLine($"element {i % 2} is {numbers[i % 2]}");
                //Console.WriteLine($"element {i} is {numbers[i % 3]}");
                //Console.WriteLine($"element {i} is {numbers[i % 5]}");
            }

        }
    }
}
