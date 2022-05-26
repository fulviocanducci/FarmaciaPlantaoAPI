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
    public class EstadosController : PadraoController
    {
        private readonly EstadoRepository _estadoRepository;

        public EstadosController(INotificador notificador, EstadoRepository estadoRepository) : base(notificador)
        {
            _estadoRepository = estadoRepository;
        }

        [HttpGet("todos")]
        public ActionResult Index()
        {
            var estados = _estadoRepository.All();
            return CustomResponse(ToEstadosDTO(estados));
        }


        private List<EstadoDTO> ToEstadosDTO(IEnumerable<Estado> estados)
        {
            var lista = new List<EstadoDTO>();
            if (estados == null) return lista;
            foreach (var estado in estados)
            {
                lista.Add(ToEstadoDTO(estado));
            }

            return lista;
        }

        private EstadoDTO ToEstadoDTO(Estado estado)
        {
            return new EstadoDTO()
            {
                Id = estado.Id.ToString(),
                Nome = estado.Nome,
                UF = estado.UF
            };
        }
    }
}
