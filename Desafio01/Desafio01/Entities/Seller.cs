using Desafio01.Services;
using System.Globalization;
using System.Text.Json.Serialization;

namespace Desafio01.Entities
{
    public class Seller : CommissionService
    {
        [JsonPropertyName("vendedor")]
        public string Name { get; set; }

        [JsonPropertyName("valor")]
        public decimal Value { get; set; }

        public Seller(string name, decimal value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return $"> Vendedor: {Name}\n" +
                   $"> Valor da comição: {Value.ToString("C2", new CultureInfo("pt-BR"))}\n";
        }

        public decimal CommissionRate(decimal amount)
        {
            /*
             * Regra:
                Vendas abaixo de R$100,00 não gera comissão
                Vendas abaixo de R$500,00 gera 1% de comissão
                A partir de R$500,00 gera 5% de comissão
             */

            if (amount < 500.0m)
            {
                return amount * 0.01m;
            }
            else
            {
                return amount * 0.05m;
            }
        }
    }
}
