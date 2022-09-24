using ExampleSerialization.Models;
using Newtonsoft.Json;

List<Venda> listaVendas = new();

Venda vendaUm = new(1, "Caneta", 1.50M, DateTime.Now);
Venda vendaDois = new(2, "Office", 100.00M, DateTime.Now);

listaVendas.Add(vendaUm);
listaVendas.Add(vendaDois);

string dadoSerializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Files/vendas.json", dadoSerializado);

Console.WriteLine(dadoSerializado);
Console.ReadLine();