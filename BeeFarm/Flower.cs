using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeFarm
{
    class Flower
    {
        public readonly string name;
        private int pollen;

        public Flower(string name)
        {
            this.name = name;
            pollen = 100;
        }

        public Flower(string name, int p)
        {
            this.name = name;
            pollen = p >= 0 ? p : 0;
        }

        public int Quantity
        {
            get
            {
                return pollen;
            }
        }

        public object[] GetHoney()
        {
            int temp = pollen;
            pollen = 0;
            return new object[] {name, temp};
        }

        public void AddDay()
        {
            pollen += 25;
        }
    }
}
