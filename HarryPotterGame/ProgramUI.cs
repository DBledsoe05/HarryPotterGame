using HarryPotterGame.PlayerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterGame
{
    class ProgramUI
    {
        Player player = new Player();
        private bool isGameOver = false;
        private bool isEndOfGame = false;
        bool hasEncounteredTroll = true;
        bool hasEncounteredDementor = true;
        bool hasEncounteredFluffy = true;
        private bool isInSecondRoom = false;
        private bool isInThirdRoom = false;

        public void Run()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            bool isRunningMainMenu = true;
            bool isInFirstRoom = false;
            bool isRunningEndMenu = true;
            while (!isGameOver && !isEndOfGame)
            {
                if (isRunningMainMenu)
                {
                    Console.WriteLine(@"
 _____ _            _   _                        ______     _   _              _____                      
|_   _| |          | | | |                       | ___ \   | | | |            |  __ \                     
  | | | |__   ___  | |_| | __ _ _ __ _ __ _   _  | |_/ /__ | |_| |_ ___ _ __  | |  \/ __ _ _ __ ___   ___ 
  | | | '_ \ / _ \ |  _  |/ _` | '__| '__| | | | |  __/ _ \| __| __/ _ \ '__| | | __ / _` | '_ ` _ \ / _ \
  | | | | | |  __/ | | | | (_| | |  | |  | |_| | | | | (_) | |_| ||  __/ |    | |_\ \ (_| | | | | | |  __/
  \_/ |_| |_|\___| \_| |_/\__,_|_|  |_|   \__, | \_|  \___/ \__|\__\___|_|     \____/\__,_|_| |_| |_|\___|
                                           __/ |                                                          
                                          |___/                                                           ");

                    Console.Write("        Controls for the game are pressing enter to move forward and number keys when prompted to do an action\n" +
                        "                DO NOT PRESS ENTER REPEATEDLY THIS WILL BRAKE THE GAME ONLY WHEN PROMPTED\n" +
                        "                -----------------------------------------------------------------------\n" +
                        "                                              1. Start Game\n" +
                        "                                              2. Exit Game\n" +
                        "                -----------------------------------------------------------------------\n");

                    var userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            isInFirstRoom = true;
                            break;
                        case "2":
                            isGameOver = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Operation.");
                            break;
                    }
                }

                {
                    Console.Clear();
                    Console.WriteLine("'You must travel to the castle in the middle of the forest immdiately. Once you've arrive at said castle you will enter inside and obtain 3 colored shards.\n" +
                                      "You will collect ALL THREE shards if you do not collect all shards or give up automatic failure and expulsion from Hogwarts academy.'\n" +
                                      "------------------------------------------------------------------------------------------------------------------------\n" +
                                      "Thanks to the map imprinted on the back of the letter your travel here to the castle mention in the letter was easy.\n" +
                                      "You stand in front of 2 massive doors leading into the castle take a deep breath and get ready for what's ahead. Your enter the castle.\n" +
                                      "Press Enter To Continue");

                    Console.ReadKey();
                }
                while (isInFirstRoom)
                {
                    Console.Clear();
                    Console.WriteLine("It's completely dark inside, the air dry, and you hear nothing. It's as if no one has been inside for centuries.\n" +
                                      "Walking further in the doors behind you quickly close shut by themselves.\n" +
                                      "Without any other options available you walk forward through the dark room hoping to stumble upon another door.\n" +
                                      "Instead of bumping into a door you bump into what feels like a big fleshy mound you hear a loud 'Raaarrrgh!'.\n" +
                                      "Suddenly the room lights up with torches attached to the walls of the room.\n" +
                                      "this reveals a 10ft tall Troll holding onto a massive club in both hands.\n" +
                                      "The Troll lets out another loud 'Rarrrrrgh!!!!' and rushes straight to you!\n" +
                                      "Press Enter To Continue");

                    Console.ReadKey();

                    while (hasEncounteredTroll)
                    {
                        EncounteredMonster("You've encountered a massive troll!",
                            "The troll swings his massive club down at you! You're able to dodge out of the way! Press Enter\n" +
                            "Mr. Troll comes rushing at you after you finish casting the spell you make a quick roll to dodge! Darn! That spell didn't work Press Enter.",
                            "You knocked the troll out with it's club by using the levitation spell! It falls to the floor and a object falls from it's mouth.\n" +
                            "You've retreived the Blue Stone! Press Enter",
                            AttackType.WingardiumLeviosa);
                        Console.ReadKey();
                        isInFirstRoom = false;
                    }
                }
                while (isInSecondRoom)
                {
                    Console.Clear();
                    Console.WriteLine("With the troll defeated you grab the stone and move to a closed door.\n" +
                                      "Opening the door reveals stairs that lead downward\n" +
                                      "Going down the set of stairs has you inside of another room, but this one has the look of underground dungeon.\n" +
                                      "This time it wasn't dark it was lite the same as the room with the troll.\n" +
                                      "As you were looking around the room you hear a 'woof! woof! woof!' you turn your head and see a three-headed beast with a dog collar around it's neck\n" +
                                      "on the collar you see the word 'Fluffy'. This time instead of being charged at you charge full speed at 'Fluffy' readying your spells.\n" +
                                      "Press Enter To Continue");

                    Console.ReadKey();

                    while (hasEncounteredFluffy)
                    {
                        SecondEncounteredMonster("Your next beast is the Three-Headed dog, Fluffy.",
                            "Fluffy bites onto your arm! It throws you across the room!\n" +
                            "The beast sits up on it's hind legs then comes back down on top of you forcing you to be prone.",
                            "You put Fluffy to sleep by casting a music spell! You have retreived the Red Stone!",
                            AttackType.MusicSpell);
                        Console.ReadKey();
                    }
                }
                while (isInThirdRoom)
                {
                    Console.Clear();
                    Console.WriteLine("");

                    Console.ReadKey();

                    while (hasEncounteredDementor)
                    {
                        ThirdEncounteredMonster("Oh no! A Dementor!",
                            "The Dementor consumed your soul!\n" +
                            "It has defeated you. Press Enter to move on.",
                            "You cast away the Dementor with the Expecto Patronum spell! You have retreived the Green Stone!",
                            AttackType.ExpectoPatronum);
                        Console.ReadKey();
                    }
                }

                while (isGameOver)
                {
                    if (isRunningEndMenu)
                    {
                        Console.WriteLine(@"
 _____          _          __   _____                        _ 
|  ___|        | |        / _| |  __ \                      | |
| |__ _ __   __| |   ___ | |_  | |  \/ __ _ _ __ ___   ___  | |
|  __| '_ \ / _` |  / _ \|  _| | | __ / _` | '_ ` _ \ / _ \ | |
| |__| | | | (_| | | (_) | |   | |_\ \ (_| | | | | | |  __/ |_|
\____/_| |_|\__,_|  \___/|_|    \____/\__,_|_| |_| |_|\___| (_)
                                                               
                                                               ");

                        Console.Write("                                     Congrates You have completed the game!\n" +
                            "               -----------------------------------------------------------------------\n" +
                            "                                             1. Exit Game\n" +
                            "               -----------------------------------------------------------------------\n");

                        var userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                isEndOfGame = true;
                                isGameOver = false;
                                break;
                            default:
                                Console.WriteLine("Invalid Operation.");
                                break;
                        }
                    }
                }
            }
        }
        private void PlayerChoice(string msg)
        {
            Console.WriteLine(msg);
        }
        private void EncounteredMonster(string Title, string wrongChoice, string RightChoice, AttackType correctAttackType)
        {
            Console.Clear();
            Console.WriteLine(Title + " How will you defeat this beast:\n" +
                                    "1. Use Expecto Patronum\n" +
                                    "2. Use Wingardium Leviosa\n" +
                                    "3. Use Music Spell\n" +
                                    "4. Run away\n");

            var userInput = int.Parse(Console.ReadLine());
            player.Attack = (AttackType)userInput;

            switch (player.Attack)
            {
                case AttackType.ExpectoPatronum:
                    CheckPlayerAttacktype(correctAttackType, wrongChoice, RightChoice);
                    break;
                case AttackType.WingardiumLeviosa:
                    CheckPlayerAttacktype(correctAttackType, wrongChoice, RightChoice);
                    hasEncounteredTroll = false;
                    isInSecondRoom = true;
                    break;
                case AttackType.MusicSpell:
                    CheckPlayerAttacktype(correctAttackType, wrongChoice, RightChoice);
                    break;
                case AttackType.Run_Away:
                    Console.WriteLine("You try to run away! But the closed shut doors stops you.");
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }

        }

        private void SecondEncounteredMonster(string Title, string wrongChoice, string RightChoice, AttackType correctAttackType)
        {
            Console.Clear();
            Console.WriteLine(Title + " How will you defeat this beast:\n" +
                                    "1. Use Expecto Patronum\n" +
                                    "2. Use Wingardium Leviosa\n" +
                                    "3. Use Music Spell\n" +
                                    "4. Run away\n");

            var userInput = int.Parse(Console.ReadLine());
            player.Attack = (AttackType)userInput;

            switch (player.Attack)
            {
                case AttackType.ExpectoPatronum:
                    CheckPlayerAttacktype(correctAttackType, wrongChoice, RightChoice);
                    break;
                case AttackType.WingardiumLeviosa:
                    CheckPlayerAttacktype(correctAttackType, wrongChoice, RightChoice);
                    break;
                case AttackType.MusicSpell:
                    CheckPlayerAttacktype(correctAttackType, wrongChoice, RightChoice);
                    hasEncounteredFluffy = false;
                    isInSecondRoom = false;
                    isInThirdRoom = true;
                    break;
                case AttackType.Run_Away:
                    Console.WriteLine("You ran away!");
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }

        }

        private void ThirdEncounteredMonster(string Title, string wrongChoice, string RightChoice, AttackType correctAttackType)
        {
            Console.Clear();
            Console.WriteLine(Title + " How will you defeat this beast:\n" +
                                    "1. Use Expecto Patronum\n" +
                                    "2. Use Wingardium Leviosa\n" +
                                    "3. Use Music Spell\n" +
                                    "4. Run away\n");

            var userInput = int.Parse(Console.ReadLine());
            player.Attack = (AttackType)userInput;

            switch (player.Attack)
            {
                case AttackType.ExpectoPatronum:
                    CheckPlayerAttacktype(correctAttackType, wrongChoice, RightChoice);
                    hasEncounteredDementor = false;
                    isInThirdRoom = false;
                    isGameOver = true;
                    break;
                case AttackType.WingardiumLeviosa:
                    CheckPlayerAttacktype(correctAttackType, wrongChoice, RightChoice);
                    break;
                case AttackType.MusicSpell:
                    CheckPlayerAttacktype(correctAttackType, wrongChoice, RightChoice);
                    break;
                case AttackType.Run_Away:
                    Console.WriteLine("You ran away!");
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }

        }

        private void CheckPlayerAttacktype(AttackType correctAttackType, string wrongChoice, string rightChoice)
        {
            if (player.Attack != correctAttackType)
            {
                PlayerChoice(wrongChoice);
            }
            else
            {
                Console.WriteLine(rightChoice);
            }
        }
    }
}
