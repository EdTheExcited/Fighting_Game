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
            System.Console.WriteLine("WELCOME TO FIGHTCOCKER 2.0!\n What is the name of your Player?");

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
            System.Console.WriteLine($"Command {player.name} to attack with his {player.weapon.name} \n Press Space to Whack Him!");

            while (player.CheckAlive() && enemy.CheckAlive())
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Spacebar)
                {
                    player.weapon.Attack(enemy);
                    if (enemy.hp > 0)
                    {
                        System.Console.WriteLine($"Ouch, why you hurt him? He only has {enemy.hp} left :(");

                    }
                    else
                    {
                        System.Console.WriteLine("lol that mf dead");
                    }
                    enemy.weapon.Attack(player);
                    System.Console.WriteLine($"{enemy.name}smacked u, {player.hp} hp left!");

                }


            }
            System.Console.WriteLine($"The Battle Is Over,  Came Out Victorious!");
            Console.ReadLine();

        }


    }
}
