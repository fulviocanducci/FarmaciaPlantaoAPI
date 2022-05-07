using FarmaciaPlantao.Api.DTOs;
using FarmaciaPlantao.Core.Communication.Notificacoes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaPlantao.Api.Controllers
{
    public class PadraoController : ControllerBase
    {
        protected readonly INotificador _notificador;

        protected PadraoController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacoes();
        }

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
                return Ok(result);

            return BadRequest(new ErrorDto()
            {
                Erros = _notificador.ObterNotificacoes().Select(n => n.Mensagem).ToList()
            });
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            if (!modelState.IsValid) NotificarErroModelInvalida(modelState);
            return CustomResponse();
        }

        protected void NotificarErroModelInvalida(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                var errorMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotificarErro(errorMsg);
            }
        }

        protected void NotificarErro(string mensagem)
        {
            _notificador.Notificar(new Notificacao(mensagem));
        }

        protected string ObterMensagemErros()
        {
            return string.Join(',', _notificador.ObterNotificacoes().Select(n => n.Mensagem));
        }
    }
}
