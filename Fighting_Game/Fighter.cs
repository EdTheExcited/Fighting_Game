using System;

namespace Fighting_Game
{
    public class Fighter
    {
        private int hp = 1000;
        public string name = "";

        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
                if (hp < 0)
                {
                    hp = 0;
                }
            }
        }

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