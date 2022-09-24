using ExampleSerialization.Models;
using Newtonsoft.Json;

Venda vendaUm = new(1, "Caneta", 1.50M);

string itemSerializado = JsonConvert.SerializeObject(vendaUm);