using System;

namespace Fighting_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter Player = new Fighter();
            Fighter Enemy = new Fighter();
            bool ongoing = true;
            System.Console.WriteLine("WELCOME TO FIGHTCOCKER 2.0!\n What is the name of your Player?");
            Player.name = Console.ReadLine();
            System.Console.WriteLine($"What weapon does {Player.name} carry? \n Stick, Rainbow Dildo, Sledgehammer, Dagger");
            string weaponanswer = Console.ReadLine();




            if (weaponanswer.ToLower() == "stick")
            {

                Player.weapon = new Weapon() { name = "Stick", damage = 40 };
            }
            else if (weaponanswer.ToLower() == "rainbow dildo")
            {
                Player.weapon = new Weapon() { name = "Rainbow Dildo", damage = 55 };

            }
            else if (weaponanswer.ToLower() == "sledgehammer")
            {
                Player.weapon = new Weapon() { name = "Sledgehammer", damage = 90 };

            }
            else if (weaponanswer.ToLower() == "dagger")
            {
                Player.weapon = new Weapon() { name = "Dagger", damage = 60 };

            }
            else
            {
                System.Console.WriteLine("fuck off, pick a weapon");
            }
            System.Console.WriteLine($"Command {Player.name} to attack with his {Player.weapon.name} \n Press Space to Whack Him!");

            while (Player.CheckAlive() && Enemy.CheckAlive())
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Spacebar)
                {
                    Player.weapon.Attack(Enemy);
                    System.Console.WriteLine($"Ouch, why you hurt him? He only has {Enemy.hp} left :(");

                }


            }
            System.Console.WriteLine($"The Battle Is Over, {Player.name} Came Out Victorious!");
            Console.ReadLine();

        }


    }
}
