using FarmaciaPlantao.Core.Communication.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmaciaPlantao.Core.Communication
{
    public class Notificador : INotificador
    {
        private List<Notificacao> _notificacoes;

        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void LimparNotificacoes()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Notificar(string notificacao)
        {
            _notificacoes.Add(new Notificacao(notificacao));
        }

        public void Notificar(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }       

        public void Notificar(List<string> notificacoes)
        {
            for (int i = 0; i < notificacoes.Count; i++)
                Notificar(notificacoes[i]);
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public bool TemNotificacoes()
        {
            return _notificacoes.Any();
        }

        public string ObterNotificacoesComoTexto()
        {
            return string.Join(". ", _notificacoes.Select(n => n.Mensagem));
        }
    }
}
