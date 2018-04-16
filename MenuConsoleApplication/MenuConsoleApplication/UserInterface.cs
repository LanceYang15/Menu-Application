using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsoleApplication
{
    class UserInterface
    {
        //member variables
        string userString;
        int userInt;

        //constructor

        //methods
        public string ObtainStringInput()
        {
            userString = Console.ReadLine();

            return userString;
        }

        public int ObtainIntInput()
        {
            userString = Console.ReadLine();
            userString = string.Join("", userString.ToCharArray().Where(char.IsDigit));
            userInt = Convert.ToInt32(userString);

            return userInt;
        }
    }
}
