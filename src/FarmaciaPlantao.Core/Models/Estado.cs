using Canducci.MongoDB.Repository.Attributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaciaPlantao.Core.Models
{
    [BsonCollectionName("Estados")]
    public class Estado
    {
        [BsonId()]
        public ObjectId Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
    }
}
