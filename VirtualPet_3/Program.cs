using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;


namespace VirtualPet_3
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet Ranger = new VirtualPet();


            {   //begin user interaction
                Console.WriteLine("Ranger's current health stats are: ");
                Ranger.DogInfo();

                List<string> careOptions = new List<string>();
                careOptions.Add("1. Feed");
                careOptions.Add("2. Water");
                careOptions.Add("3. Give Insulin shot");

                for (int i = 0; i < 5; i++) //loop will print options, read input, and adjust variables accordingly
                {
                    foreach (string option in careOptions)
                    {
                        Console.WriteLine(option);
                    }

                    Console.WriteLine("Enter the number for the task you want to perform. Press any other key to quit.");
                    string userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        Ranger.FeedDog();   //will adjust stats and
                        Ranger.DogInfo();   //print updated stats
                        Console.WriteLine("=========================");  //divider for improved user readability
                    }
                    else if (userChoice == "2")
                    {
                        Ranger.WaterDog();
                        Ranger.DogInfo();
                        Console.WriteLine("=========================");
                    }
                    else if (userChoice == "3")
                    {
                        Ranger.GiveInsulin();
                        Ranger.DogInfo();
                        Console.WriteLine("=========================");
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }

            }

        }
    }
}



























