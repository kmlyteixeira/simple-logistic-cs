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
  }
}