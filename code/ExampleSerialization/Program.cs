using ExampleSerialization.Models;
using Newtonsoft.Json;

Venda vendaUm = new(1, "Caneta", 1.50M);

string dadoSerializado = JsonConvert.SerializeObject(vendaUm, Formatting.Indented);

File.WriteAllText("Files/vendas.json", dadoSerializado);

Console.WriteLine(dadoSerializado);
Console.ReadLine();