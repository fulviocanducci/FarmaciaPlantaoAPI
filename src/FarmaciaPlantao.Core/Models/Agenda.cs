using Canducci.MongoDB.Repository.Attributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaciaPlantao.Core.Models
{
    [BsonCollectionName("Agendas")]
    public class Agenda
    {
        [BsonId()]
        public ObjectId Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Farmacia Farmacia { get; set; }
    }
}
