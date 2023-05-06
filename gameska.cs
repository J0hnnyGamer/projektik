using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
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
            Console.ReadKey();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Environment.NewLine);
            }
            //první výběr možností
            Console.WriteLine("You have woken up in a strange house, its very dark..." + Environment.NewLine + "you see 4 doors, one of them is missing a handle and a staircase...");
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
                    //cesta doleva
                    case "1":
                        Console.WriteLine("Behind the door were spring loaded spikes, YOU DIED!");
                        l++;
                        break;




                    //cesta doprava
                    case "2":
                        Console.WriteLine("You went through, but is dark...");
                        Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine + "You realize you are in the kitchen");
                        

                        
                        Console.WriteLine("After some more time of looking around, you found the curtains." + Environment.NewLine + "You found a boarded up window, you were able to remove a few of the boards..." + Environment.NewLine + "You can see a bit better now, now you can see a passage to what looks like a living room" + Environment.NewLine + "You can either try to escape through a window, or go deeper into the living room");
                        Console.WriteLine("1. Go in the living room" + Environment.NewLine + "2. Try to escape through the window");
                        vstup = Console.ReadLine();

                            switch (vstup)
                            {
                                case "1":
                                    Console.WriteLine("You went into the living room, theres an armchair and an old TV" + Environment.NewLine + "Do you want to sit down or continue going forward");
                                    Console.WriteLine("1. Sit Down" + Environment.NewLine + "2. keep going");
                                    vstup = Console.ReadLine();
                                    switch(vstup)
                                    {
                                    case "1":
                                        Console.WriteLine("Right after you sat down, the chair locked you in so you can`t move, the tv turned on...");
                                        Console.WriteLine("You are stuck there forever watching TV");
                                        l++;
                                        break;
                                    
                                    
                                    
                                    
                                    
                                    
                                    
                                    
                                    
                                    case "2":
                                        Console.WriteLine("You found a door that leads to outside..." + Environment.NewLine + "Now you're outside, but you still have to make your way through the forest");
                                        Console.WriteLine("You see two paths, whitch one are you going to choose..." + Environment.NewLine + "1. Left" + Environment.NewLine + "2. Right");
                                        vstup= Console.ReadLine();
                                        switch(vstup)
                                        {
                                            case "1":
                                                Console.WriteLine("Yow walk for a while and you see the path splits into 4 more" + Environment.NewLine + "1. Very left" + Environment.NewLine + "2. Center left" + Environment.NewLine + "3. Center right" + Environment.NewLine + "4. Very right");
                                                vstup = Console.ReadLine();
                                                            
                                                        Console.WriteLine("the path just keeps splitting and you are getting nowhere..." + Environment.NewLine + "You're lost...");
                                                l++;
                                           break;



                                                
                                            
                                            case "2":
                                                Console.WriteLine("You walk for a long time, the house must've been in the middle of the forrest, you get hella tired" + Environment.NewLine + "1. Find a place to lay down and wait till morning" + Environment.NewLine + "2. keep going");
                                                vstup = Console.ReadLine();
                                                switch(vstup)
                                                {
                                                    case "1":
                                                        Console.WriteLine("You found a nice patch of grass, it looks comfortable, so you lay down..." + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine);
                                                        Console.WriteLine("You wake up, but its still dark..." + Environment.NewLine + "You are inside of a wooden box..." + Environment.NewLine + "YOU WERE BURRIED ALIVE");
                                                        l++;
                                                        break;
                                                    
                                                    
                                                    
                                                    case "2":
                                                        Console.WriteLine("You've been walking a long time, you can't see much so you climb a tree..." + Environment.NewLine + "What's that in the distance..." + Environment.NewLine + "You see light, it looks like a city, so you climb down and walk towards it..." + Environment.NewLine + "You were right, its a city, you found help and escaped safely");
                                                        l++;
                                                        break;
                                                }

                                                
                                                
                                                break;
                                        }
                                        
                                        
                                        
                                        
                                        break;
                                    }
                                    break;
                                
                            
                            
                            
                            
                                case "2":
                                    Console.WriteLine("After some struggle you finally squeezed in between the boards in the window, although after getting out, a tall black figure killed you");
                                    l++;
                                    break;
                                

                                
                            }
                            
                        
                        break;



                    //cesta po schodech 
                    case "3":
                        Console.WriteLine("You went up the stairs");


                        Console.WriteLine("there are 4 doors" + Environment.NewLine + "1. First door" + Environment.NewLine + "2. second door" + Environment.NewLine + "3. third door" + Environment.NewLine + "4. Fourth door");
                        vstup=Console.ReadLine();
                        switch (vstup)
                        {
                            case "1":
                                Console.WriteLine("The door leads to a bathroom..." + Environment.NewLine + " the sink starts filling up wwith blood..." + Environment.NewLine + "You try to leave through the door but its locked" + Environment.NewLine + "after some time the whole room fills up with blood an you drown...");
                                l++;
                                break;
                            case "2":
                                Console.WriteLine("The second door leads to a bedroom..." + Environment.NewLine + "There was someone sleeping on the bed, but by walking in, you woke them up" + Environment.NewLine + " They got mad and killed you");
                                l++;
                                break;
                            case "3":
                                Console.WriteLine("In the third door there was a portal..." + Environment.NewLine + "Someone pushed you into it..." + Environment.NewLine + "After you fell into the portal, you woke up in your bed... It was all a dream");
                                l++;
                                break;
                            case "4":
                                Console.WriteLine("Behind the fourth door, there is an empty bedroom..." + Environment.NewLine + "Suddnely, you get very tired and you have no other choice than to lay down on the bed..." + Environment.NewLine + "You never wake up...");
                                l++;
                                break;
                        }
                        break;




                    //cesta rovně
                    case "4":
                        Console.WriteLine("There was a hole in the floor, you tried jumping over it, but fell to the basement");
                        Console.WriteLine("");
                        break;





                    

                }
            }

            
            
            
            
            
            
            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine);
            




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
