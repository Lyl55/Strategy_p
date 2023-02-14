using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_p.Abstractions.Abstraction;

namespace Strategy_p.Abstractions.Implementation
{
    public class SortByNameAscStrategy :IStrategy
    {
        public IList<Product> Sort(List<Product> products)
        {
            return products.OrderBy(x => x.ProductTitle).ToList();
        }
    }
}
