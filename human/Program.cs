using System;
using System.Collections.Generic;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();

            Ninja Naruto = new Ninja("Naruto");
            Wizard HarryPotter = new Wizard("Harry Potter");
            Samurai Jack = new Samurai("Jack");

        }








        public static void gameTitle()
        {

            Console.WriteLine(@" _    _ _____ _     _____ ________  ___ _____   _____ _____  __   _______ _   _______  ______ _____  ________  ___  _   _");
            Console.WriteLine(@"| |  | |  ___| |   /  __ \  _  |  \/  ||  ___| |_   _|  _  | \ \ / /  _  | | | | ___ \ |  _  \  _  ||  _  |  \/  | | | | |");
            Console.WriteLine(@"| |  | | |__ | |   | /  \/ | | | .  . || |__     | | | | | |  \ V /| | | | | | | |_/ / | | | | | | || | | | .  . | | | | |");
            Console.WriteLine(@"| |/\| |  __|| |   | |   | | | | |\/| ||  __|    | | | | | |   \ / | | | | | | |    /  | | | | | | || | | | |\/| | | | | |");
            Console.WriteLine(@"\  /\  / |___| |___| \__/\ \_/ / |  | || |___    | | \ \_/ /   | | \ \_/ / |_| | |\ \  | |/ /\ \_/ /\ \_/ / |  | | |_| |_|");
            Console.WriteLine(@" \/  \/\____/\_____/\____/\___/\_|  |_/\____/    \_/  \___/    \_/  \___/ \___/\_| \_| |___/  \___/  \___/\_|  |_/ (_) (_)   ");
            Console.WriteLine(@"            ,_,_,_,_,_,_,_,_,_,_|______________________________________________________");
            Console.WriteLine(@"            |#|#|#|#|#|#|#|#|#|#|_____________________________________________________/");
            Console.WriteLine(@"            '-'-'-'-'-'-'-'-'-'-|----------------------------------------------------'");
            Console.WriteLine("Press Enter to start your decent into your doom!");
            Console.ReadLine();
            Console.Clear();

            PlayerSelect();
        }

        public static void PlayerSelect()
        {
            string PlayerChoice;

            Console.WriteLine("Please Select you Character");
            Console.WriteLine("1. Ninja");
            Console.WriteLine("2. Wizard");
            Console.WriteLine("3. Samurai");

            Console.WriteLine("Choice:");
            PlayerChoice = Console.ReadLine().ToLower();

            switch (PlayerChoice)
            {
                case "1":
                case "ninja":
                    {
                        Console.WriteLine("You have chosen a ninja. They are agile and quick but have lower health");
                        Ninja Naruto = new Ninja("Naruto");
                        first(Naruto);
                        break;
                    }

                case "2":
                case "wizard":
                    {
                        System.Console.WriteLine("You have chosen a Wizard.as You have vast wisdom");
                        Wizard HarryPotter = new Wizard("Harry Potter");
                        first(HarryPotter);
                        break;
                    }

                case "3":
                case "samurai":
                    {
                        Samurai Jack = new Samurai("Jack");
                        System.Console.WriteLine("You have chosen the mighty samurai. ");
                        first(Jack);
                        break;
                    }


            }
        }

        public static void first(Human Player)
        {

            string choice;
            Console.WriteLine(Player.Name);
            Console.WriteLine("You start your adventure.");
            Console.WriteLine("You come across an ominous dark forest with a big sign that says \"Turn around or risk losing your life\" ");
            Console.WriteLine("What would youlike to do?");
            Console.WriteLine("1. Enter the forest.");
            Console.WriteLine("2. Turn around and forever have the fear of missing out.");
            Console.WriteLine("3. Take the dirt road");
            Console.Write("Choice:");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "enter":
                case "forest":
                    {
                        Console.WriteLine(@"           ,@@@@@@@,");
                        Console.WriteLine(@"   ,,,.   ,@@@@@@/@@,  .oo8888o.");
                        Console.WriteLine(@",&%%&%&&%,@@@@@/@@@@@@,8888\88/8o");
                        Console.WriteLine(@",%&\%&&%&&%,@@@\@@@/@@@88\88888/88'");
                        Console.WriteLine(@"%&&%&%&/%&&%@@\@@/ /@@@88888\88888'");
                        Console.WriteLine(@"%&&%/ %&%%&&@@\ V /@@' `88\8 `/88'");
                        Console.WriteLine(@"`&%\ ` /%&'    |.|        \ '|8'");
                        Console.WriteLine(@"    |o|        | |         | |");
                        Console.WriteLine(@"    |.|        | |         | |");
                        Console.WriteLine(@" \\/ ._\//_/__/  ,\_//__\\/.  \_//__/_");
                        string option;

                        Console.WriteLine("You come across a strange object hanging from a tree branch.");
                        Console.WriteLine("It appears to be wrapped in a silky substance.");
                        Console.WriteLine("What do you do?");
                        Console.WriteLine("1. Poke it with a stick.");
                        Console.WriteLine("2. Keep walking");
                        option = Console.ReadLine().ToLower();
                        switch (option)
                        {
                            case "1":
                            case "poke it with a stick":
                            case "poke":
                                {
                                    Console.WriteLine("You've disturbed a nest of spiders!");
                                    spiderEncounter(Player);
                                    break;
                                }
                            case "2":
                            case "keep walking":
                            case "walk":
                                {
                                    Console.WriteLine("You are ambushed by a horde of zombies!");
                                    zombieEncounter(Player);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("No one knows what you're talking about. Try again!");
                                    break;
                                }
                        }
                    }
                    break;
                case "2":
                case "turn around":
                case "turn around and forever have the fear of missing out.":
                    {
                        Console.WriteLine("You go home and spend the rest of your life wondering what could have been. Are you doomed to live in mediocrity? Would you have been a legend?");
                        Console.WriteLine("Game Over.");
                        gameOver();
                        break;
                    }

                case "3":
                case "dirt road":
                case "take the dirt road":
                    {
                        Console.WriteLine("You are ambushed by a gaggle of goblins trying to steal your money!");
                        goblinEncounter(Player);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("No one knows what you're talking about. Try again!");
                        break;
                    }
            }

        }
        public static void spiderEncounter(Human Player)
        {
            Console.WriteLine(@" /\ \  / /\");
            Console.WriteLine(@"//\\ .. //\\");
            Console.WriteLine(@"//\((  ))/\\");
            Console.WriteLine(@"/  < `' >  \");
            Console.WriteLine("Three spiders decend from a giant tree and surround your party.");

            Spider blackWidow = new Spider("Charlotte");
            Spider brownRecluse = new Spider("Aragog");
            Spider tarantula = new Spider("Shelob");

            spiderFight(Player, blackWidow, brownRecluse, tarantula);



        }
        public static void zombieEncounter(Human Player)
        {
            Console.WriteLine(@"  __________");
            Console.WriteLine(@" /          \");
            Console.WriteLine(@"/            \");
            Console.WriteLine(@"|  ===  ===  |");
            Console.WriteLine(@" \    \ /   / ");
            Console.WriteLine(@"  \ VVvvVv /");
            Console.WriteLine(@"   ||    ||");
            Console.WriteLine(@"   ||    ||");
            Console.WriteLine(@"   \ \^^^//");
            Console.WriteLine(@"    -------");
            Console.WriteLine("As you walk through the forest you see three zombies slowly approach your party.");

            Zombie walker = new Zombie("Billy");
            Zombie limper = new Zombie("Jebidaya");
            Zombie crawler = new Zombie("Sir Drags-a-lot");

            zombieFight(Player, walker, limper, crawler);

        }

        public static void goblinEncounter(Human Player)
        {

            Console.WriteLine(@"      _______    ");
            Console.WriteLine(@"|\   /       \   /|");
            Console.WriteLine(@"| \ /  =.  .= \ / |");
            Console.WriteLine(@" \( \   o\/o  / )/");
            Console.WriteLine(@"  \_, '-/  \-' ,_/");
            Console.WriteLine(@"    /   \__/   \");
            Console.WriteLine(@"    \ \__/\__/ /");
            Console.WriteLine(@"  ___\ \|--|/ /___");
            Console.WriteLine(@"/`    \      /    `\");

            Goblin goblinBoy = new Goblin("Goblin Boy");
            Goblin goblinWarrior = new Goblin("Goblin Warrior");
            Goblin goblinThug = new Goblin("Goblin Thug");




            string robbed;
            Console.WriteLine("The goblins demand all your coin! What do you do?");
            Console.WriteLine("1. Give them my money.");
            Console.WriteLine("2. Do not give them my money.");
            Console.WriteLine("3. Toss a coin to my witcher.");
            robbed = Console.ReadLine().ToLower();

            switch (robbed)
            {
                case "1":
                case "give":
                case "give money":
                    {
                        Console.WriteLine("You give them all your money. The party goes home feeling defeated and poor.");
                        Console.WriteLine("Game Over.");
                        gameOver();
                    }
                    break;

                case "2":
                case "do not":
                case "do not give money":
                    {
                        Console.WriteLine("The goblins get angry with your blatant refusal to give them money. Prepare to fight!");
                        goblinFight(Player, goblinBoy, goblinWarrior, goblinThug);
                    }
                    break;

                case "3":
                case "toss a coin":
                case "toss a coin to my witcher":
                    {
                        Console.WriteLine("You don't know where he came from, but a mysterious character appeared and killed all the golblins for you. You learn that giving your money to witchers instead of goblins solves problems. But you are now penniless and must return home for money.");
                        Console.WriteLine("Game Over.");
                        gameOver();
                    }
                    break;

            }

        }
        public static void gameOver()
        {
            string game;
            Console.WriteLine("Would you like to try again?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            game = Console.ReadLine().ToLower();

            switch (game)
            {
                case "1":
                case "yes":
                    {
                        gameTitle();
                    }
                    break;

                case "2":
                case "no":
                    {
                        break;
                    }
            }
        }
        public static void zombieAttack(Human target, Zombie zombie, Zombie zombie1, Zombie zombie2)
        {
            // if(zombie.health <= 0 && zombie1.health <= 0 && zombie2.health <= 0) endGame();

            zombie.Attack(target);
            while (zombie.health > 0 || target.health > 0)
            {
                System.Console.WriteLine($"Player health: {target.health}");
                System.Console.WriteLine($"Zombie health: {zombie.health}");

                if (target.health <= 0)
                {
                    gameOver();
                    break;
                }

                if (zombie.health <= 0)
                {
                    System.Console.WriteLine($"Huzzah! You have defeated {zombie.Name}, they didn't stand a chance!");
                    // if (zombie.health <= 0 && zombie1.health <= 0 && zombie2.health <= 0) endGame();
                    if (zombie.health <= 0 && zombie1.health <= 0 && zombie2.health <= 0) nextAdventure(target);

                    else
                    {
                        zombieFight(target, zombie, zombie1, zombie2);
                    }
                    break;
                }

                target.Attack(zombie);
                zombie.Attack(target);
            }
        }

        public static void spiderAttack(Human target, Spider spider, Spider spider1, Spider spider2)
        {
            spider.Attack(target);
            while (spider.health > 0 || target.health > 0)
            {
                System.Console.WriteLine($"Player health: {target.health}");
                System.Console.WriteLine($"Spider health: {spider.health}");

                if (target.health <= 0)
                {
                    gameOver();
                    break;
                }

                if (spider.health <= 0)
                {
                    System.Console.WriteLine($"You have defeated {spider.Name}! They didn't even have a leg to stand on...");
                    if (spider.health <= 0 && spider1.health <= 0 && spider2.health <= 0) nextAdventure();

                    else
                    {
                        spiderFight(target, spider, spider1, spider2);
                    }
                    break;
                }

                target.Attack(spider);
                spider.Attack(target);
            }
        }

        public static void goblinAttack(Human target, Goblin goblin, Goblin goblin1, Goblin goblin2)
        {
            goblin.Attack(target);
            while (goblin.health > 0 || target.health > 0)
            {
                System.Console.WriteLine($"Player health: {target.health}");
                System.Console.WriteLine($"Goblin health: {goblin.health}");

                if (target.health <= 0)
                {
                    gameOver();
                    break;
                }

                if (goblin.health <= 0)
                {
                    System.Console.WriteLine($"Huzzah! You have defeated {goblin.Name}, they didn't stand a chance!");
                    if (goblin.health <= 0 && goblin1.health <= 0 && goblin2.health <= 0) nextAdventure();

                    else
                    {
                        goblinFight(target, goblin, goblin1, goblin2);
                    }
                    break;
                }

                target.Attack(goblin);
                goblin.Attack(target);
            }
        }
        public static void spiderFight(Human Player, Spider blackWidow, Spider brownRecluse, Spider tarantula)
        {
            string option;
            Console.WriteLine("You engage the spiders in glorious combat!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Special Attack");
            Console.WriteLine("3. Run Away");
            option = Console.ReadLine().ToLower();
            Console.Write("Choice: ");

            switch (option)
            {
                case "1":
                case "attack":
                    {
                        string enemy;
                        Console.WriteLine("Which enemy would you like to attack?");
                        if (blackWidow.health > 0) Console.WriteLine($"1.{blackWidow.Name} Health: {blackWidow.health}");
                        if (brownRecluse.health > 0) Console.WriteLine($"2.{brownRecluse.Name} Health: {brownRecluse.health}");
                        if (tarantula.health > 0) Console.WriteLine($"3.{tarantula.Name} Health: {tarantula.health}");
                        enemy = Console.ReadLine().ToLower();
                        Console.Write("Choice: ");
                        switch (enemy)
                        {
                            case "1":
                            case "${blackWidow.Name}":
                                {
                                    Player.Attack(blackWidow);
                                    spiderAttack(Player, blackWidow, brownRecluse, tarantula);
                                }
                                break;

                            case "2":
                            case "${brownRecluse.Name}":
                                {
                                    Player.Attack(brownRecluse);
                                    spiderAttack(Player, brownRecluse, blackWidow, tarantula);
                                }
                                break;

                            case "3":
                            case "${tarantula.Name}":
                                {
                                    Player.Attack(tarantula);
                                    spiderAttack(Player, tarantula, blackWidow, brownRecluse);
                                }
                                break;
                        }
                        break;
                    }

                case "2":
                case "special attack":
                case "special":
                    {
                        string enemy;
                        Console.WriteLine("Which enemy would you like to attack?");
                        if (blackWidow.health > 0) Console.WriteLine($"1.{blackWidow.Name}");
                        if (brownRecluse.health > 0) Console.WriteLine($"2.{brownRecluse.Name}");
                        if (tarantula.health > 0) Console.WriteLine($"3.{tarantula.Name}");
                        enemy = Console.ReadLine().ToLower();
                        Console.Write("Choice: ");
                        switch (enemy)
                        {
                            case "1":
                            case "${blackWidow.Name}":
                                {
                                    if (Player.Name == "Naruto")
                                    {
                                        Player.Steal(blackWidow);
                                        spiderAttack(Player, blackWidow, brownRecluse, tarantula);
                                    }
                                    if (Player.Name == "Jack")
                                    {
                                        Player.Meditate();
                                        spiderAttack(Player, blackWidow, brownRecluse, tarantula);
                                    }
                                    else
                                    {
                                        Player.Fireball(blackWidow);
                                        spiderAttack(Player, blackWidow, brownRecluse, tarantula);
                                    }

                                }
                                break;

                            case "2":
                            case "${brownRecluse.Name}":
                                {
                                    if (Player.Name == "Naruto")
                                    {
                                        Player.Steal(brownRecluse);
                                        spiderAttack(Player, brownRecluse, blackWidow, tarantula);
                                    }
                                    if (Player.Name == "Jack")
                                    {
                                        Player.Meditate();
                                        spiderAttack(Player, brownRecluse, blackWidow, tarantula);
                                    }
                                    else
                                    {
                                        Player.Fireball(brownRecluse);
                                        spiderAttack(Player, brownRecluse, blackWidow, tarantula);

                                    }
                                }
                                break;

                            case "3":
                            case "${tarantula.Name}":
                                {
                                    if (Player.Name == "Naruto")
                                    {
                                        Player.Steal(tarantula);
                                        spiderAttack(Player, tarantula, blackWidow, brownRecluse);
                                    }
                                    if (Player.Name == "Jack")
                                    {
                                        Player.Meditate();
                                        spiderAttack(Player, tarantula, blackWidow, brownRecluse);
                                    }
                                    else
                                    {
                                        Player.Fireball(tarantula);
                                        spiderAttack(Player, tarantula, blackWidow, brownRecluse);
                                    }
                                }
                                break;
                        }
                        break;
                    }

                case "3":
                case "Run Away":
                    {
                        Console.WriteLine("You run away like a coward. You go home feeling unaccomplished. And you should.");
                        Console.WriteLine("Game Over");
                        gameOver();
                    }
                    break;
            }
        }

        public static void zombieFight(Human Player, Zombie walker, Zombie limper, Zombie crawler)
        {
            // System.Console.WriteLine(Player.Name);
            // if(walker.health <= 0 && limper.health <= 0 && crawler.health <= 0)endGame();
            // {
            //     endGame();
            // }

            string option;
            Console.WriteLine("You prepare to engange a fight with the zombies");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Special Attack");
            Console.WriteLine("3. Run Away");
            option = Console.ReadLine().ToLower();
            Console.Write("Choice: ");


            switch (option)
            {
                case "1":
                case "attack":
                    {
                        string enemy;
                        Console.WriteLine("Which enemy would you like to attack?");
                        if (walker.health > 0) Console.WriteLine($"1.{walker.Name} Health: {walker.health}");
                        if (limper.health > 0) Console.WriteLine($"2.{limper.Name} Health: {limper.health}");
                        if (crawler.health > 0) Console.WriteLine($"3.{crawler.Name} Health: {crawler.health}");
                        enemy = Console.ReadLine().ToLower();
                        Console.Write("Choice: ");
                        switch (enemy)
                        {
                            case "1":
                            case "${walker.Name}":
                                {
                                    Player.Attack(walker);
                                    zombieAttack(Player, walker, limper, crawler);
                                }
                                break;

                            case "2":
                            case "${limper.Name}":
                                {
                                    Player.Attack(limper);
                                    zombieAttack(Player, limper, walker, crawler);
                                }
                                break;

                            case "3":
                            case "${crawler.Name}":
                                {
                                    Player.Attack(crawler);
                                    zombieAttack(Player, crawler, walker, limper);
                                }
                                break;
                        }
                        break;
                    }

                case "2":
                case "special attack":
                case "special":
                    {
                        string enemy;
                        Console.WriteLine("Which enemy would you like to attack?");
                        if (walker.health > 0) Console.WriteLine($"1.{walker.Name}");
                        if (limper.health > 0) Console.WriteLine($"2.{limper.Name}");
                        if (crawler.health > 0) Console.WriteLine($"3.{crawler.Name}");
                        enemy = Console.ReadLine().ToLower();
                        Console.Write("Choice: ");
                        switch (enemy)
                        {
                            case "1":
                            case "${walker.Name}":
                                {
                                    if (Player.Name == "Naruto")
                                    {
                                        Player.Steal(walker);
                                        zombieAttack(Player, walker, limper, crawler);
                                    }
                                    if (Player.Name == "Jack")
                                    {
                                        Player.Meditate();
                                        zombieAttack(Player, walker, limper, crawler);
                                    }
                                    else
                                    {
                                        Player.Fireball(walker);
                                        zombieAttack(Player, walker, limper, crawler);
                                    }

                                }
                                break;

                            case "2":
                            case "${limper.Name}":
                                {
                                    if (Player.Name == "Naruto")
                                    {
                                        Player.Steal(limper);
                                        zombieAttack(Player, limper, walker, crawler);
                                    }
                                    if (Player.Name == "Jack")
                                    {
                                        Player.Meditate();
                                        zombieAttack(Player, limper, walker, crawler);
                                    }
                                    else
                                    {
                                        Player.Fireball(limper);
                                        zombieAttack(Player, limper, walker, crawler);

                                    }
                                }
                                break;

                            case "3":
                            case "${crawler.Name}":
                                {
                                    if (Player.Name == "Naruto")
                                    {
                                        Player.Steal(crawler);
                                        zombieAttack(Player, crawler, walker, limper);
                                    }
                                    if (Player.Name == "Jack")
                                    {
                                        Player.Meditate();
                                        zombieAttack(Player, crawler, walker, limper);
                                    }
                                    else
                                    {
                                        Player.Fireball(crawler);
                                        zombieAttack(Player, crawler, walker, limper);
                                    }
                                }
                                break;
                        }
                        break;
                    }

                case "3":
                case "Run Away":
                    {
                        Console.WriteLine("You run away like a coward. You go home feeling unaccomplished. And you should.");
                        Console.WriteLine("Game Over");
                        gameOver();
                    }
                    break;
            }
        }

        public static void goblinFight(Human Player, Goblin goblinBoy, Goblin goblinWarrior, Goblin goblinThug)
        {

            string option;
            Console.WriteLine("You prepare to engange a fight with the Goblins");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Special Attack");
            Console.WriteLine("3. Run Away");
            option = Console.ReadLine().ToLower();
            Console.Write("Choice: ");


            switch (option)
            {
                case "1":
                case "attack":
                    {
                        string enemy;
                        Console.WriteLine("Which enemy would you like to attack?");
                        if (goblinBoy.health > 0) Console.WriteLine($"1.{goblinBoy.Name} Health: {goblinBoy.health}");
                        if (goblinBoy.health > 0) Console.WriteLine($"2.{goblinWarrior.Name} Health: {goblinWarrior.health}");
                        if (goblinThug.health > 0) Console.WriteLine($"3.{goblinThug.Name} Health: {goblinThug.health}");
                        enemy = Console.ReadLine().ToLower();
                        Console.Write("Choice: ");
                        switch (enemy)
                        {
                            case "1":
                            case "${goblinBoy.Name}":
                                {
                                    Player.Attack(goblinBoy);
                                    goblinAttack(Player, goblinBoy, goblinWarrior, goblinThug);
                                }
                                break;


                            case "2":
                            case "${goblinWarrior.Name}":
                                {
                                    Player.Attack(goblinWarrior);
                                    goblinAttack(Player, goblinWarrior, goblinBoy, goblinThug);
                                }
                                break;

                            case "3":
                            case "${goblinThug.Name}":
                                {
                                    Player.Attack(goblinThug);
                                    goblinAttack(Player, goblinThug, goblinBoy, goblinWarrior);
                                }
                                break;
                        }
                        break;
                    }

                case "2":
                case "special attack":
                case "special":
                    {
                        string enemy;
                        Console.WriteLine("Which enemy would you like to attack?");
                        if (goblinBoy.health > 0) Console.WriteLine($"1.{goblinBoy.Name}");
                        if (goblinWarrior.health > 0) Console.WriteLine($"2.{goblinWarrior.Name}");
                        if (goblinThug.health > 0) Console.WriteLine($"3.{goblinThug.Name}");
                        enemy = Console.ReadLine().ToLower();
                        Console.Write("Choice: ");
                        switch (enemy)
                        {
                            case "1":
                            case "${goblinBoy.Name}":
                                {
                                    if (Player.Name == "Naruto")
                                    {
                                        Player.Steal(goblinBoy);
                                        goblinAttack(Player, goblinBoy, goblinWarrior, goblinThug);
                                    }
                                    if (Player.Name == "Jack")
                                    {
                                        Player.Meditate();
                                        goblinAttack(Player, goblinBoy, goblinWarrior, goblinThug);
                                    }
                                    else
                                    {
                                        Player.Fireball(goblinBoy);
                                        goblinAttack(Player, goblinBoy, goblinWarrior, goblinThug);
                                    }

                                }
                                break;

                            case "2":
                            case "${goblinWarrior.Name}":
                                {
                                    if (Player.Name == "Naruto")
                                    {
                                        Player.Steal(goblinWarrior);
                                        goblinAttack(Player, goblinWarrior, goblinBoy, goblinThug);
                                    }
                                    if (Player.Name == "Jack")
                                    {
                                        Player.Meditate();
                                        goblinAttack(Player, goblinWarrior, goblinBoy, goblinThug);
                                    }
                                    else
                                    {
                                        Player.Fireball(goblinWarrior);
                                        goblinAttack(Player, goblinWarrior, goblinBoy, goblinThug);

                                    }
                                }
                                break;

                            case "3":
                            case "${goblinThug.Name}":
                                {
                                    if (Player.Name == "Naruto")
                                    {
                                        Player.Steal(goblinThug);
                                        goblinAttack(Player, goblinThug, goblinBoy, goblinWarrior);
                                    }
                                    if (Player.Name == "Jack")
                                    {
                                        Player.Meditate();
                                        goblinAttack(Player, goblinThug, goblinBoy, goblinWarrior);
                                    }
                                    else
                                    {
                                        Player.Fireball(goblinThug);
                                        goblinAttack(Player, goblinThug, goblinBoy, goblinWarrior);
                                    }
                                }
                                break;
                        }
                        break;
                    }

                case "3":
                case "Run Away":
                    {
                        Console.WriteLine("You run away like a coward. You go home feeling unaccomplished. And you should.");
                        Console.WriteLine("Game Over");
                        gameOver();
                    }
                    break;
            }
        }

        public static void nextAdventure(Human Player)
        {
            Console.WriteLine("As you defeat your enemies, you start to walk away. Like a bad ass action movie star from the 90s( Arnorld? )");
            Console.WriteLine("You take a moment to reflect on your adventure thus far, but suddenly you hear a rustling in the bushes.");
            
            
            string option;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Check the bushes!");
            Console.WriteLine("2. Just walk away.");
            option = Console.ReadLine().ToLower();
            Console.Write("Choice: ");

            switch(option)
            {
                case "1":
                case "check":
                case "bushes":
                {
                    Console.Clear();
                    Console.WriteLine("You look into the bushes and see something unbelievable! It's...");
                    Console.WriteLine("What is it exactly?");
                    Console.WriteLine("Find out what it is you found by visiting https://www.twitch.tv/sir_saltimus/about");
                    Console.WriteLine("Make sure to give it a follow and subscribe if you want... I guess...");

                    endGame();
                }
                break;  

                case "2":
                case "walk":
                {
                    Console.Clear();
                    Console.WriteLine("You ignore the rustling for now, it doesn't sound like it will kill you anyway...");
                    Console.WriteLine("And you will never know what it is you missed out on. Good job.. you made the right choice, trust me... I swear you did.");

                    endGame();
                }
                break;
            }
        }

        public static void endGame()
        {
            
            Console.WriteLine("You have had quite an adventure today. Perhaps it is time to rest until next time.");
            Console.WriteLine("Game by NOM/WOMbo Studios");

        }
    }
}






