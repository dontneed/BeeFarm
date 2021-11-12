using System;

namespace BeeFarm
{
    class Program
    {
        static void Main(string[] args)
        {

            Hive hive1 = new();
            hive1.AddHoneycomb();
            hive1.AddHoneycomb();

            Queen queen1 = new(hive1);
            Worker w1 = new(hive1);

            Flower flow1 = new("flow1");
            Flower flow2 = new("flow2");

            queen1.GiveBirth();


            Console.WriteLine($"Flower 1 quantity = {flow1.Quantity}");
            w1.TakePollen(flow1);
            Console.WriteLine($"Flower 1 quantity = {flow1.Quantity}");

            Console.WriteLine($"Hive 1 quantity = {hive1.Quantity}");
            w1.GiveHoney(hive1.Honeycombs[0]);
            Console.WriteLine($"Hive 1 quantity = {hive1.Quantity}");

            w1.TakePollen(flow2);
            w1.GiveHoney(hive1.Honeycombs[1]);
            Console.WriteLine($"Hive 1 quantity = {hive1.Quantity}");

            Console.WriteLine(hive1.Honeycombs[0].honey.composition.Count);

            foreach(string f in hive1.Composition)
            {
                Console.WriteLine(f);
            }

        }
    }
}
