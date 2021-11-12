using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeFarm
{
    class Honeycomb
    {
        public int id;
        public Honey honey = new();

        public Honeycomb(int i)
        {
            id = i;
        }

        public int Quantity
        {
            get
            {
                return honey.Quantity;
            }
        }

        public List<string> Composition
        {
            get
            {
                return honey.Composition;
            }
        }

        public void AddHoney(Honey h)
        {
            honey.MixHoney(h);
        }
    }
}
