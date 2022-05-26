using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaciaPlantao.Core.Communication.Notificacoes
{
    public interface INotificador
    {
        void LimparNotificacoes();
        bool TemNotificacoes();
        void Notificar(string notificacao);
        void Notificar(Notificacao notificacao);
        void Notificar(List<string> notificacoes);
        List<Notificacao> ObterNotificacoes();
        string ObterNotificacoesComoTexto();
    }
}
