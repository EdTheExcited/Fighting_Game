using System;

namespace Fighting_Game
{
    public class Fighter
    {
        public int hp = 1000;
        public string name;

        public Weapon weapon = new Weapon();

        public bool CheckAlive()
        {

            if (hp < 1)
            {
                return false;

            }
            else
            {
                return true;
            }


        }



    }
}