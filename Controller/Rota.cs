using System;

namespace Controller
{
  public class Rota
  {
    public static void CadastrarRota(string id, string idCaminhao, string idPartida, string idChegada, string data)
    {
      int idConvert = Utils.Utils.ConvertToInt(id);
      int idCaminhaoConvert = Utils.Utils.ConvertToInt(idCaminhao);
      int idPartidaConvert = Utils.Utils.ConvertToInt(idPartida);
      int idChegadaConvert = Utils.Utils.ConvertToInt(idChegada);
      Model.Caminhao caminhao = Model.Caminhao.BuscarCaminhao(idCaminhaoConvert);
      Model.Cidade partida = Model.Cidade.BuscarCidade(idPartidaConvert);
      Model.Cidade chegada = Model.Cidade.BuscarCidade(idChegadaConvert);
      Model.Rota rota = new Model.Rota(idConvert, caminhao, partida, chegada, data);
    }

    public static void EditarRota(string id, string idCaminhao, string idPartida, string idChegada, string data)
    {
      int idConvert = Utils.Utils.ConvertToInt(id);
      int idCaminhaoConvert = Utils.Utils.ConvertToInt(idCaminhao);
      int idPartidaConvert = Utils.Utils.ConvertToInt(idPartida);
      int idChegadaConvert = Utils.Utils.ConvertToInt(idChegada);
      Model.Caminhao caminhao = Model.Caminhao.BuscarCaminhao(idCaminhaoConvert);
      Model.Cidade partida = Model.Cidade.BuscarCidade(idPartidaConvert);
      Model.Cidade chegada = Model.Cidade.BuscarCidade(idChegadaConvert);
      Model.Rota rota = Model.Rota.BuscarRota(idConvert);
      Model.Rota.EditarRota(idConvert, caminhao, partida, chegada, data);
    }

    public static void ExcluirRota(string id)
    {
      int idConvert = Utils.Utils.ConvertToInt(id);
      Model.Rota.ExcluirRota(idConvert);
    }
  }
}