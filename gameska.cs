using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gameska
{
    internal class Program
    {




        static void Main(string[] args)
        {
            int l = 0;
            List<string> inventory = new List<string>();




            Console.WriteLine("Welcome to the game, read the commands and press any key to start the game");
            Console.WriteLine("COMMANDS AND RULES:" + Environment.NewLine + "you have an invenory, type I to open it at any time" + Environment.NewLine + "you will have several options, press the number according to the option you have chosen");
            Console.ReadKey();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Environment.NewLine);
            }
            Console.WriteLine("You have woken up in a strange house, its very dark..." + Environment.NewLine + "you see a few doors and a staircase...");
            Console.WriteLine("1. You go in the left door");
            Console.WriteLine("2. You go in the right door");
            Console.WriteLine("3. You go up the stairs");
            Console.WriteLine("4. You go in the door thats infront of you");
            Console.WriteLine(Environment.NewLine + "Which one of these do you choose");



            while (l < 1)
            {
                string vstup = Console.ReadLine();
                switch (vstup)
                {
                    case "1":
                        Console.WriteLine("Behind the door were spring loaded spikes, YOU DIED!");
                        l++;
                        break;





                    case "2":
                        Console.WriteLine("You went through, but its getting draker...");
                        Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine + "You realize you are in the kitchen...");
                        Console.WriteLine("After a while of trying to get a hold of what the room looks like your hand touches a knife, do you want to take it with you or rather just leave it there");
                        Console.WriteLine("1. Take the knife" + Environment.NewLine + "2. leave it there");
                        vstup = Console.ReadLine();
                        

                        if (vstup == "I")
                        {
                            Console.WriteLine("These are the items in your inventory:");
                            foreach (string s in inventory)
                            {
                                Console.WriteLine(s);
                                
                            }

                        }
                        
                        
                        if (vstup == "1")
                        {
                        //přidání nože do inventáře
                        inventory.Add("knife");
                        }
                        Console.WriteLine("you left the knife behind" + Environment.NewLine + Environment.NewLine + Environment.NewLine);
                        Console.WriteLine("After some more time of looking, you found the curtains." + Environment.NewLine + "You found a boarded up window, you were able to remove a few of the boards..." + Environment.NewLine + "You can see a bit better now, now you can see a passage to what looks like a living room" + Environment.NewLine + "You can either try to escape through a window, or go deeper into the living room");
                        Console.WriteLine("1. Go in the living room" + Environment.NewLine + "2. Try to escape through the window");
                        Console.ReadKey();

                            switch (vstup)
                            {
                                case "1":
                                    Console.WriteLine("You went into the living room, theres a ");
                                    break;
                                case "2":
                                    Console.WriteLine("After some struggle you finally squeezed in between the boards in the window, although after getting out, a tall black figure killed you");
                                    l++;
                                    break;
                                case "I":
                                    Console.WriteLine("These are the items in your inventory:");
                                    foreach (string s in inventory)
                                    {
                                        Console.WriteLine(s);

                                    }
                                break;

                                
                            }
                            
                        
                        break;




                    case "3":
                        Console.WriteLine("Even though it looked like the stairs were about to fall, you carefully clibed up");
                        break;





                    case "4":
                        Console.WriteLine("There was a hole in the floor, you tried jumping over it, but fell to the basement");
                        break;





                    case "I":
                        Console.WriteLine("These are the items in your inventory:");
                        foreach (string s in inventory)
                        {
                            Console.WriteLine(s);
                        }
                        break;

                }
            }





            Console.ReadKey();

        }
        public static bool Mcka(string vstup)
        {
            switch (vstup)
            {
                case "1":
                    Console.WriteLine("");
                    break;
                case "2":
                    Console.WriteLine("");
                    break;
                case "3":
                    Console.WriteLine("");
                    break;
                case"4":
                    Console.WriteLine("");
                    break;
            }
            
            
            
            
            
            return true;
        }
    }
}
