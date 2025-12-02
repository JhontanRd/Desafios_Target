using System.Text.Json.Serialization;

namespace Desafio01.Entities
{
    public class Record
    {
        [JsonPropertyName("vendas")]
        public List<Seller> Sellers = new List<Seller>();
    }
}
