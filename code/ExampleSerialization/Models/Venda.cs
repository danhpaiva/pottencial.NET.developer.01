using Newtonsoft.Json;

namespace ExampleSerialization.Models
{
  public class Venda
  {
    public int Id { get; set; }
    [JsonProperty("NOME_PRODUTO")]
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }

    public Venda(int Id, string Produto, decimal Preco, DateTime dataVenda)
    {
      this.Id = Id;
      this.Produto = Produto;
      this.Preco = Preco;
      DataVenda = dataVenda;
    }
  }
}