using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeFarm
{
    class Queen : Bee
    {
        private bool gaveBirth = false;

        public Queen() : base() { }
        public Queen(Hive hv) : base(hv) { }

        public void GiveBirth(int q1 = 2, int q2 = 8)
        {
            if (!gaveBirth)
            {
                for (int i = 0; i < q1; i++)
                {
                    HomeHive.eggs.Add(new Egg(this, typeof(Queen)));
                }

                for(int i = 0; i < q2; i++)
                {
                    HomeHive.eggs.Add(new Egg(this, typeof(Worker)));
                }
                gaveBirth = true;
            }
        }
    }
}
