using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaPlantao.Api.DTOs
{
    public class AgendaDTO
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public FarmaciaDTO Farmacia { get; set; }
    }
}
