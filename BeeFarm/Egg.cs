using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeFarm
{
    class Egg
    {
        private readonly Queen mother;
        private readonly Hive hive;
        private Type bee_type;
        private int Age = 0;

        public Egg(Queen m, Type t)
        {
            mother = m;
            hive = m.HomeHive;
            BeeType = t;
        }

        public Queen Mother
        {
            get{ return mother; }
        }

        public Hive Hive
        {
            get { return hive; }
        }

        public Type BeeType
        {
            get
            {
                return bee_type;
            }
            set
            {
                bee_type = value;
            }
        }

        public void AddDay()
        {
            Age += 1;
            if(Age == 24)
            {
                if(bee_type == typeof(Queen))
                {
                    Hive.bees.Add(new Queen(Hive));   
                }
                else
                {
                    Hive.bees.Add(new Worker(Hive));
                }
                Hive.eggs.Remove(this);
            }
        }

    }
}
