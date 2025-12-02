using System.Text.Json.Serialization;

namespace Desafio01.Entities
{
    public class Record
    {
        [JsonPropertyName("vendas")]
        public List<Seller> Sellers { get; set; } = new List<Seller>();
    }
}
