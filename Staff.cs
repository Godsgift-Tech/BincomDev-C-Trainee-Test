using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BincomDev_C__Trainee_Test
{
    internal class Staff
    {
        static string Name = "John Doe";
        static int Age = 25;
        static bool isAdmin = true;

        // PrintStaffDetails is the method to print the details of the declared fields above.
        public static void PrintStaffDetails()
        {
            Console.WriteLine($" Name: {Name},   Age: {Age},   IsAdmin: {isAdmin} ");

            Console.WriteLine("***********************************************************************");

        }

        public static void Greet(string name)
        {
            Console.WriteLine("Hello ! " + name);
        }
    }
}
