using Desafio01.Entities;
using System.Text.Json;

namespace Desafio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio 1 Target\n");

            string jsonFile = @"{
            ""vendas"": 
            [
                { ""vendedor"": ""João Silva"", ""valor"": 1200.50 },
                { ""vendedor"": ""João Silva"", ""valor"": 950.75 },
                { ""vendedor"": ""João Silva"", ""valor"": 1800.00 },
                { ""vendedor"": ""João Silva"", ""valor"": 1400.30 },
                { ""vendedor"": ""João Silva"", ""valor"": 1100.90 },
                { ""vendedor"": ""João Silva"", ""valor"": 1550.00 },
                { ""vendedor"": ""João Silva"", ""valor"": 1700.80 },
                { ""vendedor"": ""João Silva"", ""valor"": 250.30 },
                { ""vendedor"": ""João Silva"", ""valor"": 480.75 },
                { ""vendedor"": ""João Silva"", ""valor"": 320.40 },
    
                { ""vendedor"": ""Maria Souza"", ""valor"": 2100.40 },
                { ""vendedor"": ""Maria Souza"", ""valor"": 1350.60 },
                { ""vendedor"": ""Maria Souza"", ""valor"": 950.20 },
                { ""vendedor"": ""Maria Souza"", ""valor"": 1600.75 },
                { ""vendedor"": ""Maria Souza"", ""valor"": 1750.00 },
                { ""vendedor"": ""Maria Souza"", ""valor"": 1450.90 },
                { ""vendedor"": ""Maria Souza"", ""valor"": 400.50 },
                { ""vendedor"": ""Maria Souza"", ""valor"": 180.20 },
                { ""vendedor"": ""Maria Souza"", ""valor"": 90.75 },
    
                { ""vendedor"": ""Carlos Oliveira"", ""valor"": 800.50 },
                { ""vendedor"": ""Carlos Oliveira"", ""valor"": 1200.00 },
                { ""vendedor"": ""Carlos Oliveira"", ""valor"": 1950.30 },
                { ""vendedor"": ""Carlos Oliveira"", ""valor"": 1750.80 },
                { ""vendedor"": ""Carlos Oliveira"", ""valor"": 1300.60 },
                { ""vendedor"": ""Carlos Oliveira"", ""valor"": 300.40 },
                { ""vendedor"": ""Carlos Oliveira"", ""valor"": 500.00 },
                { ""vendedor"": ""Carlos Oliveira"", ""valor"": 125.75 },
    
                { ""vendedor"": ""Ana Lima"", ""valor"": 1000.00 },
                { ""vendedor"": ""Ana Lima"", ""valor"": 1100.50 },
                { ""vendedor"": ""Ana Lima"", ""valor"": 1250.75 },
                { ""vendedor"": ""Ana Lima"", ""valor"": 1400.20 },
                { ""vendedor"": ""Ana Lima"", ""valor"": 1550.90 },
                { ""vendedor"": ""Ana Lima"", ""valor"": 1650.00 },
                { ""vendedor"": ""Ana Lima"", ""valor"": 75.30 },
                { ""vendedor"": ""Ana Lima"", ""valor"": 420.90 },
                { ""vendedor"": ""Ana Lima"", ""valor"": 315.40 }
            ]}";

            Record record = JsonSerializer.Deserialize<Record>(jsonFile);

            string[] sellersName = record.Sellers.
                Select(s => s.Name).
                Distinct().
                ToArray();

            List<Seller> sallesOverOneHundred = record.Sellers.
                Where(s => s.Value > 100.0m).
                Select(s => new Seller(s.Name, s.Value)).
                ToList();

            List<Seller> sellersWithCommission = new List<Seller>();


            for (int i = 0; i < sellersName.Length; i++)
            {
                string sellerName = sellersName[i];

                decimal commission = record.Sellers.
                    Where(s => s.Name == sellerName).
                    Select(s => s.CommissionRate(s.Value)).
                    Sum();
                sellersWithCommission.Add(new Seller(sellerName, commission));
            }

            Console.WriteLine("> Comição dos vendedores\n");

            foreach (Seller s in sellersWithCommission)
            {
                Console.WriteLine(s);
            }
        }
    }
}
