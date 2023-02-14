using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy_p.Abstractions.Abstraction;

namespace Strategy_p
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public Context()
        {
            
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public List<Product> Sort(List<Product> products)
        {
            return _strategy.Sort(products).ToList();
        }
    }
}
