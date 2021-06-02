using System;
using MongoDB.Bson;

namespace FunctionAppOrders.Documents
{
    public class OrderDocument
    {
        public ObjectId _id { get; set; }
        public DateTime ProcessingDate { get; set; }
        public OrderData Data { get; set; }
    }
    public class OrderData
    {
        public string CorrelationId { get; set; }
        public DateTime? When { get; set; }
        public Payload Payload { get; set; }
    }

    public class Payload
    {
        public string CustomerName { get; set; }
        public decimal? Total { get; set; }
        public string ID { get; set; }
    }
}