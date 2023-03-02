using System;

namespace Controller
{
  public class Rota
  {
    public static void CadastrarRota(string id, string idCaminhao, string idPartida, string idChegada, string data, string valorRota)
    {
      int idConvert = Utils.Utils.ConvertToInt(id);
      int idCaminhaoConvert = Utils.Utils.ConvertToInt(idCaminhao);
      int idPartidaConvert = Utils.Utils.ConvertToInt(idPartida);
      int idChegadaConvert = Utils.Utils.ConvertToInt(idChegada);
      double valorRotaConvert = Utils.Utils.ConvertToDouble(valorRota);
      Model.Caminhao caminhao = Model.Caminhao.BuscarCaminhao(idCaminhaoConvert);
      Model.Cidade partida = Model.Cidade.BuscarCidade(idPartidaConvert);
      Model.Cidade chegada = Model.Cidade.BuscarCidade(idChegadaConvert);
      Utils.Utils.ValidarData(data);
      Model.Rota rota = new Model.Rota(idConvert, caminhao, partida, chegada, data, valorRotaConvert);
    }

    public static void EditarRota(string id, string idCaminhao, string idPartida, string idChegada, string data, string valorRota)
    {
      int idConvert = Utils.Utils.ConvertToInt(id);
      int idCaminhaoConvert = Utils.Utils.ConvertToInt(idCaminhao);
      int idPartidaConvert = Utils.Utils.ConvertToInt(idPartida);
      int idChegadaConvert = Utils.Utils.ConvertToInt(idChegada);
      double valorRotaConvert = Utils.Utils.ConvertToDouble(valorRota);
      Model.Caminhao caminhao = Model.Caminhao.BuscarCaminhao(idCaminhaoConvert);
      Model.Cidade partida = Model.Cidade.BuscarCidade(idPartidaConvert);
      Model.Cidade chegada = Model.Cidade.BuscarCidade(idChegadaConvert);
      Model.Rota rota = Model.Rota.BuscarRota(idConvert);
      Utils.Utils.ValidarData(data);
      Model.Rota.EditarRota(idConvert, caminhao, partida, chegada, data, valorRotaConvert);
    }

    public static void ExcluirRota(string id)
    {
      int idConvert = Utils.Utils.ConvertToInt(id);
      Model.Rota.ExcluirRota(idConvert);
    }

    public static void MediaValorRotas()
    {
      double valorMedio = Model.Rota.ValorMedioRotas();
      Console.WriteLine($"Valor médio das rotas: {valorMedio}");
    }
  }
}