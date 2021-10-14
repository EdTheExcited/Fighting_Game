using System;

namespace Fighting_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter player = new Fighter();
            Fighter enemy = new Fighter();
            bool ongoing = true;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(@" 
_______ _________ _______          _________ _______ _________ _______          _________   _______     _______ 
(  ____ \\__   __/(  ____ \|\     /|\__   __/(  ____ \\__   __/(  ____ \|\     /|\__   __/  / ___   )   (  __   )
| (    \/   ) (   | (    \/| )   ( |   ) (   | (    \/   ) (   | (    \/| )   ( |   ) (     \/   )  |   | (  )  |
| (__       | |   | |      | (___) |   | |   | (__       | |   | |      | (___) |   | |         /   )   | | /   |
|  __)      | |   | | ____ |  ___  |   | |   |  __)      | |   | | ____ |  ___  |   | |       _/   /    | (/ /) |
| (         | |   | | \_  )| (   ) |   | |   | (         | |   | | \_  )| (   ) |   | |      /   _/     |   / | |
| )      ___) (___| (___) || )   ( |   | |   | )      ___) (___| (___) || )   ( |   | |     (   (__/\ _ |  (__) |
|/       \_______/(_______)|/     \|   )_(   |/       \_______/(_______)|/     \|   )_(     \_______/(_)(_______)
                                                                                                                 ");
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("WELCOME TO FIGHTFIGHT 2.0!\n What is the name of your Player?");

            while (player.name == "")
            {
                player.name = Console.ReadLine();
                player.name = player.name.Trim();
            }
            System.Console.WriteLine($"What weapon does {player.name} carry? \n Stick, Rainbow Dildo, Sledgehammer, Dagger");
            string weaponAnswer = "";
            while (weaponAnswer != "stick" && weaponAnswer != "rainbow dildo" && weaponAnswer != "sledgehammer" && weaponAnswer != "dagger")
            {
                weaponAnswer = Console.ReadLine().ToLower().Trim();


            }

            if (weaponAnswer.ToLower() == "stick")
            {

                player.weapon = new Weapon() { name = "Stick", damage = 40 };
            }
            else if (weaponAnswer.ToLower() == "rainbow dildo")
            {
                player.weapon = new Weapon() { name = "Rainbow Dildo", damage = 55 };

            }
            else if (weaponAnswer.ToLower() == "sledgehammer")
            {
                player.weapon = new Weapon() { name = "Sledgehammer", damage = 90 };

            }
            else if (weaponAnswer.ToLower() == "dagger")
            {
                player.weapon = new Weapon() { name = "Dagger", damage = 60 };

            }
            else
            {
                System.Console.WriteLine("fuck off, pick a weapon");
            }
            System.Console.WriteLine("What Is The Name Of Your Everlasting Enemy?");
            enemy.name = "";
            while (enemy.name == "")
            {
                enemy.name = Console.ReadLine().ToLower().Trim();


            }
            System.Console.WriteLine($"Command {player.name} to attack with his {player.weapon.name} \n Press Space to Whack Him!");

            while (player.CheckAlive() && enemy.CheckAlive())
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Spacebar)
                {
                    player.weapon.Attack(enemy);
                    if (enemy.Hp > 0)
                    {
                        System.Console.WriteLine($"Ouch, why you hurt him? He only has {enemy.Hp} left :(");

                    }
                    else
                    {
                        System.Console.WriteLine("lol that mf dead");
                    }
                    enemy.weapon.Attack(player);
                    System.Console.WriteLine($"{enemy.name} smacked u, {player.Hp} hp left!");

                }


            }

            if (enemy.Hp == 0)
            {
                System.Console.WriteLine($"The Battle Is Over, {player.name} Came Out Victorious!");
            }
            else if (player.Hp == 0)
            {
                System.Console.WriteLine($"It Is Done... {player.name} was killed ruthlessly by {enemy.name}");
            }
            Console.ReadLine();

        }


    }
}
