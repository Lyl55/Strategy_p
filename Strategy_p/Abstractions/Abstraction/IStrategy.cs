using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_p.Abstractions.Abstraction
{
    public interface IStrategy
    {
        public IList<Product> Sort(List<Product> products);
    }
}
