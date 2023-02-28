namespace Model 
{
  public class Cidade 
  {
    public int Id { get; set; }
    public string Nome { get; set; }

    public static List<Cidade> Cidades { get; set; } = new List<Cidade>();

    public Cidade(int id, string nome)
    {
      this.Id = id;
      this.Nome = nome;

      Cidades.Add(this);
    }

    public override string ToString()
    {
      return $"Id: {this.Id} Nome: {this.Nome}";
    }

    public static void EditarCidade(int id, string nome)
    {
      Cidade cidade = BuscarCidade(id);
      cidade.Nome = nome;
    }

    public static void ExcluirCidade(int id)
    {
      Cidade cidade = BuscarCidade(id);
      Cidades.Remove(cidade);
    }

    public static Cidade BuscarCidade(int id)
    {
      Cidade cidade = Cidades.Find(c => c.Id == id);
      if (cidade == null)
        throw new Exception("Cidade não encontrada");

      return cidade;
    }
  }
}