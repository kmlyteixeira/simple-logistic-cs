namespace Model 
{
  public class Rota 
  {
    public int Id { get; set; }
    public Caminhao Caminhao { get; set; }
    public int idCaminhao { get; set; } 
    public Cidade Partida { get; set; }
    public int idPartida { get; set; }
    public Cidade Chegada { get; set; }
    public int idChegada { get; set; }
    public string Data { get; set; }
    public double ValorRota { get; set; }
    public static List<Rota> Rotas { get; set; } = new List<Rota>();

    public Rota(int id, Caminhao caminhao, Cidade partida, Cidade chegada, string data, double valorRota)
    {
      this.Id = id;
      this.Caminhao = caminhao;
      this.Partida = partida;
      this.Chegada = chegada;
      this.Data = data;
      this.ValorRota = valorRota;

      Rotas.Add(this);
    }

    public override string ToString()
    {
      return $"Id: {this.Id} Caminhão: {this.Caminhao} Partida: {this.Partida} Chegada: {this.Chegada} Data: {this.Data} Valor Rota: {this.ValorRota}";
    }

    public static void EditarRota(int id, Caminhao caminhao, Cidade partida, Cidade chegada, string data, double valorRota)
    {
      Rota rota = BuscarRota(id);
      rota.Caminhao = caminhao;
      rota.Partida = partida;
      rota.Chegada = chegada;
      rota.Data = data;
      rota.ValorRota = valorRota;
    }

    public static void ExcluirRota(int id)
    {
      Rota rota = BuscarRota(id);
      Rotas.Remove(rota);
    }

    public static Rota BuscarRota(int id)
    {
      Rota rota = Rotas.Find(r => r.Id == id);
      if (rota == null)
        throw new Exception("Rota não encontrada");

      return rota;
    }

    public static List<string> ListarRotas()
    {
      List<string> stringRotas = new List<string>();
      IEnumerable<Model.Rota> rotas = from rota in Model.Rota.Rotas
      join caminhao in Model.Caminhao.Caminhoes on rota.idCaminhao equals caminhao.Id
      join partida in Model.Cidade.Cidades on rota.idPartida equals partida.Id
      join chegada in Model.Cidade.Cidades on rota.idChegada equals chegada.Id
      select rota; 

      foreach (Model.Rota rota in rotas)
      {
        stringRotas.Add($"Id: {rota.Id} Caminhão: {rota.Caminhao} Partida: {rota.Partida} Chegada: {rota.Chegada} Data: {rota.Data} Valor Rota: {rota.ValorRota}");
      }

      return stringRotas;
    }

    public static double ValorMedioRotas()
    {
      double valorMedio = (from rota in Rotas
                           select rota.ValorRota).Average();

      return valorMedio;
    }
  }
}