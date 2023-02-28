using System;

namespace View
{
  public class Rota
  {
    public static void ShowCadastroRota()
    {
      Console.WriteLine("Cadastro de Rota");
      Console.WriteLine("Informe o Id da Rota");
      string id = Console.ReadLine();
      Console.WriteLine("Informe o Id da Cidade de Origem");
      string idCidadeOrigem = Console.ReadLine();
      Console.WriteLine("Informe o Id da Cidade de Destino");
      string idCidadeDestino = Console.ReadLine();
      Console.WriteLine("Informe o Id do Caminhão");
      string idCaminhao = Console.ReadLine();
      Console.WriteLine("Informe a Data de Saída");
      string dataSaida = Console.ReadLine();

      Controller.Rota.CadastrarRota(id, idCidadeOrigem, idCidadeDestino, idCaminhao, dataSaida);

      Console.WriteLine("Rota cadastrada com sucesso");
    }

    public static void ShowListagemRotas()
    {
      Console.WriteLine("Listagem de Rotas");
      foreach (string rota in Model.Rota.ListarRotas())
      {
        Console.WriteLine(rota);
      }
    }

    public static void ShowEditarRotas()
    {
      Console.WriteLine("Edição de Rotas");
      Console.WriteLine("Informe o Id da Rota");
      string id = Console.ReadLine();
      Console.WriteLine("Informe o Id da Cidade de Origem");
      string idCidadeOrigem = Console.ReadLine();
      Console.WriteLine("Informe o Id da Cidade de Destino");
      string idCidadeDestino = Console.ReadLine();
      Console.WriteLine("Informe o Id do Caminhão");
      string idCaminhao = Console.ReadLine();
      Console.WriteLine("Informe a Data de Saída");
      string dataSaida = Console.ReadLine();

      Controller.Rota.EditarRota(id, idCidadeOrigem, idCidadeDestino, idCaminhao, dataSaida);

      Console.WriteLine("Rota editada com sucesso");
    }

    public static void ShowExcluirRota()
    {
      Console.WriteLine("Exclusão de Rotas");
      Console.WriteLine("Informe o Id da Rota");
      string id = Console.ReadLine();
      Controller.Rota.ExcluirRota(id);

      Console.WriteLine("Rota excluída com sucesso");
    }
  }
}