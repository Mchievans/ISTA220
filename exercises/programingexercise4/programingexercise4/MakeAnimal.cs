using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise4
{
    public class MakeAnimal
    {
        public MakeAnimal()
        {

        }

       public void MakeChicken(Chicken a)
        {
            /*Chicken rusty = new Chicken();
            string food = a.Eat();
            string talk = a.Talk();
            return Console.WriteLine($"I say {talk} and I like to eat {food}");
            //Console.WriteLine($"{food}"); */
        }

        public void MakeNinja(NinjaTurtle a)
        {
            string food = a.Eat();
            string talk = a.Talk();
            Console.WriteLine($"I say {talk}");
            Console.WriteLine($"{food}");
        }

        public void MakeDog(BigDogs a)
        {
            string food = a.Eat();
            string talk = a.Talk();
            Console.WriteLine($"I say {talk}");
            Console.WriteLine($"{food}");
        }

        public void MakeSquirrel(Squirrels a)
        {
            string food = a.Eat();
            string talk = a.Talk();
            Console.WriteLine($"I say {talk}");
            Console.WriteLine($"{food}");
        }
    }
}
