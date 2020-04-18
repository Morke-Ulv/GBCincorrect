using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Badge_Challenge
{
    class Program
    {
        private readonly GameListRepository _repo = new GameListRepository();

        public void Run()
        {
            Seed();
            RunMenu();
        }

        private void Seed()
        {

        }

        private void RunMenu()
        {
            bool programIsRunning = true;
            while (programIsRunning)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                    "1. Show all Games played\n" +
                    "2. Show all Games on Need to play list\n" +
                    "3. Add Game to played list\n" +
                    "4. Add Game to Need to play list\n" +
                    "5. Show all Games in played and need to play\n" +
                    "6. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "6":
                        Console.WriteLine("Fare Thee Well.");
                        Console.ReadKey();
                        programIsRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void AddNewGame()
        {
            Console.Clear();
            Console.WriteLine("What is the name of the game?");
            string title = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is the Maturity Rating?");
            string
        }
    }
}
