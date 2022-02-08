using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework4.Trees
{
    public class Tree : Plant
    {
        public TypeTrees TypeTree { get; protected set; }

        public Tree(string name, double height, TypeTrees typeTree)
        {
            Name = name;
            Height = height;
            TypeTree = typeTree;
        }
    }
}
