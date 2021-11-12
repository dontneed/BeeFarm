using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeFarm
{
    class Worker : Bee
    {
        private Honey honey = new();

        public Worker() : base() { }
        public Worker(Hive hv) : base(hv) { }

        public int Quantity
        {
            get { return honey.Quantity; }
        }

        public List<string> Composition
        {
            get { return honey.Composition; }
        }

        public void TakePollen(Flower flower)
        {
            honey.AddFlower(flower);
        }
        
        public void GiveHoney(Honeycomb hc)
        {
            if (HomeHive.Honeycombs.Contains(hc))
            {
                hc.AddHoney(honey.GetHoney());
            }
        }
    }
}
