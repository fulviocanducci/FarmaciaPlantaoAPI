using FarmaciaPlantao.Api.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaPlantao.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantaoController : Controller
    {
        private readonly AgendasRepository _agendasRepository;

        public PlantaoController(AgendasRepository agendasRepository)
        {
            _agendasRepository = agendasRepository;
        }

        [HttpGet]
        public ObjectResult Inicio()
        {
            var agora = DateTime.Now;

            if (agora.Hour > 22 && agora.Minute > 1)
                return NotFound("Farmácias fechadas!");
            
            var tem = _agendasRepository.Find(x => x.Inicio <= agora && x.Fim >= agora);

            if (tem == null)
                return NotFound("Sem farmácias de plantão no momento");

            return Ok(tem.Farmacia);
        }
    }
}
