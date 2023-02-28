namespace Controller 
{
  public class Caminhao 
  {
    public static void CadastrarCaminhao(string id, string placa, string motorista)
    {
      int idConvert = Utils.Utils.ConvertToInt(id);
      Model.Caminhao caminhao = new Model.Caminhao(idConvert, placa, motorista);
    }

    public static void EditarCaminhao(string id, string placa, string motorista)
    {
      int idConvert = Utils.Utils.ConvertToInt(id);
      Model.Caminhao.EditarCaminhao(idConvert, placa, motorista);
    }

    public static void ExcluirCaminhao(string id)
    {
      int idConvert = Utils.Utils.ConvertToInt(id);      
      Model.Caminhao.ExcluirCaminhao(idConvert);
    }

    public static List<Model.Caminhao> ListarCaminhoes()
    {
      return Model.Caminhao.Caminhoes;
    }
  }
}