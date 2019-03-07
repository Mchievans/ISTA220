using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "one";
            string two = "two";
            string three = "three";

            Stack<string> Stacks = new Stack<string>();
            Stacks.Push(one);
            Stacks.Push(two);
            Stacks.Push(three);

            Queue<string> Queues = new Queue<string>();
            Queues.Enqueue(one);
            Queues.Enqueue(two);
            Queues.Enqueue(three);

            Dictionary<string, int> Diction = new Dictionary<string, int>();
            Diction.Add(one, 1);
            Diction.Add(two, 2);
            Diction.Add(three, 3);

            Console.WriteLine("This is test 09");
            Console.WriteLine("Here if the stack");
            foreach (string x in Stacks)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Here is the Queue");
            foreach (string y in Queues)
            {
                Console.WriteLine(y);
            }

            Console.WriteLine("Here is the Dictionary");
            foreach (KeyValuePair<String, int> z in Diction)
            {
                Console.WriteLine(z);
            }
                                 
        }
    }
}
