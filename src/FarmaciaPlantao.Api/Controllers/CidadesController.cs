using FarmaciaPlantao.Api.DTOs;
using FarmaciaPlantao.Api.Repository;
using FarmaciaPlantao.Core.Communication.Notificacoes;
using FarmaciaPlantao.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaPlantao.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadesController : PadraoController
    {
        private readonly CidadesRepository _cidadesRepository;

        public CidadesController(INotificador notificador, CidadesRepository cidadesRepository) : base(notificador)
        {
            _cidadesRepository = cidadesRepository;
        }
        [HttpGet("por-estado")]
        public ActionResult Index(string estadoId)
        {
            var cidades = _cidadesRepository.All(x => x.Estado.Id == new MongoDB.Bson.ObjectId(estadoId));
            return CustomResponse(ToCidadesDTO(cidades));
        }

        private List<CidadeDTO> ToCidadesDTO(IEnumerable<Cidade> cidades)
        {
            var lista = new List<CidadeDTO>();
            if (cidades == null) return lista;
            foreach (var cidade in cidades)
            {
                lista.Add(ToCidadeDTO(cidade));
            }

            return lista;
        }

        private CidadeDTO ToCidadeDTO(Cidade cidade)
        {
            return new CidadeDTO()
            {
                Id = cidade.Id.ToString(),
                Nome = cidade.Nome,
                EstadoId = cidade.Estado.Id.ToString()
            };
        }
    }
}
