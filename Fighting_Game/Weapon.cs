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
            target.Hp -= generator.Next(10, 251);
        }
    }
}