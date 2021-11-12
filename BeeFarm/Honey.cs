using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeFarm
{
    class Honey
    {
        private int quantity = 0;
        public List<string> composition = new();

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value > 0 ? value : 0; }
        }

        public List<string> Composition
        {
            get { return composition; }
        }

        public void AddFlower(Flower flower)
        {
            object[] temp = flower.GetHoney();

            if (!composition.Contains(temp[0]))
            {
                composition.Append(temp[0]);
            }            
            Quantity += (int)temp[1];
        }

        public Honey GetHoney()
        {
            Honey h = new();
            h.MixHoney(this);
            quantity = 0;
            composition = new();
            return h;
        }

        public void MixHoney(Honey h)
        {
            foreach (string fname in h.Composition)
            {
                if (!composition.Contains(fname))
                {
                    composition.Append(fname);
                }
            }
            Quantity += h.Quantity;
        }
    }
}
