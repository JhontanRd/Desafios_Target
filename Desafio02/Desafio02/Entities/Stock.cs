using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02.Entities
{
    public class Stock
    {
        public SortedSet<Product> Stocks { get; set; } = new SortedSet<Product>();
        private List<Log> _operationsLog = new List<Log>();

        public Product TakeProductForCode(int code)
        {
            return Stocks.FirstOrDefault(p => p.Code == code);
        }


    }
}
