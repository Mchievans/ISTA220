using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my Animal Farm.");
            Chicken ricky = new Chicken();
            string sound = ricky.Talk();
            string eat = ricky.Eat();
            Console.WriteLine($"My name is {ricky.name1}");
            Console.WriteLine($"{ricky.name1} says {sound}");           
            Console.WriteLine($"{ricky.name1} eats ({eat})");
            Console.WriteLine();

            Chicken number2 = new Chicken();
            Console.WriteLine($"My name is {number2.name2}");
            Console.WriteLine($"{number2.name2} says {sound}");
            Console.WriteLine($"{number2.name2} eats ({eat})");
            Console.WriteLine();

            Chicken number3 = new Chicken();
            Console.WriteLine($"My name is {number3.name3}");
            Console.WriteLine($"{number3.name3} says {sound}");
            Console.WriteLine($"{number3.name3} eats ({eat})");
            Console.WriteLine();

            Chicken number4 = new Chicken();
            Console.WriteLine($"My name is {number4.name4}");
            Console.WriteLine($"{number4.name4} says {sound}");
            Console.WriteLine($"{number4.name4} eats ({eat})");
            Console.WriteLine();
        
            NinjaTurtle L = new NinjaTurtle();
            string turtleSound = L.Talk();
            string turtleEat = L.Eat();
            Console.WriteLine($"My name is {L.name1}");
            Console.WriteLine($"{L.name1} says {turtleSound}");
            Console.WriteLine($"{L.name1} eats ({turtleEat})");
            Console.WriteLine();

            NinjaTurtle D = new NinjaTurtle();           
            Console.WriteLine($"My name is {D.name2}");
            Console.WriteLine($"{D.name2} says {turtleSound}");
            Console.WriteLine($"{D.name2} eats ({turtleEat})");
            Console.WriteLine();

            NinjaTurtle R = new NinjaTurtle();
            Console.WriteLine($"My name is {R.name3}");
            Console.WriteLine($"{R.name3} says {turtleSound}");
            Console.WriteLine($"{R.name3} eats ({turtleEat})");
            Console.WriteLine();

            NinjaTurtle M = new NinjaTurtle();
            Console.WriteLine($"My name is {M.name4}");
            Console.WriteLine($"{M.name4} says {turtleSound}");
            Console.WriteLine($"{M.name4} eats ({turtleEat})");
            Console.WriteLine();

            BigDogs dog1 = new BigDogs();
            string dogSound = dog1.Talk();
            string dogEat = dog1.Eat();
            Console.WriteLine($"My name is {dog1.name1}");
            Console.WriteLine($"{dog1.name1} says {dogSound}");
            Console.WriteLine($"{dog1.name1} eats ({dogEat})");
            Console.WriteLine();

            BigDogs dog2 = new BigDogs();
            Console.WriteLine($"My name is {dog2.name2}");
            Console.WriteLine($"{dog2.name2} says {dogSound}");
            Console.WriteLine($"{dog2.name2} eats ({dogEat})");
            Console.WriteLine();

            BigDogs dog3 = new BigDogs();
            Console.WriteLine($"My name is {dog3.name3}");
            Console.WriteLine($"{dog3.name3} says {dogSound}");
            Console.WriteLine($"{dog3.name3} eats ({dogEat})");
            Console.WriteLine();

            BigDogs dog4 = new BigDogs();
            Console.WriteLine($"My name is {dog4.name4}");
            Console.WriteLine($"{dog4.name4} says {dogSound}");
            Console.WriteLine($"{dog4.name4} eats ({dogEat})");
            Console.WriteLine();

            Squirrels s1 = new Squirrels();
            string squSound = s1.Talk();
            string squEat = s1.Eat();
            Console.WriteLine($"My name is {s1.name1}");
            Console.WriteLine($"{s1.name1} says {squSound}");
            Console.WriteLine($"{s1.name1} eats ({squEat})");
            Console.WriteLine();

            Squirrels s2 = new Squirrels();
            Console.WriteLine($"My name is {s2.name2}");
            Console.WriteLine($"{s2.name2} says {squSound}");
            Console.WriteLine($"{s2.name2} eats ({squEat})");
            Console.WriteLine();

            Squirrels s3 = new Squirrels();
            Console.WriteLine($"My name is {s3.name3}");
            Console.WriteLine($"{s3.name3} says {squSound}");
            Console.WriteLine($"{s3.name3} eats ({squEat})");
            Console.WriteLine();

            Squirrels s4 = new Squirrels();
            Console.WriteLine($"My name is {s4.name4}");
            Console.WriteLine($"{s4.name4} says {squSound}");
            Console.WriteLine($"{s4.name4} eats ({squEat})");
            Console.WriteLine();
        }

    }
}
