using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeFarm
{
    class Hive
    {
        private List<Honeycomb> honeycombs = new();
        public List<Bee> bees = new();
        public List<Egg> eggs = new();

        public int Quantity
        {
            get
            {
                int q = 0;
                foreach(Honeycomb hc in honeycombs)
                {
                    q += hc.Quantity;
                }
                return q;
            }
        }

        public List<string> Composition
        {
            get
            {
                List<string> temp = new();
                foreach (Honeycomb hc in honeycombs)
                {
                    foreach (string f in hc.Composition)
                    {
                        if (!temp.Contains(f))
                        {
                            temp.Append(f);
                        }
                    }
                }
                return temp;
            }
        }

        public List<Honeycomb> Honeycombs
        {
            get
            {
                return honeycombs;
            }
        }

        public void AddHoneycomb()
        {
            honeycombs.Add(new Honeycomb(honeycombs.Count));
        }

        public void RemoveHoneycomb(Honeycomb hc)
        {
            if (honeycombs.Contains(hc))
            {
                honeycombs.Remove(hc);
            }
        }

        public void AddBee(Bee b)
        {
            bees.Add(b);
            b.HomeHive = this;
        }

        public void RemoveBee(Bee b)
        {
            if (bees.Contains(b))
            {
                b.HomeHive = null;
                bees.Remove(b);
            }
        }
    }
}
