using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework4.Flowers
{
    public class Flower : Plant
    {
        public TypeFlowers TypeFlower { get; protected set; }

        public Flower(string name, double height, TypeFlowers typeFlower)
        {
            Name = name;
            Height = height;
            TypeFlower = typeFlower;
        }
    }
}
