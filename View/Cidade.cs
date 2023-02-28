using System;

namespace View
{
  public class Cidade
  {
    public static void ShowCadastroCidade()
    {
      Console.WriteLine("Cadastro de Cidade");
      Console.WriteLine("Informe o Id da Cidade");
      string id = Console.ReadLine();
      Console.WriteLine("Informe o Nome da Cidade");
      string nome = Console.ReadLine();
      Controller.Cidade.CadastrarCidade(id, nome);

      Console.WriteLine("Cidade cadastrada com sucesso");
    }

    public static void ShowListagemCidades()
    {
      Console.WriteLine("Listagem de Cidades");
      List<Model.Cidade> cidades = Controller.Cidade.ListarCidades();
      foreach (Model.Cidade cidade in cidades)
      {
        Console.WriteLine(cidade);
      }
    }

    public static void ShowEditarCidade()
    {
      Console.WriteLine("Edição de Cidades");
      Console.WriteLine("Informe o Id da Cidade");
      string id = Console.ReadLine();
      Console.WriteLine("Informe o Nome da Cidade");
      string nome = Console.ReadLine();
      Controller.Cidade.EditarCidade(id, nome);

      Console.WriteLine("Cidade editada com sucesso");
    }

    public static void ShowExcluirCidade()
    {
      Console.WriteLine("Exclusão de Cidades");
      Console.WriteLine("Informe o Id da Cidade");
      string id = Console.ReadLine();
      Controller.Cidade.ExcluirCidade(id);

      Console.WriteLine("Cidade excluída com sucesso");
    }
  }
}