using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio02.Entities
{
    public class Product
    {
        [JsonPropertyName("codigoProduto")]
        public int Code { get; set; }

        [JsonPropertyName("descricaoProduto")]
        public string Description { get; set; }

        [JsonPropertyName("estoque")]
        public int StockBalance { get; set; }

        public Product(int id, string description, int stockBalance)
        {
            Code = id;
            Description = description;
            StockBalance = stockBalance;
        }

        public override string ToString()
        {
            return $"> Codigo do produto: {Code}\n" +
                   $"> Descrição: {Description}" +
                   $"> Saldo em estoque: {StockBalance}";
        }
    }
}
