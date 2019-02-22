using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Pause p = new Pause();
            StartStory();
            Console.WriteLine();
            Console.ResetColor();

            p.EnterChar();
            Console.WriteLine();

            Console.WriteLine("Lord Varder: Capture Cloud city...");
            Console.WriteLine();

            Console.WriteLine("Select your troops and their vehicles to attack " +
                "Cloud City and secure it for the Empire");
            Console.WriteLine();

            int assigner = MakeTroop();
            Console.WriteLine();
            Console.ResetColor();

            p.EnterChar();
            Console.WriteLine();

            Console.WriteLine("Attention: This is Lando Calrissian. " +
                "The Empire has taken control of the city!!" +
                " I advise everyone to leave before more Imperial troops arrive!");
            Console.WriteLine();

            Console.WriteLine("Your troops need to move into Cloud City.");
            Console.WriteLine();

            Console.WriteLine("Press 1 to move them into positon, Press 2 to Move different Troop type into Position");
            ChoiceOfStep(assigner);
            Console.WriteLine();

            PickVehicle(assigner);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Target acquired...");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("C-3PO:Troopers? Here? We're in danger. " +
                " I must tell the others.");
            Console.WriteLine();

            Console.WriteLine("Press any key to fire on target");
            Console.ReadKey(true);
            AssignWeapon(assigner);
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("C-3PO: oh, no! I've been shot!");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string intro = "Target Destroyed...Cloud City Belongs to Lord Vader and The Empire";
            for (int i = 0; i < intro.Length; i++)
            {
                Console.Write(intro[i]);
                System.Threading.
                Thread.Sleep(50);
            }
            Console.ResetColor();
            Console.WriteLine();

        }

        private static int ChoiceOfStep(int assigner)
        {
            string strinput = Console.ReadLine();
            int input = Convert.ToInt32(strinput);
            try
            {
                if (input == 1)
                    return assigner;
                else if (input == 2)
                    return MakeTroop();
                else
                    Console.WriteLine("Input invalid: Enter a valid number");
                return ChoiceOfStep(assigner);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input not a valid option");
                return ChoiceOfStep(assigner);
            }
        }

        private static void StartStory()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string intro = "Long Long ago In a galaxy far far away...";
            for (int i = 0; i < intro.Length; i++)
            {
                Console.Write(intro[i]);
                System.Threading.
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("Shortly after the Battle of Hoth, the members of the Rebel Alliance " +
                "(Leia, Han, Chewy and C-3PO) landed at" +
                " Cloud City to repair the Millennium Falcon."
                + " Initially greeted by Lando Calrissian, the trio ultimately fell victim to Darth " +
                "Vader's plot to capture Luke Skywalker, using his friends as bait."
                + " The Empire coerced Lando to surrender the trio to Darth Vader and the Empire. " +
                " Lando was upset by the Empire's refusal to abide by the terms of their " +
                "agreement which stipulated that Cloud City was to remain out the war."
                + " Over an intercom he warned the citizens that Imperial forces had invaded the city."
                + " After the capture of the rebels, the Empire took over Cloud City...");
        }

        private static int PickVehicle(int assigner)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (assigner == 1)
            {
                SpeederBike k = new SpeederBike();
                k.Pickup();
                k.Takeoff();
                k.Halt();
            }
            if (assigner == 2)
            {
                March g = new March();
                g.Pickup();
                Console.WriteLine("Foward!");
                g.Takeoff();
                g.Halt();
            }
            if (assigner == 3)
            {
                JetPacks j = new JetPacks();
                j.Pickup();
                Console.WriteLine("The Troopers are firing up there jet packs.");
                j.Takeoff();
                Console.WriteLine("They're landing near the target.");
                j.Halt();
            }
            Console.ResetColor();
            return assigner;
        }

        private static void AssignWeapon(int assigner)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (assigner == 1)
            {
                HeavyBlasterRifle k = new HeavyBlasterRifle();
                k.Reload();
                Console.WriteLine("Strike!");
                k.Shoot();
            }
            if (assigner == 2)
            {
                LightRepeatingBlaster g = new LightRepeatingBlaster();
                g.Reload();
                Console.WriteLine("We will not fail!");
                g.Shoot();
            }
            if (assigner == 3)
            {
                BlasterRifle j = new BlasterRifle();
                j.Reload();
                Console.WriteLine("Engage!!!");
                j.Shoot();
            }
        }

        public static int MakeTroop()
        {
            try
            {
                Console.WriteLine("Press 1 for DeathTrooper, Press 2 for StormTrooper, Press 3 for JumpTrooper");
                string strinput = Console.ReadLine();
                int input = Convert.ToInt32(strinput);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (input == 1)
                {
                    DeathTrooper k = new DeathTrooper();
                    k.SoundOff();
                    k.OrderofBattle();
                }
                else if (input == 2)
                {
                    StormTrooper g = new StormTrooper();
                    g.SoundOff();
                    g.OrderofBattle();
                }
                else if (input == 3)
                {
                    JumpTrooper j = new JumpTrooper();
                    j.SoundOff();
                    j.OrderofBattle();
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine("Input invalid: Enter a valid number");
                    return MakeTroop();
                }
                Console.ResetColor();
                return input;
            }
            catch (FormatException)
            {
                Console.WriteLine("Input not a valid option");
                return MakeTroop();
            }
        }
    }
}
