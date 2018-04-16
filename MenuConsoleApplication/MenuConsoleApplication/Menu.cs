using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsoleApplication
{
    class Menu
    {
        //member variables
        UserInterface UI = new UserInterface();
        bool run = true;
        
        //constructor
        public Menu()
        {
            ProgramStart();
        }

        public void ProgramStart()
        {
            while (run)
            {              
                DisplayMenu();
                MenuSelection(UI.ObtainIntInput());
                Console.ReadKey();
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("Good Bye!");
            Console.ReadKey();
        }

        //methods
        public void DisplayMenu()
        {
            Console.WriteLine("[ MENU ]\n");
            Console.WriteLine("[1] Output Greeting");
            Console.WriteLine("[2] Repeat Me");
            Console.WriteLine("[3] Add Two Numbers");
            Console.WriteLine("[4] Random Numbers");
            Console.WriteLine("[5] Open YouTube");
            Console.WriteLine("[6] Exit\n");

            Console.WriteLine("Please enter your selection: ");

        }

        public void MenuSelection(int choice)
        {
            switch (choice)
            {
                case 1:
                    OutputGreeting();
                    break;

                case 2:
                    RepeatMe();
                    break;

                case 3:
                    AddTwoNumbers();
                    break;

                case 4:
                    RandomNumbers();
                    break;

                case 5:
                    OpenYoutube();
                    break;

                case 6:
                    Exit();
                    break;

                default:
                    Console.WriteLine("\nPlease enter a number 1 to 6.");
                    break;

            }

            
        }

        public void Exit()
        {
            run = false;
        }

        public void OpenYoutube()
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        public void RandomNumbers()
        {
            Random rnd = new Random();
            int randomNum;

            Console.Clear();
            Console.WriteLine("Your numbers are");

            for (int i = 0; i < 6; i++)
            {
                randomNum = rnd.Next(1, 101);
                Console.WriteLine(randomNum);
            }
        }

        public void AddTwoNumbers()
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("\nPlease enter your first number");
            num1 = UI.ObtainIntInput();
            Console.WriteLine("\nPlease enter your second number");
            num2 = UI.ObtainIntInput();

            num3 = num1 + num2;

            Console.WriteLine("\nThe total is: " + num3);
        }

        public void RepeatMe()
        {
            string input;

            Console.WriteLine("\nPlease enter some text\n");
            input = UI.ObtainStringInput();
            Console.WriteLine("\nYou have typed: " + input);
        }

        public void OutputGreeting()
        {
            Console.WriteLine("\nHELLO WORLD!");
        }


    }
}
