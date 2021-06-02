using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using FunctionAppOrders.Documents;

namespace FunctionAppOrders.Data
{
    public static class OrderRepository
    {
        public static List<OrderDocument> ListAll()
        {
            var client = new MongoClient(
                Environment.GetEnvironmentVariable("MongoDB_Connection"));
            var db = client.GetDatabase(
                Environment.GetEnvironmentVariable("MongoDB_Database"));
            var history = db.GetCollection<OrderDocument>(
                Environment.GetEnvironmentVariable("MongoDB_Collection"));
            
            return history.Find(all => true).ToList();
        }
    }
}