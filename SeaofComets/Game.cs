using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaofComets
{
    public class Game
    {
       //instances
        public Player currentPlayer = new Player();
        public Alien currentChoice = new Alien();
        public Alien currentWeapon = new Alien();
        public Player currentMemories = new Player();

        //instance of a list
        public List<Location> gameLocations = new List <Location> ();

        public void Init()
        {
            Title();
            Start();
            ChooseOptions();
        }

        public void Title()
        {
            Utility.ChangeBackgroundColor(ConsoleColor.DarkCyan);
            
            Console.Clear();

            Utility.ChangeForegroundColor(ConsoleColor.White);

            //ASCII art title
            Console.Title = "Sea of Comets";
            string title = @"
 ____  _____ ____    ____  _____   ____  ____  _      _____ _____  ____ 
/ ___\/  __//  _ \  /  _ \/    /  /   _\/  _ \/ \__/|/  __//__ __\/ ___\
|    \|  \  | / \|  | / \||  __\  |  /  | / \|| |\/|||  \    / \  |    \
\___ ||  /_ | |-||  | \_/|| |     |  \__| \_/|| |  |||  /_   | |  \___ |
\____/\____\\_/ \|  \____/\_/     \____/\____/\_/  \|\____\  \_/  \____/
                                                                         ";


            Utility.Greeting(title);

            //Brief statement relating game rule and objective
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                  Collect clues and restore your memory");
            Console.ForegroundColor = ConsoleColor.White;

            //Have player press a key to initialize game
            Console.WriteLine("                     ----------------------------");
            Console.WriteLine("                     || Press enter to 'start' ||");
            Console.WriteLine("                     ----------------------------");
            Console.ReadKey();
            Console.Clear();
        }
        public void Menu()
        {
           //menu for level selection in LevelArea()
           //include instance of a list
            Console.WriteLine("                     --------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                        Where do you choose to go?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                     --------------------------------");

            //for loop
            for (int i = 0; i < gameLocations.Count(); i++)
            {
                Console.WriteLine("                     Type '"+gameLocations[i].Locationdirection+ "' to explore the " +gameLocations[i].Locationname);
            }
        }
        public void Start()
        {
            Location forest = new Location()
            {
                Locationname = "Forest",
                 Locationdirection = "North"

            };
            Location city = new Location()
            {
                Locationname = "City",
                Locationdirection = "West"

            };
            Location beach = new Location()
            {
                Locationname = "Beach",
                Locationdirection = "South"

            };

            //add items to list
            //forest level, city level, beach level
            gameLocations.Add(forest);
            gameLocations.Add(city);
            gameLocations.Add(beach);

            //Ask for character name
            Console.WriteLine("---------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Please name your character:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            //opening dialogue for game
            Console.WriteLine("---------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You wake up, dazed. Opening your eyes, you blink back confusion\n as you take in your surroundings...");
            Console.WriteLine("You do not recognize anything and you cannot remember how \nyou got here....");
            Console.WriteLine("You place your hands to your temples, your brows furrowing\n in frustration.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------------------");
            //if else statement in case player press enter before typing in keys
            if (currentPlayer.name == "")
                Console.WriteLine("You can't even remember your own name...");
            else
                Console.WriteLine("All you can remember is that your name is .... " + currentPlayer.name);
            
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You stumble to your feet, still rubbing furiously at your temples.");
            Console.WriteLine("As you turn, you notice a number of items laying buried in the sand.");
            Console.WriteLine("One of them catches your eyes and you move towards it.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------------------------");
        }
        public void ChooseOptions()
        {
            string choice;
            Console.WriteLine("                     ----------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                       Please choose a weapon.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                     ----------------------------");
            Console.WriteLine("                     (1). A bulky battle axe. ");
            Console.WriteLine("                     (2). A grimoire.");
            Console.WriteLine("                     (3). A pair of dull daggers.");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "a bulky battle axe":
                case "battle ax":
                case "bulky battle axe":
                case "axe":
                    {
                        Console.WriteLine("------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("You reach and grab the handle of the axe.");
                        Console.WriteLine("With some effort, you manage to pull it from \nthe holds of the sand.");
                        Console.WriteLine("A revelation occurs to you... you are a warrior");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("------------------------------------------------");
                        currentChoice.choice = "warrior";
                        currentWeapon.choice = "axe";
                        Console.ReadLine();
                        Console.Clear();
                        Direction();
                        break;
                    }
                case "2":
                case "a grimoire":
                case "grimoire":
                    {
                        Console.WriteLine("------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("You reach and grab the spine of the book.");
                        Console.WriteLine("Dusting off the sand, you decide to skim its pages.");
                        Console.WriteLine("The spells written within are extremely intricate...\n but somehow you understand its intricacies.");
                        Console.WriteLine("A revelation occurs to you... you are a mage.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("------------------------------------------------");
                        currentChoice.choice = "mage";
                        currentWeapon.choice = "grimoire";
                        Console.ReadLine();
                        Console.Clear();
                        Direction();
                        break;
                    }
                case "3":
                case "a pair of dull dagers":
                case "pair of dull daggers":
                case "dull daggers":
                case "daggers":
                    {
                        Console.WriteLine("------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("You pull one of the two daggers out of the sand with ease.");
                        Console.WriteLine("The blade appears dull from use.");
                        Console.WriteLine("A revelation occurs to you... you are a rogue.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("------------------------------------------------");
                        currentChoice.choice = "rogue";
                        currentWeapon.choice = "daggers";
                        Console.ReadLine();
                        Console.Clear();
                        Direction();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("--------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("That is not an option. Press 'ENTER' to try again.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------------------------");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("                     Which one catches your eye?");

                        ChooseOptions();
                        break;
                    }
            }
        }
        public void Direction()
        {
            //confirm players weapon and class choice
            Console.WriteLine("-----------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("So far, you remember that your name is " + currentPlayer.name);
            Console.WriteLine("You also have an affinity towards the " + currentWeapon.choice);
            Console.WriteLine("Otherwise classifying you as a " + currentChoice.choice);
            Console.WriteLine("But that still leaves you with a number of questions.");
            Console.WriteLine("Where are you? Why are you here?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("          -------------------------------");
            Console.WriteLine("          || Press enter to 'continue' ||");
            Console.WriteLine("          -------------------------------");
            Console.ReadKey();
            Console.Clear();

            //more story-telling
            Console.WriteLine("---------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You know the first steps to finding the answers to your questions ");
            Console.WriteLine("are to explore the surrounding area. With fear of the impending \nunknown, you furiously grip your " + currentWeapon.choice);
            Console.WriteLine("You then take a moment to consider the saftey of exploring \nunfamiliar territory. But eventually, with a deep-set sigh, \nyou begin to look around.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("               -------------------------------");
            Console.WriteLine("               || Press enter to look 'north' ||");
            Console.WriteLine("               -------------------------------");
            Console.ReadLine();
            Console.Clear();

            //describe the forest option
            Console.WriteLine("---------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("To the north you see an old, abandoned pathway leading off and\n away from the beach.");
            Console.WriteLine("A broken sign lay in tatters nearby - the words are \nhard to decipher, but the image");
            Console.WriteLine("of the tree decorated on it's surface are enough to determine\n that this path may lead to a forest.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("               -------------------------------");
            Console.WriteLine("               || Press enter to look 'west' ||");
            Console.WriteLine("               -------------------------------");
            Console.ReadLine();
            Console.Clear();

            //describe the city option
            Console.WriteLine("---------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("To the west, you can make out the skyline of a bustling city. \nThe blinding lights blotting out the natural colors of the night sky.");
            Console.WriteLine("Nearby you see an old gravel road. Following it must lead to the city");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("               -------------------------------");
            Console.WriteLine("               || Press enter to look 'south' ||");
            Console.WriteLine("               -------------------------------");
            Console.ReadLine();
            Console.Clear();

            //describe the beach option
            Console.WriteLine("---------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("To the south, you can make out the shoreline of the beach. \nThe beach appears to stretch for miles.");
            Console.WriteLine("It also appears that the beach is closed to visitors at this\n time, makeing the area eerily quiet.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("               -------------------------------");
            Console.WriteLine("               || Press enter to 'continue' ||");
            Console.WriteLine("               -------------------------------");
            Console.ReadLine();
            Console.Clear();
            LevelArea();

        

        }
        public string getInput()
        {
            string levelChoice;

            levelChoice = Console.ReadLine().ToUpper();
            return levelChoice;
        }
        public void LevelArea()
        {
            Menu();
            string levelChoice = getInput();

            //if else statement
            //with list
            //remove each option as the player chooses them
            //allows player to not repeat levels they already have done
            if ((levelChoice == "N" || levelChoice == "NORTH") && gameLocations.Count(x=>x.Locationname=="Forest") > 0)
            {
                Console.WriteLine("North");
                ForestArea();
                Location forest = gameLocations.FirstOrDefault(x => x.Locationname == "Forest");
                gameLocations.Remove(forest);
                LevelArea();
            }
            if ((levelChoice == "W" || levelChoice == "WEST") && gameLocations.Count(x => x.Locationname == "City")>0)
            {
                //Console.Clear();
                Console.WriteLine("West");
                CityArea();
                Location city = gameLocations.FirstOrDefault(x => x.Locationname == "City");
                gameLocations.Remove(city);
                LevelArea();
            }
            if ((levelChoice == "S" || levelChoice == "SOUTH") && gameLocations.Count(x => x.Locationname == "Beach") > 0)
            {
                //Console.Clear();
                Console.WriteLine("South");
                BeachArea();
                Location beach = gameLocations.FirstOrDefault(x => x.Locationname == "Beach");
                gameLocations.Remove(beach);
                LevelArea();
            }
            if (gameLocations.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("There are no more paths to take.");
                Console.WriteLine("You decide to head back to your starting point.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------------------------------");
                Console.ReadLine();
                Resolution();
            }
        }
        public void ForestArea()
        {
            int answer;
            Console.Clear();
            Console.WriteLine("You enter the forest.");
            Console.ForegroundColor = ConsoleColor.Black;
            string forest = @"
──▒▒▒▒▒▒▒▒───▒▒▒▒▒▒▒▒      
─▒▐▒▐▒▒▒▒▌▒─▒▒▌▒▒▐▒▒▌▒
──▒▀▄█▒▄▀▒───▒▀▄▒▌▄▀▒
─────██─────────██
░░░▄▄██▄░░░░░░░▄██▄░░░   ";

            //Have player answer math problem to recive a clue
            Console.WriteLine(forest);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("On one of the many trees, you spot a piece of paper tacked");
            Console.WriteLine("onto the bark. You squint trying to read whats on it.");
            Console.WriteLine("[Hello young " + currentChoice.choice + "] it begins...");
            Console.WriteLine("Below it reads ... [SOLVE THIS PROBLEM FOR A CLUE]");
            Console.WriteLine("You squint even harder. The problem is simple: 2 + x = 4");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------");

            
            //do while loop
            //will repeat question until player gets it right
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("|| What does X equal? ||");
                Console.WriteLine("------------------------");
                int.TryParse(Console.ReadLine(), out answer);

                if (answer == 2)
                {
                    Console.WriteLine("That is correct!");
                    currentPlayer.clues++;
                }
                else
                {
                    Console.WriteLine("That is incorrect!");
                    Console.WriteLine("Try again!");
                }

                Console.Clear();
            } while (answer != 2);

            Console.WriteLine("------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("With confidence, you answer the question out loud. ");
            Console.WriteLine("As if on cue, a squirrel climbs down the tree. Grabbing the\npaper and dropping an acorn at your feet before scurrying away.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("You gain a clue. You have " +currentPlayer.clues + " clue(s)");
            Console.ReadLine();
            Console.Clear();

          

        }
        public void CityArea()
        {
            //Have player answer math problem to recive a clue
            Console.Clear();
            int answer;
            Console.WriteLine("This is the city");
            Console.ForegroundColor = ConsoleColor.Black;
            string city = @"
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒
▒▒▄▄▄▒▒▒█▒▒▒▒▄▒▒▒▒▒▒▒▒
▒█▀█▀█▒█▀█▒▒█▀█▒▄███▄▒
░█▀█▀█░█▀██░█▀█░█▄█▄█░
░█▀█▀█░█▀████▀█░█▄█▄█░
████████▀█████████████
";
            Console.WriteLine(city);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You anxiously walk into the city. You keep your eyes on the");
            Console.WriteLine("ridiculously tall buildings until someone suddenly slams into you.");
            Console.WriteLine("You nearly fall to the ground, but the person who ran into you\ndoes not stop -- not even bothering to apologize or look back. ");
            Console.WriteLine("You mumble angrily under your breath. Your anxiety momentarily\nforgotton.");
            Console.WriteLine();
            Console.WriteLine("You look down -- the stranger must have dropped it. You pick\nit up. it's an ID, but it appears oddly blank with a short\nmessage handwritten at the bottom.");
            Console.WriteLine("[Hello " + currentPlayer.name + "] it begins...");
            Console.WriteLine("[YOU WANT ANSWERS? THEN LETS EXCHANGE ANSWERS FOR AN ANSWER]");
            Console.WriteLine("Below a problem is written: 4x + 2 = 2(x + 6)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------");

            //do while loop
            //will repeat question until player gets it right
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("|| What does X equal? ||");
                Console.WriteLine("------------------------");
                int.TryParse(Console.ReadLine(), out answer);

                if (answer == 5)
                {
                    Console.WriteLine("That is correct!");
                    currentPlayer.clues++;
                }
                else
                {
                    Console.WriteLine("That is incorrect!");
                    Console.WriteLine("Try again!");
                }

                Console.Clear();
            } while (answer != 5);

            Console.WriteLine("------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You bite your lip. This is a tricky one but what have you\ngot to lose?");
            Console.WriteLine("Looking back where the stranger had ran off to. You mumble\nunder your breath what you think the answer is.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("You gain a clue. You have " + currentPlayer.clues + " clue(s)");
            Console.ReadLine();
            Console.Clear();
            
        }
        public void BeachArea()

        {
            //Have player explore and find written notes/clues to expand the players lost memories.
            Console.Clear();
            int answer;
            Console.WriteLine("This is the Beach");
            Console.ForegroundColor = ConsoleColor.Black;
            string Beach = @"
░░▄▀▀▀▄░▄▄░░░░░░╠▓░░░░
░░░▄▀▀▄█▄░▀▄░░░▓╬▓▓▓░░
░░▀░░░░█░▀▄░░░▓▓╬▓▓▓▓░
░░░░░░▐▌░░░░▀▀███████▀
▒▒▄██████▄▒▒▒▒▒▒▒▒▒▒▒▒
";
            Console.WriteLine(Beach);

            //Have player answer math problem to recive a clue
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("The beach is quiet...");
            Console.WriteLine("You try your best to not let the eerie quiet get to you. You ");
            Console.WriteLine("decide to begin exploring the shoreline of the beach. Your eyes");
            Console.WriteLine("finding empty seashells here and there. A few crabs scurrying\naway, frightened by your sudden presence.");
            Console.WriteLine();
            Console.WriteLine("You spend a good 10 minutes walking down the beach when you\ncome across something written in the sand.");
            Console.WriteLine("Oddly enough, the ocean hasn't washed it away. ");
            Console.WriteLine("[QUICKLY, BEFORE THE TIDE COMES.]");
            Console.WriteLine("It reads: 12^2 + x = 288");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------");

            //do while loop
            //will repeat question until player gets it right
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("|| What does X equal? ||");
                Console.WriteLine("------------------------");
                int.TryParse(Console.ReadLine(), out answer);

                if (answer == 144)
                {
                    Console.WriteLine("That is correct!");
                    currentPlayer.clues++;
                }
                else
                {
                    Console.WriteLine("That is incorrect!");
                    Console.WriteLine("Try again!");
                }

                Console.Clear();
            } while (answer != 144);

            Console.WriteLine("------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You take longer than you would have liked, but you eventually");
            Console.WriteLine("decide on an answer and write it out in the sand.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("You gain a clue. You have " + currentPlayer.clues + " clue(s)");
            Console.ReadLine();
            Console.Clear();

        }

        public void Resolution()
        {
            //More storytelling
            //3 clues gained previously will grant the player 1 memory
            //conclusion of game.
            //Give player option to start from the beginning
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You return to where you originally woke up. Exploring has\ngained you some familiarity with this 'place'.");
            Console.WriteLine("You mentally take note of the questions you had been asked.\nThey were nothing but math problems.");
            Console.WriteLine("Which was certainly odd. But no more bizarre than the fact\nthat they were aimed directly at you.");
            Console.WriteLine("You read the answers you have given....'2', '5', and '144'.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("          -------------------------------");
            Console.WriteLine("          || Press enter to 'continue' ||");
            Console.WriteLine("          -------------------------------");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Stumped, you wonder if the numbers were even of any importance.");
            Console.WriteLine("But then, as though prompted. A flyer flies towards you.");
            Console.WriteLine("You catch it -- curious.\nYour eyes look over it before they widen in shock.");
            Console.WriteLine("The answers you have given were written neatly on the paper.");
            Console.WriteLine("You flip the flyer over and you are surprised to find a note.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------");
            currentPlayer.memories++;
            Console.WriteLine("You have gained "+currentPlayer.memories+" memory.\n");
            Console.WriteLine("          -------------------------------");
            Console.WriteLine("          ||   Press enter to 'read'   ||");
            Console.WriteLine("          -------------------------------");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Black;
            string Note = @"
   ______________________________
 / \                             \
|   |  Hello, you have given all |
 \_ |  the correct information.  |
    |   I belive this is what    |
    |    you want to know...     |
    |                            |
    |    Answer: 2               |
    |    You were assigned 2     |
    |     tasks on planet Earth  |
    |    Answer: 5               |
    |    It took you 5 years to  |
    |     travel to Earth.       |
    |    Answer: 144             |
    |      You are 144 years old |
    |   _________________________|__
    |  /                            /
    \_/____________________________/
";
            Console.WriteLine(Note);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("          -------------------------------");
            Console.WriteLine("          || Press enter to 'continue' ||");
            Console.WriteLine("          -------------------------------");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("That cleared some things up.");
            Console.WriteLine("But then again...these answers were very vague..");
            Console.WriteLine("It was clear you were on planet Earth.");
            Console.WriteLine("You were a " +currentChoice.choice+ " assigned to complete 2 tasks.");
            Console.WriteLine("Your age and time traveled did not seem relevant, but you are\ngreatful for the information nontheless..");
            Console.WriteLine("You decide that you will continue to look for more clues\nonce you have given yourself some time to rest and reflect.");
            Console.WriteLine("The more clues you can obtain....perhaps...one day...\nyou'll be able to restore your memories completely.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("          ---------------------------------");
            Console.WriteLine("          || Press 'enter' to play again ||");
            Console.WriteLine("          ---------------------------------");
            Console.ReadLine();
            Init();
        }

    }
}
