using Desafio02.Entities;
using System.Text.Json;

namespace Desafio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio 02 -Target Sistems\n");

            string jsonFile = @"{
                ""estoque"":
                [
                  {
                    ""codigoProduto"": 101,
                    ""descricaoProduto"": ""Caneta Azul"",
                    ""estoque"": 150
                  },
                  {
                    ""codigoProduto"": 102,
                    ""descricaoProduto"": ""Caderno Universitário"",
                    ""estoque"": 75
                  },
                  {
                    ""codigoProduto"": 103,
                    ""descricaoProduto"": ""Borracha Branca"",
                    ""estoque"": 200
                  },
                  {
                    ""codigoProduto"": 104,
                    ""descricaoProduto"": ""Lápis Preto HB"",
                    ""estoque"": 320
                  },
                  {
                    ""codigoProduto"": 105,
                    ""descricaoProduto"": ""Marcador de Texto Amarelo"",
                    ""estoque"": 90
                  }
                ]
            }";

            Stock myStock = JsonSerializer.Deserialize<Stock>(jsonFile);

            Console.WriteLine("Listando todos os produtos:\n\n");

            foreach (Product p in myStock.Stocks)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("=====================================================");
        }
    }
}
