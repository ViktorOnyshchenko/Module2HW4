using M2Homework4.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework4
{
    public class Area : IArea
    {
        public Plant[] Plants { get; set; }

        public Area()
        {
            Plants = new Plant[0];
        }

        public void AddPlant(Plant plant)
        {
            Plant[] plants = new Plant[Plants.Length + 1];
            for (int i = 0; i < Plants.Length; i++)
            {
                plants[i] = Plants[i];
            }
            plants[Plants.Length] = plant;
            Plants = plants;
        }

        public Plant GetPlantWithMaxHeight()
        {
            if (Plants.Any())
            {
                Plant plant = Plants[0];
                double maxHeight = Plants[0].Height;
                for (int i = 1; i < Plants.Length; i++)
                {
                    if(Plants[i].Height > maxHeight)
                    {
                        maxHeight = Plants[i].Height;
                        plant = Plants[i];
                    }
                }
                return plant;
            }
            return null;
        }

        public void SortByName()
        {
            Array.Sort(Plants);
        }

        public IEnumerable<string> GetCountByKind()
        {
            return Plants.GroupBy(gr => gr.GetType().Name, (gr, v) => new
            {
                Key = gr,
                Value = v
            }).Select(gr => String.Format("{0}: {1}", gr.Key, gr.Value.Count()));
                
        }
    }
}
