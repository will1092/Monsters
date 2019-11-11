using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    // **************************************************
    //
    // Title: Monsters
    // Description: Demonstration of classes and objects
    // Author: Velis, John
    // Dated Created: 11/11/2019
    // Last Modified: 
    //
    // **************************************************    
    class Program
    {
        static void Main(string[] args)
        {
            List<Monster> monsters = new List<Monster>();

            //
            // create (instantiate) monsters
            //
            Monster sid = new Monster();
            Monster lucy = new Monster();

            //
            // set monster property values
            //
            sid.Name = "Sid";
            sid.Age = 150;
            sid.Attitude = Monster.EmotionalState.happy;

            lucy.Name = "Lucy";
            lucy.Age = 132;
            lucy.Attitude = Monster.EmotionalState.bored;

            //
            // add monsters to the list
            //
            monsters.Add(sid);
            monsters.Add(lucy);

            //
            // call methods
            //
            DisplayMenuScreen(monsters);

        }

        static void DisplayMenuScreen(List<Monster> monsters)
        {
            bool quitApplication = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("a) List All Monsters");
                Console.WriteLine("b) Add Monster");
                Console.WriteLine("c) ");
                Console.WriteLine("d) ");
                Console.WriteLine("e) ");
                Console.WriteLine("f) ");
                Console.WriteLine("q) Quit");
                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayAllMonsters(monsters);
                        break;

                    case "b":
                        DisplayAddMonster(monsters);
                        break;

                    case "c":

                        break;

                    case "d":

                        break;

                    case "e":

                        break;

                    case "f":

                        break;

                    case "q":
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }


            } while (!quitApplication);
        }

        static void DisplayAddMonster(List<Monster> monsters)
        {
            Monster newMonster = new Monster();

            DisplayScreenHeader("Add Monster");

            Console.Write("Name: ");
            newMonster.Name = Console.ReadLine();

            Console.Write("Age: ");
            int.TryParse(Console.ReadLine(), out int age);
            newMonster.Age = age;

            Console.Write("Attitude: ");
            Enum.TryParse(Console.ReadLine(), out Monster.EmotionalState attitude);
            newMonster.Attitude = attitude;

            //
            // echo monster properties
            //


            DisplayContinuePrompt();

            monsters.Add(newMonster);
        }
        static void DisplayAllMonsters(List<Monster> monsters)
        {
            DisplayScreenHeader("All Monsters");
            Console.WriteLine("***************************************");
            foreach (Monster monster in monsters)
            {
                Console.WriteLine($"\tName: {monster.Name}");
                Console.WriteLine($"\tAge: {monster.Age}");
                Console.WriteLine($"\tAttitude: {monster.Attitude}");
                Console.WriteLine();
                Console.WriteLine("***************************************");
            }

            DisplayContinuePrompt();
        }

        #region HELPER METHODS

        /// <summary>
        /// display welcome screen
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThe Calculator");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using the Calculator!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}
