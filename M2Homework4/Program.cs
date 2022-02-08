using System;
using M2Homework4.Flowers;
using M2Homework4.Trees;

namespace M2Homework4
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Area area = new Area();
            area.AddPlant(new Flower("Орхидея", 0.13, TypeFlowers.Domestic));
            area.AddPlant(new Tree("Яблуня", 7, TypeTrees.Garden));
            area.AddPlant(new LeafTree("Береза", 1, TypeTrees.Room, "Теплый климат"));
            area.AddPlant(new Rose("Damask rose", 0.20, TypeFlowers.Wild, true));

            foreach (var entry in area.Plants)
            {
                Console.WriteLine($"{entry.Name} {entry.Height}");
            }

            Plant plant = area.Plants.FindByName("Яблуня");
            Console.WriteLine($"\nНайденное растение:  {plant.Name} {plant.Height}\n");

            area.SortByName();
            foreach (var entry in area.Plants)
            {
                Console.WriteLine($"{entry.Name} {entry.Height}");
            }

            Console.WriteLine();
            
            foreach(var gr in area.GetCountByKind())
            {
                Console.WriteLine(gr);

            }

            Console.ReadKey();
        }
    }
}
