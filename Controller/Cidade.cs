namespace Controller 
{
  public class Cidade 
  {
    public static void CadastrarCidade(string id, string nome)
    {
      int idConvert = 0;

      try {
        idConvert = Convert.ToInt32(id);
      } catch (Exception) {
        throw new Exception("Id inválido");
      }

      Model.Cidade cidade = new Model.Cidade(idConvert, nome);
    }

    public static void EditarCidade(string id, string nome)
    {
      int idConvert = 0;

      try {
        idConvert = Convert.ToInt32(id);
      } catch (Exception) {
        throw new Exception("Id inválido");
      }

      Model.Cidade.EditarCidade(idConvert, nome);
    }

    public static void ExcluirCidade(string id)
    {
      int idConvert = 0;

      try {
        idConvert = Convert.ToInt32(id);
      } catch (Exception) {
        throw new Exception("Id inválido");
      }

      Model.Cidade.ExcluirCidade(idConvert);
    }
    
    public static List<Model.Cidade> ListarCidades()
    {
      return Model.Cidade.Cidades;
    }
  }
}