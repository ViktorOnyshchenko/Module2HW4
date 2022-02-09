using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework4.Flowers
{
    public class Rose : Flower
    {
        public bool IsThorns { get; protected set; }

        public Rose(string name, double height, TypeFlowers typeFlower, bool isThorns): base(name, height, typeFlower)
        {
            IsThorns = isThorns;
        }
    }
}
