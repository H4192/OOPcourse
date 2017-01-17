using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourse
{
    class Labra2 : MenuItem
    {
        new static string name = "Labra2 Tehtävät";
        public Labra2() : base(name)
        {}

        public override void MainF()
        {
            List<Action> list = new List<Action>();
            list.Add(() => ExOne());
            
            while (true)
            {
                Console.Title = "Labra2 tehtävät";
                Console.Clear();
                Console.WriteLine("--- Labra2 tehtävät ---");
                Console.WriteLine("Write '.exit' to end this program");

                int choise = 0;
                Console.WriteLine("0: Exercise 1");
                Console.Write("Choose exercise number: ");
                string userInput = Console.ReadLine();
                if (userInput == ".exit") break;

                if (int.TryParse(userInput, out choise))
                {
                    if (choise > -1 && choise < list.Count) list[choise]();                            
                }
            }
        }

        void ExOne()
        {
            Console.Title += " -- Exercise 1";
            Console.Clear();
            string[] numberNames = { "nolla", "yksi", "kaksi", "kolme", "neljä", "viisi" };
            int number = 0;
            Console.WriteLine("Write '.exit' to end this program");
            while (true)
            {
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();
                if (userInput == ".exit") break;
                if (int.TryParse( userInput, out number))
                {
                    if(number >= 0 && number < 6)
                    {
                        Console.WriteLine("You entered number " + numberNames[number]);

                    }
                    else
                    {
                        Console.WriteLine("I have no word for that number;");
                    }
                }
                else
                {
                    Console.WriteLine("That's not a number, let's try that again.");
                }
            }

        }
    }
}
