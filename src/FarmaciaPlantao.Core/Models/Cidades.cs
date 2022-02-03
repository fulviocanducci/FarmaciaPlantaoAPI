using Canducci.MongoDB.Repository.Attributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaciaPlantao.Core.Models
{
    [BsonCollectionName("Cidades")]
    public class Cidade
    {
        [BsonId()]
        public ObjectId Id { get; set; }
        public string Nome { get; set; }
        public Estado Estado { get; set; }
    }
}
