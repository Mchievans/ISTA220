using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
    public class Pause
    {
        public void EnterChar()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press any Key to Continue....");
            Console.ReadKey(true);
            Console.ResetColor();
        }
    }
}
