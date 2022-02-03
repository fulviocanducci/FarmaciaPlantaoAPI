using FarmaciaPlantao.Core.Interfaces;
using FarmaciaPlantao.Core.Models;
using FarmaciaPlantao.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaPlantao.Api.Repository
{
    public class AgendasRepository : Repository<Agenda>, IRepository<Agenda>
    {
        public AgendasRepository(IConnect connect) : base(connect)
        {
        }
    }
}
