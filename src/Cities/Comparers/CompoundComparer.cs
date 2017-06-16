using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class CompoundComparer : IComparer<City>
    {
        public IList<IComparer<City>> Comparers = new List<IComparer<City>>();

        public int Compare(City x, City y)
        {
            
           foreach(IComparer<City> Comparer in Comparers)
            {
                if (Comparer.Compare(x, y) != 0)
                {
                    return Comparer.Compare(x, y);
                }
            }
            return 0;
        }
    }
}
