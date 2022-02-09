using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework4
{
    public abstract class Plant: IComparable<Plant>
    {
        public string Name { get; protected set; }
        public double Height { get; protected set; }

        public int CompareTo(Plant? plant)
        {
            if(plant != null)
            {
                if(this.Height >= plant.Height)
                {
                    if(this.Height == plant.Height)
                    {
                        return 0;
                    }
                    return 1;
                }
            }
            return -1;
        }
    }
}
