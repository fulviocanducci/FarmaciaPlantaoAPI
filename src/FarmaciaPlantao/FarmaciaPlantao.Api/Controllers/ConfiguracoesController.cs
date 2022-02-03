using FarmaciaPlantao.Api.Repository;
using FarmaciaPlantao.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaPlantao.Api.Controllers
{
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("[controller]")]
    public class ConfiguracoesController : ControllerBase
    {        

        private readonly ILogger<ConfiguracoesController> _logger;
        private readonly FarmaciaRepository _farmaciaRepository;
        private readonly CidadesRepository _cidadesRepository;
        private readonly EstadoRepository _estadoRepository;
        private readonly AgendasRepository _agendasRepository;

        public ConfiguracoesController(ILogger<ConfiguracoesController> logger, FarmaciaRepository farmaciaRepository, CidadesRepository cidadesRepository, EstadoRepository estadoRepository, AgendasRepository agendasRepository)
        {
            _logger = logger;
            _farmaciaRepository = farmaciaRepository;
            _cidadesRepository = cidadesRepository;
            _estadoRepository = estadoRepository;
            _agendasRepository = agendasRepository;
        }

        //[HttpGet("inicio")]
        //public void Inicio()
        //{
        //    var farmaciass = _farmaciaRepository.All().ToList();

        //    var teste = Newtonsoft.Json.JsonConvert.SerializeObject(farmaciass);

        //    try
        //    {
        //        var estado = new Estado() { Nome = "São Paulo", UF = "SP" };
        //        estado = _estadoRepository.Add(estado);

        //        var cidade = new Cidade() { Nome = "Teodoro Sampaio", Estado = estado };
        //        cidade = _cidadesRepository.Add(cidade);


        //        var farmacias = _farmaciaRepository.All().ToList();

        //        foreach (var item in farmacias)
        //        {
        //            item.Cidade = cidade;
        //            _farmaciaRepository.Edit(x => x.Id == item.Id, item);
        //        }

        //    }
        //    catch (Exception e)
        //    {

        //        throw;
        //    }
        //}

        //[HttpGet("teste")]
        //public void Teste()
        //{
        //    try
        //    {
        //        var farmacia = _farmaciaRepository.Find(x => x.Id == new MongoDB.Bson.ObjectId("5eb823c7df422b4f380c2149"));

        //        var agenda = new Agenda()
        //        {
        //            Inicio = new DateTime(2022,01,29,8,0,0),
        //            Fim = new DateTime(2022, 02, 4, 22, 0, 0),
        //            Farmacia = farmacia
        //        };

        //        _agendasRepository.Add(agenda);

        //        var agora = DateTime.UtcNow;

        //        var tem = _agendasRepository.Find(x => x.Inicio <= agora && x.Fim >= agora);


        //    }
        //    catch (Exception e)
        //    {

        //        throw;
        //    }
        //}
    }
}
