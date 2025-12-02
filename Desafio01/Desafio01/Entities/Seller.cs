using System.Text.Json.Serialization;

namespace Desafio01.Entities
{
    public class Seller
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
    }
}
