namespace ExampleSerialization.Models
{
  public class Venda
  {
    public int Id { get; set; }
    public string Produto { get; set; }
    public decimal Preco { get; set; }

    public Venda(int Id, string Produto, decimal Preco)
    {
      this.Id = Id;
      this.Produto = Produto;
      this.Preco = Preco;
    }
  }
}