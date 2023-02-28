using System;

namespace View
{
  public class Caminhao
  {
    public static void ShowCadastroCaminhao()
    {
      Console.WriteLine("Cadastro de Caminhão");
      Console.WriteLine("Informe o Id do Caminhão");
      string id = Console.ReadLine();
      Console.WriteLine("Informe a Placa do Caminhão");
      string placa = Console.ReadLine();
      Console.WriteLine("Informe o Motorista do Caminhão");
      string motorista = Console.ReadLine();
      Controller.Caminhao.CadastrarCaminhao(id, placa, motorista);

      Console.WriteLine("Caminhão cadastrado com sucesso");
    }

    public static void ShowListagemCaminhoes()
    {
      Console.WriteLine("Listagem de Caminhões");
      List<Model.Caminhao> caminhoes = Controller.Caminhao.ListarCaminhoes();
      foreach (Model.Caminhao caminhao in caminhoes)
      {
        Console.WriteLine(caminhao);
      }
    }

    public static void ShowEditarCaminhoes()
    {
      Console.WriteLine("Edição de Caminhões");
      Console.WriteLine("Informe o Id do Caminhão");
      string id = Console.ReadLine();
      Console.WriteLine("Informe a Placa do Caminhão");
      string placa = Console.ReadLine();
      Console.WriteLine("Informe o Motorista do Caminhão");
      string motorista = Console.ReadLine();
      Controller.Caminhao.EditarCaminhao(id, placa, motorista);

      Console.WriteLine("Caminhão editado com sucesso");
    }

    public static void ShowExcluirCaminhao()
    {
      Console.WriteLine("Exclusão de Caminhões");
      Console.WriteLine("Informe o Id do Caminhão");
      string id = Console.ReadLine();
      Controller.Caminhao.ExcluirCaminhao(id);

      Console.WriteLine("Caminhão excluído com sucesso");
    }
  }
}