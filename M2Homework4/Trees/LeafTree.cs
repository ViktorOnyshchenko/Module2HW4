using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework4.Trees
{
    public class LeafTree : Tree
    {
        public string Placement { get; protected set; }

        public LeafTree(string name, double height, TypeTrees typeTree, string placement) : base(name, height, typeTree)
        {
            Placement = placement;
        }
    }
}
