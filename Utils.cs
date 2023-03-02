namespace Utils
{
  public class Utils
  {
    public static int ConvertToInt(string id)
    {
      int idConvert = 0;
      try {
        idConvert = Convert.ToInt32(id);
      } catch (Exception) {
        throw new Exception("Id inválido");
      }
      return idConvert;
    }

    public static double ConvertToDouble(string valor)
    {
      double valorConvert = 0;
      try {
        valorConvert = Convert.ToDouble(valor);
      } catch (Exception) {
        throw new Exception("Valor inválido");
      }
      return valorConvert;
    }

    public static bool ValidarData(string data)
    {
      DateTime dataConvert;
      try {
        dataConvert = Convert.ToDateTime(data);
      } catch (Exception) {
        throw new Exception("Data inválida");
      }
      return true;
    }
  }
}