using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASDFM
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
        }

        public static void gameTitle()
        {
            Console.WriteLine("WASD FM Summer Vacation Text Adventure!");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            string choice;

            Console.WriteLine("You are now DJ Luke the Kook at the tail end of his last music show before ");
            Console.WriteLine("he has to use his PTO to go on summer vacation with his beautiful wife.");
            Console.WriteLine("It's about that time to play his last song of the weekend show.");
            Console.WriteLine("What song do you want him to close out with?");
            Console.WriteLine("1. Jason by The Midnight");
            Console.WriteLine("2. Rum n Bass by Boom Kitty");
            Console.WriteLine("3. Still Alive by Junkie XL");
            Console.Write("Choice: ");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "Jason":
                case "The Midnight":
                case "Jason by The Midnight":
                    {
                        Console.WriteLine("You rock out to Jason by The Midnight before you sign off and close out your show.");
                        Console.WriteLine("Your wife, Lillian Rochefort, walks in wearing her summer dress and a big smile.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "2":
                case "Rum n Bass":
                case "Boom Kitty":
                case "Rum n Bass by Boom Kitty":
                    {
                        Console.WriteLine("You rock out to Rum n Bass by Boom Kitty before you sign off and close out your show.");
                        Console.WriteLine("Your wife, Lillian Rochefort, walks in wearing her summer dress and a big smile.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "Still Alive":
                case "Junkie XL":
                case "Still Alive by Junkie XL":
                    {
                        Console.WriteLine("You rock out to Still Alive by Junkie XL before you sign off and close out your show.");
                        Console.WriteLine("Your wife, Lillian Rochefort, walks in wearing her summer dress and a big smile.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Huh?! Whoa! You speedrunner! You just fast forwarded in time!");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        imperialTavern();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Oh yeah...we should've thought of that one, but we didn't.");
                        Console.WriteLine("Hint: Use your number pad to select one of the three options.");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }

        }

        public static void second()
        {
            string secChoice;

            Console.WriteLine("Lillian smiles pretty and asks if you're ready for your vacation. Yes or no?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            Console.Clear();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("That's a good answer, DJ! Lillian is ready to get her tan on.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                third();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("You shout 'HELL NO!' before you lock yourself in the studio with the only key.");
                Console.WriteLine("Whu....why? Seriously? You picked THAT option? Check the title of the game again, stud.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                gameOverOne();
            }
            else if (secChoice == "kiss her" || secChoice == "x")
            {
                Console.WriteLine("Whoa! Easy there, Romeo. She liked it and all, but she's just looking for a yes or no.");
                Console.WriteLine("We still got LOTS to plan before we go.");
                Console.WriteLine("Hint: If you're too lazy to type out yes or no, then the letters they start with will suffice.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                second();
            }
            else
            {
                Console.WriteLine("That command makes no sense to the current situation.");
                Console.WriteLine("Hint: If you're too lazy to type out yes or no, then the letters they start with will suffice.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                second();
            }

        }
        public static void gameOverOne()
        {
            Console.Clear();
            Console.WriteLine("SERIOUSLY! Why did you...? You have a hot blonde wife and you REFUSE to go on");
            Console.WriteLine("vacation with her?! The Radio Tower of Power isn't THAT cozy!");
            Console.WriteLine("Would you like to answer her CORRECTLY this time?");
            Console.WriteLine("Secret option hint: z does nothing, but the key next to it might.");
            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
            second();
        }
        public static void third()
        {
            string choice;

            Console.WriteLine("Lillian reminds you to leave your favorite DJ to handle your shift while you go on summer vacation.");
            Console.WriteLine("Who will you leave in charge?");
            Console.WriteLine("1. DJ Doogle the Moogle");
            Console.WriteLine("2. DJ Malcolm the Jester");
            Console.WriteLine("3. DJ Pro-Yo the Prothean");
            Console.WriteLine("4. Get a good idea of their personality types to help you decide.");
            Console.Write("Choice: ");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("Excellent choice! DJ Doogle the Moogle will handle your shift and responsibilities with confidence.");
                        Console.WriteLine("DJ Malcolm and DJ Pro-Yo sigh in relief for not being chosen.");
                        Console.WriteLine("They seem to really like their shifts and appreciate how Doogle approaches them.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        thirdOne();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You picked DJ Malcolm the Jester who says he doesn't know how to access your soundboard.");
                        Console.WriteLine("You show him how to access it, but he still doesn't get it.");
                        Console.WriteLine("Is this guy for real? Did I hire an idiot or something?");
                        Console.WriteLine("Oops. You realize you may have said that out loud.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        gameOverTwo();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You picked DJ Pro-Yo the Prothean. An awkward silence lingers in the room.");
                        Console.WriteLine("DJ Doogle the Moogle seems heartbroken as he tries to keep his smile from becoming a frown.");
                        Console.WriteLine("DJ Malcolm seems relieved, but it's hard to tell with that one raised eyebrow as if he's thinking");
                        Console.WriteLine("'THAT guy? REALLY?'");
                        Console.WriteLine("DJ Pro-Yo really likes his ancient melodies and asks if he can play them during your show.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        thirdTwo();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("DJ Doogle the Moogle:");
                        Console.WriteLine("  He tries. Despite his small stature, he has a big heart that he always puts into everything he does.");
                        Console.WriteLine("  He is eager to please and is always learning new things. He doesn't have the loudest announcer voice,");
                        Console.WriteLine("  but he tries to make up for it with his charisma and 'can do' attitude.");
                        Console.WriteLine("DJ Malcolm the Jester");
                        Console.WriteLine("  He is a notorious goofball, but he likes to party. Where does he even find those tracks he plays on his show?");
                        Console.WriteLine("  Malcolm knows how to bust a groove and work rhythm, but he's particular about taking orders.");
                        Console.WriteLine("  You may have to use tact when giving Malcolm orders, but he dishes out orders how he likes.");
                        Console.WriteLine("DJ Pro-Yo the Prothean");
                        Console.WriteLine("  Pro-Yo has his audience that say they have an 'acquired taste', if you will.");
                        Console.WriteLine("  It'd be harder to find a classier dude than this guy who is proud to be a part of an ancient race from space.");
                        Console.WriteLine("  He loves where he's at with his job and sees little to no point in moving up the ladder or changing his ways.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        third();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("In this case, it'd save you time to select 1, 2 or 3 to continue the story.");
                        Console.WriteLine("Choose wisely. The wrong one COULD result in game over.");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        third();
                        break;
                    }
            }

        }

        public static void gameOverTwo()
        {
            Console.Clear();
            Console.WriteLine("Malcolm calls you a party pooper and admits he was just trolling you.");
            Console.WriteLine("Malcolm didn't accept this job to work for a boring boss, so he walks out on you.");
            Console.WriteLine("Consider this his resignation AND burning the bridge of ever wanting to work here again.");
            Console.WriteLine("Maybe we shouldn't have picked a well known trickster in this situation. Now we lost a DJ and CAN'T go on vacation.");
            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void thirdOne()
        {
            string secChoice;
            Console.WriteLine("DJ Doogle asks if he can turn your show into more of a party/clubbing show with all dance beats.");
            Console.WriteLine("At least just this one time while he fills in for you.");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            Console.Clear();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("You barely even get a full 'yes' out as he jumps with delight and does a little spin.");
                Console.WriteLine("'I won't let you down, boss!' DJ Doogle says with glee.");
                Console.WriteLine("Malcolm and Pro-Yo just roll their eyes and carry on with their business.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                fourth();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("'Not this time,' you say. 'My demographic really likes my show for their reasons.'");
                Console.WriteLine("'We can experiment with new things another time if we advertise it well enough in advance,' you explain.");
                Console.WriteLine("'That does make sense,' DJ Doogle replies. 'Well, have fun on your vacation, boss!'");
                Console.WriteLine("Lillian smiles warmly at DJ Doogle and pats him on the head. Doogle just blushes shyly.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                fourth();
            }
            else if (secChoice == "kiss him" || secChoice == "x")
            {
                Console.WriteLine("'I always thought you were the cutest,' you say to DJ Doogle as you give him a big kiss and a hug.");
                Console.WriteLine("Lillian's heart melts as she tilts her head to the side and utters out a long 'aww.'");
                Console.WriteLine("DJ Doogle blushes a bright red and says, 'I will take that as a yes.'");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                fourth();
            }
            else
            {
                Console.WriteLine("DJ Doogle stares at you dumbfoundedly as that response wasn't relevant to the question.");
                Console.WriteLine("Lillian carefully explains the question to you and even offers to draw you an actual picture.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                thirdOne();
            }
        }

        public static void thirdTwo()
        {
            string secChoice;

            Console.WriteLine("Well? What's the word, Kook? Can DJ Pro-Yo the Prothean play his ancient melodies to your audience?");
            Console.WriteLine("Your audience isn't really the demographic, but it might not hurt to introduce them to something new...er...old.");
            Console.WriteLine("You never know. You might even attract a more cultured audience.");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            Console.Clear();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("'Fine. Whatever.' Is how you answer.");
                Console.WriteLine("'Your audience shall become more cultured,' DJ Pro-Yo promises.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                fourth();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("You shake your head and let out a long 'no'.");
                Console.WriteLine("DJ Pro-Yo lets out a rough sigh and says, 'You uncultured swine. Fine. But I'll need more wine.'");
                Console.WriteLine("DJ Malcolm struts his way out the door and DJ Doogle hangs his head low on his way out.");
                Console.WriteLine("You gladly get Pro-Yo more wine.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                fourth();
            }
            else if (secChoice == "kiss him" || secChoice == "x")
            {
                Console.WriteLine("What do you think this is? A dating simulator? DJ Pro-Yo ain't into your gender OR species.");
                Console.WriteLine("Lillian can't believe you did that in front of her and slaps you hard across the face.");
                Console.WriteLine("DJ Malcolm wears a mischievous smile as the biggest troll would be expected to.");
                Console.WriteLine("DJ Doogle just face palms himself and shakes his furry little head.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                gameOverThree();
            }
            else
            {
                Console.WriteLine("That command makes no sense to the current situation.");
                Console.WriteLine("Hint: If you're too lazy to type out yes or no, then the letters they start with will suffice.");
                Console.WriteLine("Secret option hint: z does nothing, but the key next to it might.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                thirdTwo();
            }
        }

        public static void gameOverThree()
        {
            Console.Clear();
            Console.WriteLine("Looks like you have bigger problems than just planning a vacation, bud.");
            Console.WriteLine("DJ Pro-Yo quits on account of feeling sexually harrassed. Lillian storms out on you wanting a divorce.");
            Console.WriteLine("DJ Doogle awkwardly leaves saying he can't work for a weirdo boss.");
            Console.WriteLine("DJ Malcolm laughs hysterically as at least HE knew you were trolling. Or were you?");
            Console.WriteLine("Press 'Enter' to try it ALL over again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void fourth()
        {
            string choice;

            Console.WriteLine("'Finally! Let's go on vacation!' Lillian grins with excitement.");
            Console.WriteLine("'Let's go somewhere that will stay warm because I refuse to pack any pants. Shorts and short sleeves ONLY!");
            Console.WriteLine("'And my swimsuits of course. So where are we going, honey?' Our destination choices are: ");
            Console.WriteLine("Cyrodiil");
            Console.WriteLine("Monkey Island");
            Console.Write("Choice: ");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "cyrodiil":
                    {
                        Console.WriteLine("Ah, yes. Historic Cyrodiil has much to do and is very lovely this time of year.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        cyrodiil();
                        break;
                    }
                case "2":
                case "monkey island":
                    {
                        Console.WriteLine("ARRRR, MATEY! It is adventure ya crave! Er...yeah, let's go to Monkey Island.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        monkeyIsland();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("We didn't have that option in our budget. Maybe in the sequel?");
                        Console.WriteLine("Hint: use your number pad to select one of the five options.");
                        Console.WriteLine("Press 'enter' to try again.");
                        Console.ReadLine();
                        fourth();
                        break;
                    }
            }
        }

        public static void monkeyIsland()
        {
            string choice;

            Console.WriteLine("Well, we're at Monkey Island. Now what?");
            Console.WriteLine("Lillian asks, 'So what do we do on Monkey Island?'");
            Console.WriteLine("1. Go see The Fantastic Flying Fettuccine Brothers Circus.");
            Console.WriteLine("2. Sail around the island on a pirate ship.");
            Console.WriteLine("3. Take a raft through the Mystes O'Tyme Marshe");
            Console.Write("Enter one of the three number options: ");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "circus":
                    {
                        Console.WriteLine("Let's see what this circus hype is all about. Why am I getting a pasta craving suddenly?");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        circus();
                        break;
                    }
                case "2":
                case "sail":
                    {
                        Console.WriteLine("'SAAAAAAAAAAILING! TAKES ME AWAAAAAAY TO WHERE I HEARD IT COULD BE!'");
                        Console.WriteLine("'Pipe down, Christopher Cross,' Lillian says. 'We're going on a pirate ship, so get your Dropkick Murphys on.'");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        pirateShip();
                        break;
                    }
                case "3":
                case "marshe":
                    {
                        Console.WriteLine("Really? A whole tropical island to explore and we're going straight to what looks like the Swamps of Sadness or Dagobah?");
                        Console.WriteLine("Oooookay. Hopefully we meet Yoda here at the very least.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        marshes();
                        break;
                    }
                case "4":
                case "coitus":
                    {
                        Console.WriteLine("WHOA! We ARE married, so assume we're doing that off screen. This story is SUPPOSED to be family friendly.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No, no, no. That's not an option. Stick to the script, loser.");
                        Console.WriteLine("Hit 'Enter' to try again.");
                        Console.ReadLine();
                        monkeyIsland();
                        break;
                    }
            }
        }

        public static void circus()
        {
            string secChoice;

            Console.WriteLine("You and Lillian awe at the spectacle of a show that the Fantastic Flying Fettuccine Brothers are putting on.");
            Console.WriteLine("The Brothers are even putting on different costumes for themed acts and between each act is its own little show.");
            Console.WriteLine("Clowns arm wrestle lions, little people stack on top of each other to box kangaroos and a bear does a chair dance.");
            Console.WriteLine("You and Lillian seem to prefer the funny acts between the Fettuccine Brothers and the performances end in about two hours.");
            Console.WriteLine("All that's left to do after the show is enjoy the rest of the fair outside the circus tent.");
            Console.WriteLine("Except you can't seem to get the Myste o' Tyme Marshes out of your head and manage to talk Lillian into going.");
            Console.WriteLine("'This place better not be too drab,' Lillian says with caution. 'Or cold.'");
            Console.WriteLine("It's ultimately up to you. Go to the marshes or hang out at the fair for the rest of the day?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            Console.Clear();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("'Let's go check out the marshes.");
                Console.WriteLine("'I didn't even pack any hoodies, so I better not regret this,' says Lillian.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                marshes();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("Yeah, maybe those marshes are a dumb idea. Let's just enjoy the fair.");
                Console.WriteLine("You even end up winning Lillian a giant stuffed Angry Bird at one of the games.");
                Console.WriteLine("Lillian asks if we'll even be able to fit it on the plane ride home.");
                Console.WriteLine("'Probably not, so we'll slingshot it home,' you say with a shrug and Lillian laughs.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                monkeyIslandCont();
            }
            else if (secChoice == "kiss her" || secChoice == "x")
            {
                Console.WriteLine("'That doesn't answer the question, Romeo,' Lillian replies.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                circus();
            }
            else
            {
                Console.WriteLine("That command makes no sense to the current situation.");
                Console.WriteLine("Hint: If you're too lazy to type out yes or no, then the letters they start with will suffice.");
                Console.WriteLine("Secret option hint: z does nothing, but the key next to it might.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                circus();
            }
        }

        public static void pirateShip()
        {
            int drinks;
                        
            Console.WriteLine("Let's Kook back and enjoy the cruise.");
            Console.WriteLine("Lillian wants to have her girly Sunshine Cloud, and ");
            Console.WriteLine("Luke is eyeing up that Flaming Moai with eager intensity.");
            Console.WriteLine("How many of these Flaming Moais will you end up having?");
            Console.Write("drinks: ");
            int.TryParse(Console.ReadLine(), out drinks);
            while (drinks <= 2)
            {
                Console.WriteLine("You're completely relaxed and enjoying the ocean breeze with a tasty drink.");
                Console.WriteLine("You'll be sober enough to remember this evening for a long time to come.");
                Console.WriteLine("The cold drinks and the ocean breeze gives Lillian some chills, so ");
                Console.WriteLine("cuddles up to you for the rest of the ride as you lovebirds watch the ");
                Console.WriteLine("sunset casting oranges and purples against the horizon.");
                Console.WriteLine("This is what summer vacations are all about.");
                Console.WriteLine("Hit 'Enter' to continue.");
                Console.ReadLine();
                monkeyIslandCont();
            }
            while (drinks <= 5)
            {
                Console.WriteLine("You're just a bit tipsy but doing fine.");
                Console.WriteLine("Lillian may have indulged in as many Sunshine Clouds as you did ");
                Console.WriteLine("Flaming Moais. You two lovebirds find yourselves a little numb to the ");
                Console.WriteLine("cool air coming off the ocean, and Lillian forces you to hold her ");
                Console.WriteLine("by the hips while she stands at the front of the ship with her arms ");
                Console.WriteLine("outstretched. 'I'VE ALWAYS WANTED TO DO THIS!' Lillian shouts as you laugh.");
                Console.WriteLine("'I'M FLYING!' Lillian shouts as you continue laughing like an idiot.");
                Console.WriteLine("Everyone else on the ship just stares at you crazy lovebirds, but you don't care.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                monkeyIslandCont();
            }
            while (drinks >= 6)
            {
                Console.WriteLine("The rest of the evening is a blur.");
                Console.WriteLine("You wake up the next morning a little hungover in the hotel room.");
                Console.WriteLine("Lillian tells you how you passed out in the middle of table dancing.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                monkeyIslandCont();
            }            
        }

        public static void pirateShip2()
        {
            int drinks;

            Console.WriteLine("Weren't we just here, or am I imagining things?");
            Console.WriteLine("Ah, whatever. Let's Kook back and enjoy the cruise.");
            Console.WriteLine("Lillian wants to have her girly Sunshine Cloud, and ");
            Console.WriteLine("Luke is eyeing up that Flaming Moai with eager intensity.");
            Console.WriteLine("How many of these Flaming Moais will you end up having?");
            Console.Write("drinks: ");
            int.TryParse(Console.ReadLine(), out drinks);
            while (drinks <= 2)
            {
                Console.WriteLine("You're completely relaxed and enjoying the ocean breeze with a tasty drink.");
                Console.WriteLine("You'll be sober enough to remember this evening for a long time to come.");
                Console.WriteLine("The cold drinks and the ocean breeze gives Lillian some chills, so ");
                Console.WriteLine("cuddles up to you for the rest of the ride as you lovebirds watch the ");
                Console.WriteLine("sunset casting oranges and purples against the horizon.");
                Console.WriteLine("This is what summer vacations are all about.");
                Console.WriteLine("Hit 'Enter' to continue.");
                Console.ReadLine();
                monkeyIslandEnd();
            }
            while (drinks <= 5)
            {
                Console.WriteLine("You're just a bit tipsy but doing fine.");
                Console.WriteLine("Lillian may have indulged in as many Sunshine Clouds as you did ");
                Console.WriteLine("Flaming Moais. You two lovebirds find yourselves a little numb to the ");
                Console.WriteLine("cool air coming off the ocean, and Lillian forces you to hold her ");
                Console.WriteLine("by the hips while she stands at the front of the ship with her arms ");
                Console.WriteLine("outstretched. 'I'VE ALWAYS WANTED TO DO THIS!' Lillian shouts as you laugh.");
                Console.WriteLine("'I'M FLYING!' Lillian shouts as you continue laughing like an idiot.");
                Console.WriteLine("Everyone else on the ship just stares at you crazy lovebirds, but you don't care.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                monkeyIslandEnd();
            }
            while (drinks >= 6)
            {
                Console.WriteLine("The rest of the evening is a blur.");
                Console.WriteLine("You wake up the next morning a little hungover in the hotel room.");
                Console.WriteLine("Lillian tells you how you passed out in the middle of table dancing.");
                Console.WriteLine("You even went viral on every user based streaming site.");
                Console.WriteLine("Lillian adds that everyone loved your dance performance and the locals ");
                Console.WriteLine("are already working on building a statue in your honor.");
                Console.WriteLine("The statue is you in a disco pose on top of a table.");
                Console.WriteLine("You wipe a tear away knowing you've been immortalized.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                monkeyIslandEnd();
            }
        }

        public static void marshes()
        {
            Console.WriteLine("You have now entered the Myste O'Tyme Marshe.");
            Console.WriteLine("Lillian was worried it would be cold here in the marshe, but quite the contrary.");
            Console.WriteLine("It's warm, humid and muggy. You and Lillian take a raft to paddle board from the ");
            Console.WriteLine("Swamp of Time.");
            Console.ReadLine();

            Console.WriteLine("You don't really know what you're looking for, but you feel compelled to explore.");
            Console.ReadLine();

            Console.WriteLine("You keep paddling until you and Lillian find a deck in the middle of the water that ");
            Console.WriteLine("leads to a small house. The deck and house seem to be sticking out of the water.");
            Console.WriteLine("The mist and clouds have cleared up to reveal the sun rays shining upon the house.");
            Console.ReadLine();

            Console.WriteLine("You wonder if it's a fishing hut and decide to check it out as it appears to be vacant.");
            Console.WriteLine("You paddle toward the deck and tie the raft to the dock as Lillian walks toward ");
            Console.WriteLine("the fishing hut. After you finish tying the raft to the dock, you make sure the bonds ");
            Console.WriteLine("are tight enough so the raft doesn't go anywhere and turn around to see...");
            Console.ReadLine();

            Console.WriteLine("A PIRATE! The pirate is holding a gun to Lillian's head and is holding her hostage.");
            Console.WriteLine("'ARR! What you be doin trespassin' 'ere?' the pirate growls.");
            Console.ReadLine();

            Console.WriteLine("'Whoa! We didn't mean to trespass,' you say in defense.");
            Console.WriteLine("'My name is Luke the Kook and that's my wife, Lillian. We're just here on vacation.'");
            Console.ReadLine();

            Console.WriteLine("'VACATION?' the pirate repeats in disbelief. 'Tis be no place fer that!'");
            Console.WriteLine("'I agree,' says Lillian. 'If you let me go, we'll just be on our way...'");
            Console.ReadLine();

            Console.WriteLine("'I won't be lettin' ye go so easily,' the pirate replies. 'She be yer wife?'");
            Console.WriteLine("'Yes, and who are you?' you ask the pirate.");
            Console.ReadLine();

            Console.WriteLine("'Ya must be jokin' says the pirate. 'Everyone has heard of the pirate LeChuck!'");
            Console.ReadLine();

            Console.WriteLine("Pirate LeChuck?! No way! But he should've been dead for hundreds of years!");
            Console.WriteLine("'Impossible!' You stammer. 'Not the original! You'd be centuries old!'");
            Console.ReadLine();

            Console.WriteLine("'Aye, the original and I'm much in my prime!' replies the pirate.");
            Console.WriteLine("'You want yer wife back?' LeChuck asks. 'You better put up a good fight!'");
            Console.ReadLine();

            Console.WriteLine("Legends say that the Mystes O'Tyme Marshe has no chronological concept of time...");
            Console.WriteLine("This must be one of those examples. Now is a great opportunity to show off in front ");
            Console.WriteLine("of Lillian and save her in this unexpected daring adventure.");
            Console.ReadLine();
            pirateLeChuck1();
        }

        public static void pirateLeChuck1()
        {
            string choice;

            Console.WriteLine("Just before LeChuck can pull the trigger on your wife, Lillian wisely stomps his shin and ");
            Console.WriteLine("ducks below the firearm the split second before LeChuck fires it. Lillian knocks the gun out ");
            Console.WriteLine("of LeChuck's hand, but LeChuck uses his strength to restrain Lillian again.");
            Console.WriteLine("Even without a gun, LeChuck could still be dangerous. Choose your action wisely.");
            Console.ReadLine();

            Console.WriteLine("You may have three options to approach this battle...");
            Console.WriteLine("Choose 1, 2 or 3...");
            Console.WriteLine("1. Do a Shoryuken (LeChuck towers over Lillian. He won't expect an uppercut.)");
            Console.WriteLine("2. Do a bicycle kick (Lillian got out of his grasp once, she could do it again.)");
            Console.WriteLine("3. Go into Kai-O-Ken (Quickest way to power up.)");
            Console.Write("What will you do: ");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "shoryuken":
                    {
                        Console.WriteLine("Press 'Enter' to find out what happens next...");
                        Console.ReadLine();
                        pirateLeChuck2();
                        break;
                    }
                case "2":
                case "bicyclekick":
                case "bicycle kick":
                    {
                        Console.WriteLine("Press 'Enter' to find out what happens next...");
                        Console.ReadLine();
                        bicycleKick();
                        break;
                    }
                case "3":
                case "kai o ken":
                case "kaioken":
                    {
                        Console.WriteLine("Press 'Enter' to find out what happens next...");
                        Console.ReadLine();
                        kaiOKen();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That's not a valid option. Please try again.");
                        Console.WriteLine("Hit 'Enter' to continue.");
                        Console.ReadLine();
                        pirateLeChuck1();
                        break;
                    }
            }
        }

        public static void bicycleKick()
        {
            Console.Clear();
            Console.WriteLine("Well, turns out Lillian couldn't get out of the way in time for you to hit LeChuck with ");
            Console.WriteLine("the bicycle kick and she gets used as a shield by LeChuck. LeChuck knocks you out and drags ");
            Console.WriteLine("you both away. He'll make you walk the plank and keep your wife as a trophy.");
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("Press 'Enter' to play again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void kaiOKen()
        {
            Console.Clear();
            Console.WriteLine("You grit your teeth and clench your buttcheeks and scream, 'KAI-O-KEN!'");
            Console.WriteLine("Unfortunately you can't use the Kai-O-Ken because you never mastered it.");
            Console.WriteLine("So LeChuck drag you and Lillian away.");
            Console.WriteLine("LeChuck eventually makes you walk the plank while he keeps your wife as a trophy.");
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("Press 'Enter' to play again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void pirateLeChuck2()
        {
            Console.WriteLine("POW! Sure enough! LeChuck did NOT see that one coming!");
            Console.ReadLine();

            Console.WriteLine("The Shuryuken was SUPER effective! So effective that LeChuck was sent flying upward...");
            Console.ReadLine();

            Console.WriteLine("...and back down, splashing into water. You take Lillian by the hand, lead her back to the raft...");
            Console.WriteLine("untie the raft from the dock and paddle away while LeChuck is left splashing in the water and cursing you.");
            Console.ReadLine();

            Console.WriteLine("You'll never cross paths again and Lillian is finding you especially attractive right now.");
            Console.WriteLine("Lillian gives you a rewarding thank you kiss and you both leave the Mystes O'Tyme Marshe.");
            Console.ReadLine();

            Console.WriteLine("'My hero,' Lillian says with a big grin. 'Now let's just relax the rest of this vacation. PLEASE!'");
            Console.ReadLine();
            monkeyIslandCont();
        }

        public static void monkeyIslandCont()
        {
            string choice;

            Console.WriteLine("It's only day two of your vacation. You can get drunk at the taverns and tan on the beach on the other days.");
            Console.WriteLine("What kind of mischief would you like to get into on day two?");
            Console.WriteLine("Unfortunately, the Fettuccine Brothers won't be an option today because they moved on with their tour.");
            Console.WriteLine("Current options: ");
            Console.WriteLine("1. Sail on the pirate ship and have some drinks.");
            Console.WriteLine("2. Go on a jungle safari!");
            Console.WriteLine("3. Nothing. Let's just enjoy what the beaches have to offer.");
            Console.Write("Choice: ");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "sail":
                    {
                        Console.WriteLine("'Drinking and cruising it is!' You shout out with excitement.");
                        Console.WriteLine("'Just keep under your five drink limit there, Sport,' Lillian laughs.");
                        Console.WriteLine("Let's go sailing!");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        pirateShip2();
                        break;
                    }
                case "2":
                case "safari":
                    {
                        Console.WriteLine("A jungle safari sounds like a lot of fun. Alright, let's go!");
                        Console.ReadLine();
                        safari();
                        break;
                    }
                case "3":
                case "nothing":
                    {
                        Console.WriteLine("'Ya know,' Lillian says approvingly. 'I'm not against that idea.'");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        monkeyIslandEnd();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That's not a valid option. Please try again.");
                        Console.WriteLine("Hit 'Enter' to continue.");
                        Console.ReadLine();
                        monkeyIslandCont();
                        break;
                    }
            }
        }

        public static void safari()
        {
            
            Console.WriteLine("You and Lillian wear your safari shorts and hats. After you both put on ");
            Console.WriteLine("plenty of bug spray, you're ready for the jungle safari.");
            Console.WriteLine("You have to take a boat to get to the jungle because it's located on a ");
            Console.WriteLine("separate island. It's still known as Dinky Island Jungle to this day.");
            Console.ReadLine();

            Console.WriteLine("The bug spray was a good idea, but fortunately you and Lillian stay ");
            Console.WriteLine("inside the jeep for the entirety of the safari. But at times you do ");
            Console.WriteLine("get an opportunity to get out to stretch your legs and take photographs.");
            Console.WriteLine("The jeep is pretty compact and you have to share it with another couple.");
            Console.ReadLine();

            Console.WriteLine("That means Lillian is sitting in the middle and she warned you about ");
            Console.WriteLine("making sandwich jokes. She poured Karmotrine on your head the last ");
            Console.WriteLine("time you made a Lill Sandwich joke. She also hates being called Lill.");
            Console.WriteLine("Because Lillian is careful to not rub against a stranger, she's ");
            Console.WriteLine("practically sitting on the right half of your body.");
            Console.ReadLine();

            Console.WriteLine("You hear a roar in the distance. The jeep stops despite your concerned ");
            Console.WriteLine("inquiry of how safe it is to stop after hearing such a roar.");
            Console.WriteLine("The driver in a very bored tone says, 'and coming up on your left is ");
            Console.WriteLine("a large and animated barrel known as Belcha. Those roars are actually ");
            Console.WriteLine("belches. Belcha was banished from Kong Island 26 years ago.'");
            Console.WriteLine("'You may now step out and take pictures. Belcha has been rendered harmless.'");
            Console.ReadLine();

            Console.WriteLine("You, Lillian and the other couple step outside the jeep. You stretch your ");
            Console.WriteLine("legs with relief to the sight of the gigantic barrel with a face emerging ");
            Console.WriteLine("from the trees and bushes. The barrel looks down upon you with a scowl, opens ");
            Console.WriteLine("his mouth wide and you press your back against the jeep behind you in panic as...");
            Console.ReadLine();

            Console.WriteLine("The gigantic barrel with a face lets out a lengthy belch. The odor was ");
            Console.WriteLine("powerful enough to kill the mosquitoes swarming between you and the barrel.");
            Console.WriteLine("'The barrel was once known to spit smaller inanimate barrels at its foes,'");
            Console.WriteLine("The driver explained in his bored tone. 'But Dixie Kong discovered that by ");
            Console.WriteLine("launching the barrels back into its mouth repeatedly she could render ");
            Console.WriteLine("Belcha defenseless by forcing him to belch his way into a nearby pit.'");
            Console.ReadLine();

            Console.WriteLine("'How fortunate for Dixie,' you nervously say as Belcha turns away and ");
            Console.WriteLine("retreats back into the jungle after having lost interest. You forgot to ");
            Console.WriteLine("take pictures in that moment, but fortunately Lillian was more prepared.");
            Console.WriteLine("The rest of the safari is less nerve wracking as you get to see ");
            Console.WriteLine("more animals banished from Kong Island including but not limited to ");
            Console.WriteLine("Manky Kong (disowned by the Kong Clan), Kritters, Zingers, and ");
            Console.WriteLine("animals not from Kong Island. Those animals including but not limited to ");
            Console.WriteLine("Ents, Mushroom people, Frog-Rays, Octolots, Wigglers, Epiolnis's and ");
            Console.WriteLine("more (from video games like Dark Souls, Super Mario RPG, FF7 and ");
            Console.WriteLine("other games with jungle enemies).");
            Console.ReadLine();

            Console.WriteLine("The duration of the safari was about two hours with bathroom stops at ");
            Console.WriteLine("well maintained shelters. The Dinky Island Jungle Safari was able to ");
            Console.WriteLine("upgrade from those horrid porta-potties with their strong budget that ");
            Console.WriteLine("skyrocketed thanks to tourists like Luke the Kook and Lillian.");
            Console.ReadLine();

            Console.WriteLine("After the safari was over with, you and Lillian head back to Monkey Island ");
            Console.WriteLine("via boat. As the sun is beginning to set it may be time to relax for the ");
            Console.WriteLine("rest of the day.");
            Console.ReadLine();

            Console.WriteLine("The best tavern in town, the Tiki Bikini Monkey, has vast outdoor seating ");
            Console.WriteLine("and you even managed to score a table by their annual bonfire.");
            Console.WriteLine("You and Lillian kick back a few drinks for the rest of the night ");
            Console.WriteLine("as fireflies add a little mood lighting to your evening.");
            Console.WriteLine("What a great way to end an amazing summer day.");
            Console.ReadLine();
            monkeyIslandEnd();
        }

        public static void monkeyIslandEnd()
        {
            Console.Clear();
            Console.WriteLine("You spend the rest of the vacation just enjoying the sun on the beach and ");
            Console.WriteLine("kicking back some Flaming Moais while Lillian enjoys her girly Sunshine Clouds.");
            Console.WriteLine("As the sun sets each night, you and Lillian even go out catching fireflies.");
            Console.WriteLine("This is what summer vacations are for.");
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("Press 'Enter' to play again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void cyrodiil()
        {
            string choice;

            Console.WriteLine("Well, here we are. In Cyrodiil. Now what?");
            Console.WriteLine("We could...");
            Console.WriteLine("1. Go to Imperial City.");
            Console.WriteLine("2. Go to Anvil.");
            Console.WriteLine("3. Go to Bravil.");
            Console.Write("Choice: ");
            
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "Imperial City":                
                    {
                        Console.WriteLine("Look out, Imperial City! We're on our way...");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        imperialCity();
                        break;
                    }
                case "2":
                case "Anvil":
                    {
                        Console.WriteLine("Anvil should be LOVELY this time of year.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        anvil();
                        break;
                    }
                case "3":
                case "Bravil":
                    {
                        Console.WriteLine("My body is ready for Bravil.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        bravil();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That command makes no sense to the current situation.");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        cyrodiil();
                        break;
                    }
            }
        }

        public static void imperialCity()
        {
            string choice;

            Console.WriteLine("Welcome to Imperial City! What do you want to do here?");
            Console.WriteLine("1. See a staged gladiator fight.");
            Console.WriteLine("2. Sail a boat around the town.");
            Console.WriteLine("3. Visit a tavern.");
            Console.Write("Choice: ");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "gladiator fight":
                    {
                        Console.WriteLine("ARE YOU NOT ENTERTAINED?! Let's go check out the arena.");
                        Console.WriteLine("The Arena doesn't do ACTUAL gladiator fights anymore.");
                        Console.WriteLine("It's all staged. Kinda like professional wrestling, but less predictable.");
                        Console.WriteLine("And there are NO DQ matches.");
                        Console.WriteLine("There are also no deaths. All acting. But sometimes people do accidentally get injured.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        arenaOptions();
                        break;
                    }
                case "2":
                case "sailing":
                    {
                        Console.WriteLine("Sounds like a great idea. Let's sail the lake surrounding the city.");
                        Console.ReadLine();
                        sailingImperial();
                        break;
                    }
                case "3":
                case "tavern":
                    {
                        Console.WriteLine("So what kind of taverns do they have here is a question that burns in your mind.");
                        Console.WriteLine("Your wife seems pretty curious too, but also expresses her concern over how much you'll drink.");
                        Console.WriteLine("'If you have too much, at least I have a carriage ride to look forward to,' Lillian tells you.");
                        Console.WriteLine("'Just try not to...vomit on the ride at the very least,' Lillian teases.");
                        Console.ReadLine();
                        imperialTavern();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("That command makes no sense to the current situation.");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        cyrodiil();
                        break;
                    }
            }
        }

        public static void arenaOptions()
        {
            string secChoice;

            Console.WriteLine("The ticket vendor asks if you are here to place a bet or fight in the arena.");
            Console.WriteLine("It's all staged, by the way. But the fighting is improvised and not choreographed.");
            Console.WriteLine("What'll it be, DJ? B for bet or f for fight. If you don't feel like typing out bet or fight.");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            Console.Clear();

            if (secChoice == "bet" || secChoice == "b")
            {
                Console.WriteLine("So you'd like to see if you can win some money while you're watching. Excellent!");
                Console.WriteLine("Here are your tickets and we have an usher who can escort you and Lillian to your seats.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                arenaBet();
            }
            else if (secChoice == "fight" || secChoice == "f")
            {
                Console.WriteLine("So you think you got what it takes to step in the arena, eh?");
                Console.WriteLine("Go see the blade master downstairs and get your gear on, Pit Dog!");
                Console.WriteLine("Er...please, anyway. We're trying to stay in character. You're a great customer.");
                Console.WriteLine("We love dogs here at the arena, by the way. All sizes and breeds.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                bladeMaster();
            }
            else
            {
                Console.WriteLine("That command makes no sense to the current situation.");
                Console.WriteLine("Hint: If you're too lazy to type out yes or no, then the letters they start with will suffice.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                arenaOptions();
            }
        }

        public static void arenaBet()
        {
            Random rnd = new Random();
            string[] secOptions = { "Congratulations! You won 100 gold. Would you like to treat Lillian to a drink at the King and Queen?",
            "Holy moly! You won 200 gold. Want to treat your wife to a drink or two at the King and Queen?",
            "FUS...WHOA DERE! 300 GOLD! Lillian asks to celebrate by getting her a drink at the King and Queen while watching the sunset."};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;
            Console.WriteLine(secText);
            Console.WriteLine("Should you treat your beautiful wife?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("'Going to treat your wife at a tavern? We think not,' someone says.");
                Console.WriteLine("Whu-oh. This someone is apparently an Argonian mugger. You just lost all your winnings...and more.");
                Console.ReadLine();
                arenaGameOver();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("'Oh, I only won some pocket change,' you tell Lillian in a hushed voice.");
                Console.WriteLine("You make sure no one sus is in ear shot before you whisper in her, 'name your limit, babe.'");
                Console.WriteLine("Saying yes as excited as you are is a surefire way to getting mugged on the way to the King and Queen.");
                Console.WriteLine("You might even be in the mood for MORE than just the King and Queen Tavern.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                imperialTavern();
            }
            else
            {
                Console.WriteLine("That command makes no sense to the current situation.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                arenaBet();
            }
        }

        public static void arenaGameOver()
        {
            Console.Clear();
            Console.WriteLine("Maybe you should've remained quiet about your bet winnings. Now the vacation is ruined.");
            Console.WriteLine("Good thing in this case Luke the Kook has a special time travel device that can help him reset this whole event.");
            Console.WriteLine("Unfortunately, it's a rental device with little to no control over how far back he goes.");
            Console.WriteLine("Would you like to try again? You'll be taken back to the Radio Tower of Power.");
            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void bladeMaster()
        {
            
            Console.WriteLine("You meet the blade master and he introduces himself as Owyn...");
            Console.ReadLine();

            Console.WriteLine("that is after he says, 'front and center, PIT Dog.'");
            Console.ReadLine();

            Console.WriteLine("You quickly realize THIS cast member may be unapologetically into his role...");
            Console.ReadLine();

            Console.WriteLine("unlike the other cast members thus far.");
            Console.ReadLine();

            Console.WriteLine("'What size shirt are you, Pit Dog?' Owyn barks at you (not like a literal bark...)");
            Console.ReadLine();

            Console.WriteLine("You play along in character and stand at attention to answer him, ");
            Console.WriteLine("'SIZE LARGE, SIR!'");
            Console.ReadLine();

            Console.WriteLine("'REALLY?! Size Large? COULDA FOOLED ME! You look like a MEDIUM!' Owyn responds.");
            Console.ReadLine();

            Console.WriteLine("'NO, SIR! MEDIUM IS TOO TIGHT AND RESTRICTIVE, SIR!' You shout back.");
            Console.ReadLine();

            Console.WriteLine("'We don't need to see any of THAT...' Owyn responds in disgust.");
            Console.WriteLine("You are handed blue chain mail armor your size to put on.");
            Console.WriteLine("They're plastic chains...like from the Halloween stores.");
            Console.WriteLine("The fake armor fits you comfortably.");
            Console.ReadLine();

            Console.WriteLine("Owyn sizes you up and down, pauses briefly and...");
            Console.ReadLine();

            Console.WriteLine("'YOU LOOK FABULOUS!' Owyn excitedly shouts in a lisp with several claps of his hands.");
            Console.WriteLine("'Ahem...' Owyn then clears his throat as a single drop of sweat pours from his forehead ");
            Console.WriteLine("with cheeks flushed red out of embarrassment. Like he's straight out of an anime.");
            Console.ReadLine();

            Console.WriteLine("'Apologies,' said Owyn. 'I broke character for a second. I meant to say, not bad...PIT Dog.'");
            Console.ReadLine();

            Console.WriteLine("'Your sword is made of plastic, but it can still hurt like hell, so be careful,' Owyn ");
            Console.WriteLine("explains as he hands you a two handed Claymore sword. 'It's two handed, so you can use it ");
            Console.WriteLine("to block as well as melee the heck out of your opponent. You'll be fighting someone on the ");
            Console.WriteLine("yellow team. Stab him in the gut or swing at his neck to win the battle.'");
            Console.ReadLine();

            Console.WriteLine("'If he does either of those to you, then it's game over for you.'");
            Console.ReadLine();

            Console.WriteLine("'You can also use magic on your opponent. Raise your hand like the Undertaker to signify ");
            Console.WriteLine("to the special effects crew that you're summoning your magic ability. Then twirl your arm ");
            Console.WriteLine("as if you're throwing an underhand softball pitch and leave the rest up to the technicians.'");
            Console.ReadLine();

            Console.WriteLine("'They'll use one of the basic elemental mana attacks to make it look good.'");
            Console.WriteLine("'A single magic attack might not be enough to fall your opponent unless his back is turned.'");
            Console.ReadLine();

            Console.WriteLine("'Remember...the same can be done to you,' Owyn continues to brief.");
            Console.WriteLine("'Any questions?' Owyn asks you.");
            Console.ReadLine();

            Console.WriteLine("'Yeah...just one. What about ranged attacks like bows and arrows? I mean the arrows with ");
            Console.WriteLine("the suction cups in place of the sharp tip,' you inquire.");
            Console.WriteLine("You believe it to be a rather reasonable question. Ranged attacks would be pretty cool too.");
            Console.ReadLine();

            Console.WriteLine("'You really think we'd let people use even the suction cup arrows on each other?!' ");
            Console.WriteLine("the blade master reacts in disgust. 'You'll shoot someone's eye out, kid!'");
            Console.ReadLine();

            Console.WriteLine("'Even those suction cup arrows are dangerous,' the blade master continues to lecture.");
            Console.ReadLine();

            Console.WriteLine("'Happy combat!' the blade master says as he pushes you out the door. 'Ha...'");
            Console.ReadLine();

            Console.WriteLine("'Ha...'");
            Console.ReadLine();

            Console.WriteLine("'Haaaa!'");
            Console.ReadLine();

            Console.WriteLine("'A simple yes or no would've sufficed from that guy, you think to yourself.'");
            Console.ReadLine();

            Console.WriteLine("He didn't have to be so condescending about it...");
            Console.ReadLine();
            arenaCombat();
        }
        public static void arenaCombat()
        {
            string choice;
            //all that's required here is a switch case scenario
            //this game was already established as an adventure, not an RPG
            Console.WriteLine("'Good people of the Imperial! Welcome to the arena!' announces the announcer as you ");
            Console.WriteLine("wait for the gates to be lowered. 'The blue team's combatant hails from Virtuaville ");
            Console.WriteLine("and manages and DJ's WASD FM at the Radio Tower of Power! His name...is Luke the Kook.'");
            Console.ReadLine();

            Console.WriteLine("You sweat nervously as the audience remains dead silent.");
            Console.ReadLine();

            Console.WriteLine("'Who and what?' You hear one person in the audience shout.");
            Console.ReadLine();

            Console.WriteLine("'And the combatant from the yellow team is a technician specialist from the Sigmund Corporation.'");
            Console.ReadLine();

            Console.WriteLine("'His name.....is Neil Watts!'");
            Console.WriteLine("Are those crickets you hear chirping? Literally????");
            Console.ReadLine();

            Console.WriteLine("'What and who?' You hear from that same guy.");
            Console.ReadLine();

            Console.WriteLine("Nowwww. LOWER THE GATES!");
            Console.ReadLine();

            Console.WriteLine("The gates lower and you emerge to face your opponent...Neil.");
            Console.WriteLine("But HE'LL be the one to kneel. Press 'Enter' to view your options.");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Enter just one of these three numbers for this situation:");
            Console.WriteLine("1. Let out your roaring battle cry to intimidate your foe.");
            Console.WriteLine("2. Charge at Neil with everything you got!");
            Console.WriteLine("3. Play defense and see what he does first.");
            Console.Write("Strategy: ");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "intimidate":
                    {
                        Console.WriteLine("You let out a tremendous ROAR. It kinda hurts your throat a little...");
                        Console.ReadLine();
                        arenaCombatFinale();
                        break;
                    }
                case "2":
                case "charge":
                    {
                        Console.WriteLine("'HERE I COME!' You shout at Neil as you charge toward him.");
                        Console.ReadLine();
                        arenaCombatFinale();
                        break;
                    }
                case "3":
                case "defend":
                    {
                        Console.WriteLine("'Come at me, bro!' You shout at Neil.");
                        Console.ReadLine();
                        arenaCombatFinale();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You don't listen to instructions very well, do you?");
                        Console.WriteLine("Are you missing your number keys or something? 1, 2, 3 OR 4!");
                        Console.ReadLine();
                        arenaCombat();
                        break;
                    }
            }
        }

        public static void arenaCombatFinale()
        {
            string secChoice;

            Console.WriteLine("Huh? What's this? Your opponent is just...running away from you.");
            Console.WriteLine("Don't know why. He has nowhere to go as he just keeps running circles around the arena.");
            Console.WriteLine("You hear Lillian from the crowd as the first person to shout 'BOO! STAND YOUR GROUND ");
            Console.WriteLine("AND FIGHT, WUSSY!' ");
            Console.ReadLine();

            Console.WriteLine("Using magic is an option, but you're not quite sure if you remember the blade master's ");
            Console.WriteLine("instructions as how to use it. Apparently, neither does the other guy...");
            Console.WriteLine("Do you want to...");
            Console.WriteLine("Type 'sword' or 's' to keep swinging your sword at the guy?");
            Console.WriteLine("Or type 'magic' or 'm' to try out that magic special effect?");
            Console.Write("It's up to you: ");
            secChoice = Console.ReadLine().ToLower();

            Console.Clear();

            if (secChoice == "sword" || secChoice == "s")
            {
                Console.WriteLine("Sword it is! You charge after your opponent with a war cry...");
                Console.ReadLine();
                arenaMeleeFinale();
            }
            else if (secChoice == "magic" || secChoice == "m")
            {
                Console.WriteLine("Neil's back is always turned to you...it might only require one attack ");
                Console.WriteLine("for a kill shot. Kinda wanna see what magic in this production looks like anyway.");
                Console.ReadLine();
                arenaMagicFinale();
            }
            else
            {
                Console.WriteLine("Uh....no. C'mon! You're messing with the flow of the story.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                arenaCombatFinale();
            }
        }

        public static void arenaMeleeFinale()
        {
            //Luke should chase his opponent around for so long that they play the Benny Hill theme over the speakers.
            Console.WriteLine("You chase Neil around the arena. At times you think you're close enough to strike him...");
            Console.ReadLine();

            Console.WriteLine("But you just end up striking your sword at air.");
            Console.ReadLine();

            Console.WriteLine("You continue to chase Neil around the arena who cries for someone named 'Eva' to help him.");
            Console.ReadLine();
            
            Console.WriteLine("You hear from who you assume to be Eva to shout back...");
            Console.ReadLine();

            Console.WriteLine("'I knew this would be fun... More for me than for you.'");
            Console.ReadLine();

            Console.WriteLine("The rest of the audience just groans in boredom as you continue your pursuit.");
            Console.ReadLine();

            Console.WriteLine("Some people in the audience just get up and walk away.");
            Console.ReadLine();

            Console.WriteLine("You hear amongst the groans people shouting 'where do I get my money back?'");
            Console.ReadLine();

            Console.WriteLine("You're still chasing Neil in circles around the arena by the way...");
            Console.ReadLine();

            Console.WriteLine("Don't know why he bothered participating if he's behaving this way...");
            Console.ReadLine();

            Console.WriteLine("Unless he's got something up his sleeves?");
            Console.ReadLine();

            Console.WriteLine("I mean, why IS he so scared? He's not ACTUALLY going to die in this arena.");
            Console.ReadLine();

            Console.WriteLine("'This could go on for a while,' you hear the announcer. 'Let's put some music on.'");
            Console.ReadLine();

            Console.WriteLine("Oh, great. You hear the Benny Hill theme over the loudspeakers. People start laughing.");
            Console.ReadLine();

            Console.WriteLine("You start getting frustrated by the fact that you haven't caught Neil by now.");
            Console.ReadLine();

            Console.WriteLine("And the Benny Hill theme is still going...");
            Console.ReadLine();

            Console.WriteLine("Neil starts getting a little winded and slows down.");
            Console.ReadLine();

            Console.WriteLine("'Finally!' You shout out loud as you go straight for the kill strike.");
            Console.ReadLine();

            Console.WriteLine("You swing your sword directly at Neil's neck, but in your frustration you hit him ");
            Console.WriteLine("harder than intended. He falls over holding his neck, 'OW! That's why I was running...'");
            Console.ReadLine();

            Console.WriteLine("You roll your eyes.");
            Console.ReadLine();

            Console.WriteLine("And so does everyone else in the audience.");
            Console.ReadLine();

            Console.WriteLine("You know for a fact that Lillian rolled her eyes and probably even face palmed.");
            Console.ReadLine();

            Console.WriteLine("'Well, that sucked!' That one guy shouts.");
            Console.ReadLine();

            Console.WriteLine("And the audience just laughs and boos.");
            Console.ReadLine();

            Console.WriteLine("'Good people, we have a winner! All hail the combatant...from the BLUE team!'");
            Console.WriteLine("'Victor from the blue team, leave the arena now and rest. You've EARNED it!'");
            Console.WriteLine("But the audience is still booing you.");
            Console.ReadLine();

            Console.WriteLine("Oh well.");
            Console.ReadLine();

            Console.WriteLine("You feel the need to take Lillian to some taverns so you can drink to forget this moment.");
            Console.ReadLine();
            imperialTavern();

            Console.Clear();
        }

        public static void arenaMagicFinale()
        {
            Console.WriteLine("You turn the palm of your hand upward with fingers in a claw like shape...");
            Console.WriteLine("and you raised your hand upward.");
            Console.ReadLine();

            Console.WriteLine("The special effects technician understands you by lighting off some pyro near the gate ");
            Console.WriteLine("that you emerged from.");
            Console.ReadLine();

            Console.WriteLine("Dizzying lights start to flash all around the arena.");
            Console.ReadLine();

            Console.WriteLine("The audience is ROARING with applause!");
            Console.ReadLine();

            Console.WriteLine("You get into character and let out a menacing roar!");
            Console.WriteLine("Then you swirl your arm around and make that softball pitch...");
            Console.ReadLine();

            Console.WriteLine("The arena lights up and Neil is suddenly engulfed and dazed by a blinding red spotlight!");
            Console.ReadLine();

            Console.WriteLine("Neil is then ejected upward by a spring floor underneath him.");
            Console.ReadLine();

            Console.WriteLine("Neil falls onto a trampoline that emerges in the center of the ring.");
            Console.ReadLine();

            Console.WriteLine("Neil lets out a painful groan.");
            Console.ReadLine();

            Console.WriteLine("'Good people, we have a winner! All hail the combatant...from the BLUE team!'");
            Console.WriteLine("'Victor from the blue team, leave the arena now and rest. You've EARNED it!'");
            Console.WriteLine("The audience showers you with adulation as you jump up and fist pump the air.");
            Console.ReadLine();

            Console.WriteLine("You then bow as you are showered with roses while Neil is pelted with fruits and vegetables.");
            Console.ReadLine();

            Console.WriteLine("You then realize that what you did to Neil could've happened to you...");
            Console.ReadLine();

            Console.WriteLine("And either way it could've gone horribly wrong...");
            Console.ReadLine();

            Console.WriteLine("You sweat and let out a sigh of relief that things didn't go worse as Neil collects himself.");
            Console.ReadLine();
            arenaWinnings();

            Console.Clear();
        }

        public static void arenaWinnings()
        {
            Random rnd = new Random();
            string[] secOptions = { "Wow! You won 500 gold from this victory.",
            "Wow! You won 1000 gold from this victory.",
            "ULTRAAAAAAAAAA! You won 2000 gold from this victory!!!"};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;
            Console.WriteLine(secText);
            Console.WriteLine("Should you take Lillian out to celebrate?! Yes/y or No/n?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("You scoop Lillian up in your arms and take her to the King and Queen Tavern.");
                Console.ReadLine();
                yesGameOver();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("You say no, but you mean yes.");
                Console.WriteLine("You and Lillian even take a carriage to the King and Queen Tavern.");
                Console.WriteLine("Can't be too careful and don't want to risk getting lost in some of these ");
                Console.WriteLine("dark alleyways.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                pickYourPoisonIntake();
            }
            else
            {
                Console.WriteLine("That command makes no sense to the current situation.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                arenaWinnings();
            }
        }

        public static void pickYourPoisonIntake()
        {
            int drinks;

            Console.WriteLine("You make it to the King and Queen Tavern!");
            Console.WriteLine("Enter your poison intake.");
            Console.Write("Drinks: ");
            int.TryParse(Console.ReadLine(), out drinks);
            while (drinks < 8)
            {
                Console.WriteLine("Really?! ONLY that many drinks? Enter that number again.");
                Console.WriteLine("We're on vacation here. How many drinks really?");
                Console.WriteLine("Drinks: ");
                int.TryParse(Console.ReadLine(), out drinks);
            }
            while (drinks > 9)
            {
                Console.WriteLine("Whoops. We might've gone a little overboard with that number. You just drank yourself into oblivion.");
                Console.WriteLine("Luke didn't even make it close to his goal and he passed out.");
                Console.WriteLine("Lillian gets help from a Khajiit to carry you to bed.");
                Console.WriteLine("Sweet dreams until tomorrow.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                imperialCity2();
            }

        }
        public static void yesGameOver()
        {
            Console.Clear();
            Console.WriteLine("Unfortunately, you get lost in a dark alleyway while carrying Lillian.");
            Console.ReadLine();

            Console.WriteLine("You find yourself quickly swarmed by Argonians.");
            Console.ReadLine();

            Console.WriteLine("The Argonians rough you up and mug you of your winnings and then some.");
            Console.ReadLine();

            Console.WriteLine("Maybe you should've remained quiet about your winnings. Now the vacation is ruined.");
            Console.WriteLine("Good thing in this case Luke the Kook has a special time travel device that can help him reset this whole event.");
            Console.WriteLine("Unfortunately, it's a rental device with little to no control over how far back he goes.");
            Console.WriteLine("Would you like to try again? You'll be taken back to the Radio Tower of Power.");
            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void sailingImperial()
        {
            string secChoice;

            Console.WriteLine("Would you like some of Cyrodiil's finest rum while you enjoy the scenery?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            Console.Clear();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("You get a bit tipsy and start singing along with the minstrels.");
                Console.WriteLine("It's been a fun day. Lillian helps you back to the inn. What a good wife.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                imperialCity2();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("You stay sober and take in the fresh water breeze.");
                Console.WriteLine("What a great day!");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                imperialCity2();
            }
            else
            {
                Console.WriteLine("That command makes no sense to the current situation.");
                Console.WriteLine("Hint: If you're too lazy to type out yes or no, then the letters they start with will suffice.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                sailingImperial();
            }
        }
        public static void imperialTavern()
        {
            int taverns;

            Console.WriteLine("Well, we're hitting up the King and Queen for sure...");
            Console.WriteLine("But there are eleven other taverns we can hit up.");
            Console.WriteLine("Since Lillian wants to bar hop too (which is rare) how many should we hop to between 1 and 12?");
            Console.Write("taverns: ");
            int.TryParse(Console.ReadLine(), out taverns);
            while (taverns <= 5)
            {
                Console.WriteLine("It's good to let loose sometimes and have a little fun.");
                Console.WriteLine("You even enjoy the sunset with Lillian while you feel your head spinning.");
                Console.WriteLine("Hope that no one puts on 'You Spin Me Round (Like a Record)'. That might make you vomit.");
                Console.WriteLine("Hit 'Enter' to continue.");
                Console.ReadLine();
                imperialCity2();
                //imperialTavern();
            }
            while (taverns <= 12)
            {
                Console.WriteLine("You are completely blitzed! You start table dancing and stripping to 'Toss a coin to your Witcher'.");
                Console.WriteLine("Even the minstrels are tossing their coins at you.");
                Console.WriteLine("Lillian, knowing this was gonna happen, calls a carriage to the inn you both are staying at.");
                Console.WriteLine("She gets to enjoy the carriage ride while you pass out on her lap.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                imperialCity2();
                //imperialTavern();
            }
            while (taverns > 12)
            {
                Console.WriteLine("It's true that Imperial City has a lot of taverns....");
                Console.WriteLine("but Imperial City doesn't have THAT many taverns.");
                Console.WriteLine("Try to keep it under 12. We don't want Luke and Lillian to have alcohol poisoning.");
                Console.WriteLine("Smash that 'Enter' button to try again before getting smashed...hammered...boozed up. Whatever...");
                Console.ReadLine();
                imperialTavern();
            }
        }
        public static void anvil()
        {
            string choice;

            Console.WriteLine("Here we are in Anvil. Are those seagulls AND pelicans you hear?");
            Console.WriteLine("What do you want to do in Anvil?");
            Console.WriteLine("1. Tour the castle.");
            Console.WriteLine("2. Meditate at the Chapel of Dibella.");
            Console.WriteLine("3. Tan on the beach and end the day at the harbor during sunset.");
            Console.Write("Choice: ");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "tour the castle":
                case "castle":
                    {
                        Console.WriteLine("You and Lillian head to the island outside the city to tour the castle.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        castle();
                        break;
                    }
                case "2":
                case "meditate at the chapel":
                case "meditate":
                    {
                        Console.WriteLine("Lillian is actually pretty interested in meditating at the Chapel of Dibella.");
                        Console.WriteLine("After about an hour of meditating to the sounds of birds, the bees and trinkling fountain water ");
                        Console.WriteLine("you both find yourselves to be refreshed and relaxed. It's like a day at the spa.");
                        Console.WriteLine("What a good way to spend the day. You and Lillian decide to enjoy the rest of it just touring around town.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        cyrodiil2();
                        break;
                    }
                case "3":
                case "tan on the beach":
                case "beach":
                    {
                        Console.WriteLine("What a relaxing day at the beach. Lillian sure is pretty happy to get a tan in.");
                        Console.WriteLine("Ending the day at the harbor during sunset was like icing on the cake.");
                        Console.WriteLine("The sounds of waves crashing along the shore outside your inn window rocks ");
                        Console.WriteLine("you and Lillian to sleep. Sweet dreams, love birds.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        cyrodiil2();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Oh yeah...we should've thought of that one, but we didn't.");
                        Console.WriteLine("Hint: Use your number pad to select one of the three options.");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        anvil();
                        break;
                    }
            }
        }

        public static void castle()
        {
            Console.WriteLine("Welcome to Anvil Castle.");
            Console.WriteLine("We start off in the Great Hall with the rest of the tour group...");
            Console.ReadLine();

            Console.WriteLine("...that you and Lillian end up ditching to see what rooms you can ");
            Console.WriteLine("explore on your own. You and Lillian go through a door that leads ");
            Console.WriteLine("to the Smithy. You see a large man hammering away at an old two-");
            Console.WriteLine("handed weapon. The man has a white mane of long hair and a long ");
            Console.WriteLine("white beard. He sees you and Lillian and stops hammering to say, ");
            Console.ReadLine();

            Console.WriteLine("'Ah. A pair of newcomers, I see. I am Andre, I serve in this castle ");
            Console.WriteLine("as a humble smith forging new weapons from old,' Andre introduces him-");
            Console.WriteLine("self. 'Are you part of the tour group?' he asks.");
            Console.ReadLine();

            Console.WriteLine("You and Lillian nod your heads, staying quiet in awe of Andre's ");
            Console.WriteLine("massive and intimidatingly muscular size.");
            Console.WriteLine("'Trick question. I know,' says Andre. 'The tour group is completely ");
            Console.WriteLine("optional. You already paid to tour the castle. The group is for ");
            Console.WriteLine("a deeper understanding of the history. Not for everyone,' Andre ");
            Console.WriteLine("says with a sparkle in his eyes as he gives a warm smile. 'Enjoy.'");
            Console.ReadLine();

            Console.WriteLine("Without even missing a beat, Andre returns to hammering away at the ");
            Console.WriteLine("weapon. You and Lillian thank Andre for his time and pass through ");
            Console.WriteLine("the Smithy and make your way upward of the castle while looking for ");
            Console.WriteLine("any doors that lead to the roof. Not exactly knowing your way around ");
            Console.WriteLine("the castle, you two end up in the top of one of the tower portions ");
            Console.WriteLine("of the castle and are able to peer out over the half wall and listen ");
            Console.WriteLine("to the birds chirping. You and Lillian follow the cylindrical wall ");
            Console.WriteLine("to the other side of the tower and overlook the ocean crashing its ");
            Console.WriteLine("waves against the shore.");
            Console.ReadLine();

            Console.WriteLine("You and Lillian spend a good amount of time in the tower until you ");
            Console.WriteLine("hear the rest of the tour group catching up to you, so you decide to ");
            Console.WriteLine("make your faces seen as you casually slip past them and on your ");
            Console.WriteLine("way toward the roof access after you figure out how to get there.");
            Console.ReadLine();

            Console.WriteLine("After spending several minutes taking pictures on the Castle rooftop,");
            Console.WriteLine("you hear a wyvern fly by. The tour guide still in the tower with ");
            Console.WriteLine("the rest of the group is overheard explaining that wyverns were ");
            Console.WriteLine("once mistaken for dragons back in 4E 201. They used to represent ");
            Console.WriteLine("an oncoming war being brought on the world by the ancient Alduin.");
            Console.ReadLine();

            Console.WriteLine("Now with the advancements of technology and the merging of other worlds ");
            Console.WriteLine("wyverns have grown tame and are only dangerous when they are drinking ");
            Console.WriteLine("and flying. Which doesn't happen often, because they have high tolerance.");
            Console.ReadLine();

            Console.WriteLine("You and Lillian smile and snap photos of the wyvern flying overhead.");
            Console.WriteLine("The wyvern continues to fly into the horizon over the ocean.");
            Console.ReadLine();

            Console.WriteLine("After enjoying the rest of the castle, you and Lillian to decide to ");
            Console.WriteLine("end the day the right way by joining your tour group for a grand feast ");
            Console.WriteLine("in the Dining Hall of the castle. What a terrific day.");
            Console.ReadLine();
            cyrodiil2();
        }

        public static void bravil()
        {
            string choice;

            Console.WriteLine("So this is Bravil. It doesn't seem like there's a whole lot to do here.");
            Console.WriteLine("What do you want to do in Bravil?");
            Console.WriteLine("1. Sail along Niben Bay.");
            Console.WriteLine("2. Take a ferry up to Imperial City.");
            Console.WriteLine("3. Drink at the Skooma Den and end the day watching the Will-O-Wisps.");
            Console.Write("Choice: ");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "sail niben bay":
                case "sail":
                    {
                        Console.WriteLine("Geez...it seems like there's an option for sailing just about anywhere these days....");
                        Console.WriteLine("You and your wife cozy against each other and take in that fresh water breeze.");
                        Console.WriteLine("When the sailing is all said it done, you both tour around Bravil and shop at their markets.");
                        Console.WriteLine("Even if it's mostly window shopping. The nice, long day in the sun comes to an end ");
                        Console.WriteLine("as the sun sets in the horizon and the will-o-wisps appear in the woods.");
                        Console.WriteLine("You are eager to see what tomorrow brings.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        cyrodiil2();
                        break;
                    }
                case "2":
                case "take a ferry to Imperial City":
                case "ferry":
                    {
                        Console.WriteLine("Geez...it seems like there's an option for sailing just about anywhere these days...");
                        Console.WriteLine("Does a ferry count as sailing? Well, to Luke the Kook it does.");
                        Console.WriteLine("The ferry takes us to Imperial City.");
                        Console.WriteLine("You almost reach Imperial City too until you fall off the ferry trying to catch a dragonfly.");
                        Console.WriteLine("Way to go, you idiot. Your wife, being as wonderful as she is, dives in the water after you.");
                        Console.WriteLine("Imperial City isn't too far. We'll enjoy a nice swim the rest of the way there.");
                        Console.WriteLine("Luke the Kook has been wanting to work on his backstroke all day.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        shiveringIsles();
                        break;
                    }
                case "3":
                case "drink at the Skooma Den":
                case "drink":
                    {
                        Console.WriteLine("You and Lillian enjoys some drinks at the Skooma Den.");
                        Console.WriteLine("This used to be a run down house for addicts hundreds of years ago...");
                        Console.WriteLine("Now it doesn't even come close to resembling it's old self with every ");
                        Console.WriteLine("beam of wood having been replaced over a century ago.");
                        Console.WriteLine("Now it's a fun hangout spot where singles usually meet each other.");
                        Console.WriteLine("Addicts hardly even exist anymore with Bravil's excellent counseling services.");
                        Console.WriteLine("Not like you want to think about any of that now anyway. Time to enjoy the stars.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        cyrodiil2();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Oh yeah...we should've thought of that one, but we didn't.");
                        Console.WriteLine("Hint: Use your number pad to select one of the three options.");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        bravil();
                        break;
                    }
            }
        }

        public static void cyrodiil2()
        {
            Console.WriteLine("It's the end of day one of your vacation in Cyrodiil and Luke has a hankering for ");
            Console.WriteLine("checking out Skingrad. ");
            Console.WriteLine("There won't be any stopping him. He's just curious as to what it's like in person.");
            Console.ReadLine();
            imperialCity2();

            Console.Clear();
        }

        public static void monkeyIsland2()
        {
            Console.WriteLine("Well, that was odd. No, this didn't take us to the Shivering Isles...");
            Console.ReadLine();

            Console.WriteLine("But instead we ended up on Monkey Island after all.");
            Console.ReadLine();

            Console.WriteLine("It was almost like we were meant to come to Monkey Island all along....");
            Console.ReadLine();

            Console.WriteLine("'So...' says Lillian. 'Guess we ended up on Monkey Island anyway.'");
            Console.WriteLine("It is day two of your vacation, so you have plenty left to enjoy still.");
            Console.ReadLine();

            Console.WriteLine("Might as well make the most out of Monkey Island while we're still here.");
            Console.WriteLine("There's a handful of things we can do here.");
            Console.ReadLine();

            Console.WriteLine("Might as well hit 'Enter' to explore our Monkey Island options.");
            Console.ReadLine();
            monkeyIslandCont();
        }

        public static void imperialCity2()
        {
            string secChoice;

            Console.WriteLine("The next day you decide to take a walk along the Gold Road toward Skingrad.");
            Console.WriteLine("You are warned by the locals to stay on the road.");
            Console.WriteLine("'By the Nine! Stay on the roads!' their voices echo in your mind.");
            Console.ReadLine();

            Console.WriteLine("But it doesn't seem to work out for you anyway when you're attacked by a goblin!");
            Console.WriteLine("What do you do?");
            Console.ReadLine();

            Console.WriteLine("Lillian hides behind you and says, 'gonna follow your orders, hun!'");
            Console.WriteLine("'What do we do here? Fight the goblin or run away?'");
            Console.WriteLine("Here are your options F = fight. E = escape.");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            Console.Clear();

            if (secChoice == "fight" || secChoice == "f")
            {
                Console.WriteLine("Just ONE goblin? Luke and Lillian can't let just ONE goblin bully them.");
                Console.WriteLine("You decide to engage the goblin in battle in order to send a message to any other ");
                Console.WriteLine("wannabe highwaymen of Cyrodiil.");
                Console.WriteLine("'THIS IS A PUBLIC ROAD!' You shout at the goblin in a war cry.");
                Console.WriteLine("'THUS IF YOU ARE HERE TO TOLL US...WHY...TAXATION IS THEFT! PUT UP YOUR DUKES!'");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                goblinBattle();
            }
            else if (secChoice == "escape" || secChoice == "e")
            {
                Console.WriteLine("Lillian's bright skin blinds the goblin as a distraction. Looks like hardly getting a chance ");
                Console.WriteLine("for her to tan has benefitted the both of you in this situation. You both run and make your escape ");
                Console.WriteLine("heading to Imperial City where you both decide to finish out the rest of the vacation.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                imperialCity3();
            }
            else
            {
                Console.WriteLine("That command makes no sense to the current situation.");
                Console.WriteLine("Hint: If you're too lazy to type out yes or no, then the letters they start with will suffice.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                imperialCity2();
            }

        }

        public static void goblinBattle()
        {
            string choice;
            //standard switch case scenario
            //you can get a better result by starting the battle with Lillian blinding the goblin with her whiteness
            //her tanless skin circles back to her mentioning she wants to get her tan on earlier
            //so there's a pay off to what otherwise would've been a one off joke
            //there's no way Luke and Lillian are going to lose to one goblin
            //but if you don't blind the goblin first, then he might mug Luke and Lillian before running away
            Console.WriteLine("So you've chosen to fight the little monster!");
            Console.WriteLine("Choose between these four options as your first plan of attack!");
            Console.WriteLine("1. Go into KA-RAZY mode (Make the goblin DIE 1000 DEATHS)! ");
            Console.WriteLine("2. Go into KUNG FU mode!");
            Console.WriteLine("3. SHORYUKEN!");
            Console.WriteLine("4. Blind your enemy with Lillian's tanless skin!");
            Console.Write("Your strategy: ");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("'I'M GONNA MAKE YOUR DIE 1000 DEATHS, VILLAIN!' You shout at the goblin ");
                        Console.WriteLine("as you charge forward.");
                        Console.WriteLine("Press 'Enter' to see what happens next!");
                        Console.ReadLine();
                        crazy();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You realize you don't know Kung Fu...");
                        Console.WriteLine("But you know KA-RAZY!");
                        Console.ReadLine();
                        crazy();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You'll have to get closer to the goblin in order to execute the move.");
                        Console.WriteLine("Press 'Enter' to see what happens next.");
                        Console.ReadLine();
                        crazy();
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Lillian's fair skin under this bright sun may give us an advantage...");
                        Console.WriteLine("Press 'Enter' to see what happens next.");
                        Console.ReadLine();
                        blindGoblin();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Your only options are 1, 2, 3 or 4 here, knucklehead.");
                        Console.WriteLine("Just type one of those.");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        goblinBattle();
                        break;
                    }
            }
        }

        public static void crazy()
        {
            Console.WriteLine("You need to get closer to the goblin for a proper attack and charge toward him.");
            Console.ReadLine();

            Console.WriteLine("Whoa! You step on a rock wrong and trip over.");
            Console.ReadLine();

            Console.WriteLine("Apparently Lillian was charging after the goblin right behind you and she trips over you.");
            Console.ReadLine();

            Console.WriteLine("She has a slightly softer landing than you did, but the fall still dazed her.");
            Console.ReadLine();

            Console.WriteLine("You are at more of a disadvantage because you're dazed and pinned.");
            Console.ReadLine();

            Console.WriteLine("You hear the goblin let out a laugh as he approaches the two of you.");
            Console.ReadLine();

            Console.WriteLine("You feel the goblin digging through your pockets, but there isn't much you can do about it.");
            Console.ReadLine();

            Console.WriteLine("Apparently you just got robbed and the goblin makes his escape back into the woods.");
            Console.WriteLine("How much did he take?");
            Console.ReadLine();
            youGetMugged();
        }
        public static void youGetMugged()
        {
            Random rnd = new Random();
            string[] secOptions = { "The goblin only took about 5 gold off you. Not a big deal.",
            "You find out that you got robbed of about 10 gold. Well, whatever...",
            "Looks like that goblin just robbed you of 50 gold between you and Lillian's pockets."};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;
            Console.WriteLine(secText);
            Console.WriteLine("Are you still in the mood for Skingrad? Yes/y or No/n?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("You and Lillian shake yourselves off.");
                Console.WriteLine("A little misfortune won't stop us from going to Skingrad.");
                Console.ReadLine();
                skingrad();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("Maybe going to Skingrad was bad luck.");
                Console.WriteLine("Let's just go to Imperial City for the remainder of the vacation.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                imperialCity3();
            }
            else
            {
                Console.WriteLine("That command makes no sense to the current situation.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                youGetMugged();
            }
        }

        public static void blindGoblin()
        {
            Console.WriteLine("Lillian steps out from behind you and lets the sun rays reflect off her fair and tanless skin.");
            Console.WriteLine("Her shoulders, arms, face and legs are in the negative in terms of tanning goes...");
            Console.WriteLine("Her blonde hair reflects the golden aura of the sun even brighter than her skin.");
            Console.ReadLine();

            Console.WriteLine("The goblin lets out a cry of anguish as he shields his eyes with his hands.");
            Console.ReadLine();

            Console.WriteLine("But it's too late. The goblin is temporarily blinded by Lillian's fairness.");
            Console.ReadLine();

            Console.WriteLine("But the effect won't be permanent, so you better act fast!");
            Console.ReadLine();

            Console.WriteLine("You launch into your devastating attack with the only style you know...");
            Console.ReadLine();

            Console.WriteLine("THE KA-RAZY STYLE!");
            Console.ReadLine();

            Console.WriteLine("And you land over a thousand punches and kicks on the goblin!");
            Console.ReadLine();

            Console.WriteLine("This was probably overkill.");
            Console.ReadLine();

            Console.WriteLine("But you didn't hit the goblin nearly hard enough to kill him.");
            Console.ReadLine();

            Console.WriteLine("But the goblin is rendered unconscious from the attack.");
            Console.ReadLine();

            Console.WriteLine("You loot the goblin's pockets for some coin.");
            Console.ReadLine();
            robGoblin();

        }

        public static void robGoblin()
        {
            Random rnd = new Random();
            string[] secOptions = { "You rob the goblin and only get 2 gold. Lame.",
            "You rob the goblin and get 10 gold off him. Hmm. Not bad.",
            "You rob the goblin and get 100 gold. Dang. This goblin must've JUST robbed someone before meeting you."};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;
            Console.WriteLine(secText);
            Console.WriteLine("Are you still in the mood for Skingrad? Yes/y or No/n?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("Alright, let's go to Skingrad.");
                Console.ReadLine();
                skingrad();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("Yeah, Imperial City has WAY more things to do.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                imperialCity3();
            }
            else
            {
                Console.WriteLine("That command makes no sense to the current situation.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                robGoblin();
            }
        }

        public static void skingrad()
        {
            Console.WriteLine("Well, this is Skingrad.");
            Console.ReadLine();

            Console.WriteLine("Worth fighting a goblin for? Meh. Worth fighting anything bigger than a goblin for?");
            Console.ReadLine();

            Console.WriteLine("Definitely not...");
            Console.ReadLine();

            Console.WriteLine("'Well, we have to make the journey here worth it,' says Lillian.");
            Console.WriteLine("'Let's go check out Castle Skingrad,' Lillian offers.");
            Console.WriteLine("'Sure,' you respond.");
            Console.ReadLine();

            Console.WriteLine("Castle Skingrad was kinda meh.");
            Console.WriteLine("'Let's go check out Great Chapel of Julianos...' Lillian offers.");
            Console.ReadLine();

            Console.WriteLine("Great Chapel of Julianos wasn't so great.");
            Console.ReadLine();

            Console.WriteLine("'Let's go check out a Statue of Rislav the Righteous' Lillian offers.");
            Console.WriteLine("'It's just a statue...' you say.");
            Console.ReadLine();

            Console.WriteLine("'Don't be a party pooper. You fought a goblin to get us here,' argues Lillian.");
            Console.ReadLine();

            Console.WriteLine("The Statue of Rislav the Righteous Lillian wanted to check out wasn't much.");
            Console.ReadLine();

            Console.WriteLine("But we got selfies...");
            Console.ReadLine();

            Console.WriteLine("'Alright, let's go home,' Lillian sighs. 'You're right. Skingrad really is kinda...meh.'");
            Console.ReadLine();

            Console.WriteLine("The sun is just peeking over the horizon by the time we get to Imperial City.");
            Console.ReadLine();

            Console.WriteLine("'How about we explore our water activities in Imperial City tomorrow?' Lillian offers.");
            Console.WriteLine("Lillian knows how much Luke loves the water.");
            Console.ReadLine();

            Console.WriteLine("Tomorrow we'll explore one of the many things we can do in the lake around Imperial City.");
            Console.ReadLine();

            Console.WriteLine("You wake up pretty late on your third day of the vacation.");
            Console.WriteLine("Well...10am is pretty late to your wife, Lillian, anyway...");
            Console.ReadLine();

            Console.WriteLine("Lillian beats you relentlessly with a pillow until you peel yourself off the bed.");
            Console.ReadLine();

            Console.WriteLine("After some breakfast and a nice warm shower, it's time to enjoy some coffee at the ");
            Console.WriteLine("King and Queen Tavern. Yes, they serve coffee here too now. Freshly brewed too and recently grounded.");
            Console.WriteLine("It's just about time to get the swimsuits on and hit the water surrounding the city.");
            Console.ReadLine();
            imperialCity3();
        }
        public static void imperialCity3()
        {
            string choice;

            Console.WriteLine("What would you like to do for the rest of your day here at Imperial City?");
            Console.WriteLine("1. Paddle-board along the lake.");
            Console.WriteLine("2. Swim in the lake.");
            Console.WriteLine("3. Have one of the ships pull you along in an inner-tube.");
            Console.Write("Choose your water activity: ");

            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("You and Lillian decide to go out and paddle-board!");
                        Console.ReadLine();
                        shiveringIsles();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You and Lillian decide to go swim in the lake!");
                        Console.ReadLine();
                        shiveringIsles();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Let's see how long you and Lillian can last in an inner-tube.");
                        Console.ReadLine();
                        shiveringIsles();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Oh yeah...we should've thought of that one, but we didn't.");
                        Console.WriteLine("Hint: Use your number pad to select one of the three options.");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        imperialCity3();
                        break;
                    }
            }
        }

        public static void shiveringIsles()
        {
            string secChoice;

            Console.WriteLine("You somehow get swept up onto the shore of a small island.");
            Console.WriteLine("You remember hearing about this island from the locals.");
            Console.WriteLine("There sometimes appears a portal that can transport people to the Shivering Isles.");
            Console.WriteLine("Or at least...the portal used to...");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();

            Console.WriteLine("Oh hey! Speak of the devil! A portal just opened up in front of you and Lillian.");
            Console.WriteLine("Feeling daring on your summer vacation? Care to step through the portal?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            Console.Clear();

            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("Not knowing what you're getting yourself into, you decide to brave the unknown by stepping through.");
                Console.WriteLine("Good thing you have a great wife who supports you and follows behind you...albeit reluctantly here.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                monkeyIsland2();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("With all the stuff you left behind at the inn? Heck no.");
                Console.WriteLine("No telling where this portal goes or even how to get back.");
                Console.WriteLine("It's not a far swim back to Imperial City. Lillian joins you for a nice backstroke to civilization.");
                Console.WriteLine("Perhaps it's best to enjoy the rest of your vacation here.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                imperialCity2();
            }
            else
            {
                Console.WriteLine("That command makes no sense to the current situation.");
                Console.WriteLine("Hint: If you're too lazy to type out yes or no, then the letters they start with will suffice.");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                shiveringIsles();
            }
        }

        public static void imperialCityEnd()
        {
            Console.Clear();
            Console.WriteLine("You and Lillian keep it safe by just staying in Imperial City for the rest of the vacation.");
            Console.WriteLine("So you spend the rest of the vacation touring the city, window shopping at the fresh markets, ");
            Console.WriteLine("tanning along the beaches (public beaches to avoid mud crabs), drinking at the taverns, ");
            Console.WriteLine("enjoying the night time festivals and watching the will-o-wisps in the distance after sundown.");
            Console.WriteLine("This is what summer vacations are for.");
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("Press 'Enter' to play again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
        public static void cyrodiilEnd()
        {
            Console.Clear();
            Console.WriteLine("You spend the rest of the vacation relaxing at Anvil enjoying the sun and ");
            Console.WriteLine("kicking back some cold ale.");
            Console.WriteLine("As the sun sets each night, you and Lillian even go out to watch the will-o-wisps.");
            Console.WriteLine("This is what summer vacations are for.");
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("Press 'Enter' to play again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
    }

}
