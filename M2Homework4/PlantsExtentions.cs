using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework4
{
    public static class PlantsExtentions
    {
        public static Plant FindByName(this Plant[] plants, string name)
        {
            foreach (var plant in plants)
            {
                if (plant.Name == name)
                {
                    return plant;
                }
            }
            return null;
        }
    }
}
