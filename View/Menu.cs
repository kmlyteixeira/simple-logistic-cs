using System;

namespace View
{
  public class Menu
  {
    public static void ShowMenu()
    {
      int opcao = 0;
      do
      {
      Console.WriteLine("1 - Cadastrar Caminhão");
      Console.WriteLine("2 - Listar Caminhões");
      Console.WriteLine("3 - Editar Caminhão");
      Console.WriteLine("4 - Excluir Caminhão");
      Console.WriteLine("5 - Cadastrar Cidade");
      Console.WriteLine("6 - Listar Cidade");
      Console.WriteLine("7 - Editar Cidade");
      Console.WriteLine("8 - Excluir Cidade");
      Console.WriteLine("9 - Cadastrar Rota");
      Console.WriteLine("10 - Listar Rotas");
      Console.WriteLine("11 - Editar Rotas");
      Console.WriteLine("12 - Excluir Rotas");
      Console.WriteLine("13 - Valor Médio Rotas");
      Console.WriteLine("0 - Sair");
      opcao = int.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1: 
          View.Caminhao.ShowCadastroCaminhao();
          break;
        case 2:
          View.Caminhao.ShowListagemCaminhoes();
          break;
        case 3:
          View.Caminhao.ShowEditarCaminhoes();
          break;
        case 4:
          View.Caminhao.ShowExcluirCaminhao();
          break;
        case 5:
          View.Cidade.ShowCadastroCidade();
          break;
        case 6:
          View.Cidade.ShowListagemCidades();
          break;
        case 7:
          View.Cidade.ShowEditarCidade();
          break;
        case 8:
          View.Cidade.ShowExcluirCidade();
          break;
        case 9:
          View.Rota.ShowCadastroRota();
          break;
        case 10:
          View.Rota.ShowListagemRotas();
          break;
        case 11:
          View.Rota.ShowEditarRotas();
          break;
        case 12:
          View.Rota.ShowExcluirRota();
          break;
        case 13:
          View.Rota.ShowMediaValorRotas();
          break;
        case 0:
          Console.WriteLine("0 - Sair");
          break;
        default:
          Console.WriteLine("Opção inválida");
          break;
      }

      } while (opcao != 0);
    }
  }
}