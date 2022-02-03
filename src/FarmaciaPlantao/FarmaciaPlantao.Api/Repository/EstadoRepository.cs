using FarmaciaPlantao.Core.Interfaces;
using FarmaciaPlantao.Core.Models;
using FarmaciaPlantao.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaPlantao.Api.Repository
{
    public class EstadoRepository : Repository<Estado>, IRepository<Estado>
    {
        public EstadoRepository(IConnect connect) : base(connect)
        {
        }
    }
}
