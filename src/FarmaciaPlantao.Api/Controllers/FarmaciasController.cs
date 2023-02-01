using FarmaciaPlantao.Api.DTOs;
using FarmaciaPlantao.Api.Repository;
using FarmaciaPlantao.Core.Communication.Notificacoes;
using FarmaciaPlantao.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FarmaciaPlantao.Api.Controllers
{
    public class FarmaciasController : PadraoController
    {
        private readonly FarmaciaRepository _farmaciaRepository;

        public FarmaciasController(INotificador notificador,
                                      FarmaciaRepository farmaciaRepository) : base(notificador)
        {
            _farmaciaRepository = farmaciaRepository;
        }

        [HttpGet("todos")]
        public ActionResult ObterFarmacias()
        {
           var farmacias = _farmaciaRepository.All();
            return CustomResponse(ToFarmaciasDTO(farmacias.ToList()));
        }


        private FarmaciaDTO ToFarmaciaDTO(Farmacia farmacia)
        {
            return new FarmaciaDTO()
            {
                Nome = farmacia.Nome,   
                UrlImagem= farmacia.UrlImagem,
                Telefone= farmacia.Telefone,
                Endereco= farmacia.Endereco,    
                Whatsapp = farmacia.Whatsapp,
                Id = farmacia.Id.ToString(),
                Cidade = farmacia.Cidade.Nome,
                Estado = farmacia.Cidade.Estado.Nome,
                UF = farmacia.Cidade.Estado.UF
                
            };
        }

        private List<FarmaciaDTO> ToFarmaciasDTO(List<Farmacia> farmacias)
        {
            var lista = new List<FarmaciaDTO>();

            if (farmacias == null) return lista;

            foreach (var farmacia in farmacias)
            {
                lista.Add(ToFarmaciaDTO(farmacia));
            }
            return lista;
        }

    }
}
