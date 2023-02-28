namespace Model 
{
  public class Caminhao
  {
    public int Id { get; set; }
    public string Placa { get; set; }
    public string Motorista { get; set; }

    public static List<Caminhao> Caminhoes { get; set; } = new List<Caminhao>();

    public Caminhao(int id, string placa, string motorista)
    {
      this.Id = id;
      this.Placa = placa;
      this.Motorista = motorista;

      Caminhoes.Add(this);
    }

    public override string ToString()
    {
      return $"Id: {this.Id} Placa: {this.Placa} Motorista: {this.Motorista}";
    }

    public static void EditarCaminhao(int id, string placa, string motorista)
    {
      Caminhao caminhao = BuscarCaminhao(id);
      caminhao.Placa = placa;
      caminhao.Motorista = motorista;
    }

    public static void ExcluirCaminhao(int id)
    {
      Caminhao caminhao = BuscarCaminhao(id);
      Caminhoes.Remove(caminhao);
    }

    public static Caminhao BuscarCaminhao(int id)
    {
      Caminhao caminhao = Caminhoes.Find(c => c.Id == id);
      if (caminhao == null)
        throw new Exception("Caminhão não encontrado");

      return caminhao;
    }
  }
}