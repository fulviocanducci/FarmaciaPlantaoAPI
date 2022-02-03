using FarmaciaPlantao.Core.Interfaces;
using FarmaciaPlantao.Core.Models;
using FarmaciaPlantao.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaPlantao.API.Interface
{
    public class FarmaciaRepository : Repository<Farmacia>, IRepository<Farmacia>
    {
        public FarmaciaRepository(Canducci.MongoDB.Repository.IConnect connect) : base(connect)
        {
        }
    }
}
