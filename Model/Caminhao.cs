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
      return $"Id: {this.Id} Placa: {this.Placa} Motorista: {this.Motorista} Valor Total: {Caminhao.ValorTotalCaminhao(this.Id)} Quantidade de Rotas: {Caminhao.TotalRotasCaminhao(this.Id)}";
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

    public static int TotalRotasCaminhao(int id)
    {
      int quantidadeRotas = (from rota in Rota.Rotas
                                        join caminhao in Caminhao.Caminhoes on rota.idCaminhao equals caminhao.Id
                                        where caminhao.Id == id
                                        select rota).Count();
      return quantidadeRotas;
    }

    public static double ValorTotalCaminhao(int id)
    {
      double valorTotal = (from rota in Rota.Rotas
                                        join caminhao in Caminhao.Caminhoes on rota.idCaminhao equals caminhao.Id
                                        where caminhao.Id == id
                                        select rota.ValorRota).Sum();
      return valorTotal;
    }
  }
}