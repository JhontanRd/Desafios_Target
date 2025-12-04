using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio02.Entities
{
    public class Stock
    {
        [JsonPropertyName("estoque")]
        public List<Product> Stocks { get; set; } = new List<Product>();
        private List<Log> _operationsLog = new List<Log>();

        public Product TakeProductForCode(int code)
        {
            return Stocks.FirstOrDefault(p => p.Code == code);
        }


    }
}
