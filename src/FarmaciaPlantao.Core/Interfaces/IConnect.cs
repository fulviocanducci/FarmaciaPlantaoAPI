using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaciaPlantao.Core.Interfaces
{
    public interface IConnect
    {
        IMongoCollection<T> Collection<T>(string collectionName);
        IMongoCollection<T> Collection<T>(string collectionName, MongoCollectionSettings mongoCollectionSettings);
    }
}
