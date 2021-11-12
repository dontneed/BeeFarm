using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeFarm
{
    abstract class Bee
    {
        public int Age { get; set; }
        public Hive HomeHive { get; set; }

        public Bee()
        {
            Age = 0;
        }

        public Bee(Hive hv)
        {
            HomeHive = hv;
            Age = 0;
        }

        public void FlyTo(Hive hv)
        {
            hv.bees.Add(this);
            HomeHive = hv;
        }
    }
}
