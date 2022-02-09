using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Homework4
{
    public interface IArea
    {
        public Plant GetPlantWithMaxHeight();

        public void SortByName();

        public IEnumerable<string> GetCountByKind();
    }
}
