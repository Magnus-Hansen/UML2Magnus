using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2Magnus
{
    public class Functions
    {
        public static int GetIntWithLimit(int limit)
        {
            string number = Console.ReadLine();
            while (!int.TryParse(number, out _) || limit < int.Parse(number) || int.Parse(number) < 1)
            {
                number = Console.ReadLine();
            }
            return int.Parse(number);
        }
        public static int GetInt()
        {
            string number = Console.ReadLine();
            while (!int.TryParse(number, out _) || int.Parse(number) < 1)
            {
                number = Console.ReadLine();
            }
            return int.Parse(number);
        }
        public static string GetString() 
        {
            //check if its a string of char
            return Console.ReadLine();
        }
    }
}
