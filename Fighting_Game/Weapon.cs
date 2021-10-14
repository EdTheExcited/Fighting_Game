using System;

namespace Fighting_Game
{
    public class Weapon
    {
        public string name;
        public int damage;
        Random generator = new Random();
        public void Attack(Fighter target)
        {
            target.hp -= generator.Next(10, 251);
            if (target.hp < 0) { target.hp = 0; }



        }
    }
}