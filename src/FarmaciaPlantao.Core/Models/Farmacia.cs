using Canducci.MongoDB.Repository.Attributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaciaPlantao.Core.Models
{
    [BsonCollectionName("Farmacias")]
    public class Farmacia
    {
        [BsonRequired()]
        [BsonId()]
        public ObjectId Id { get; set; }

        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Whatsapp { get; set; }
        public string UrlImagem { get; set; }
        public Cidade Cidade { get; set; }
    }
}
