using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using FunctionAppOrders.Data;

namespace FunctionAppOrders
{
    public static class Orders
    {
        [FunctionName("Orders")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var data = OrderRepository.ListAll().OrderByDescending(o => o.ProcessingDate);
            log.LogInformation($"Order - quantidade: {data.Count()}");
            return new OkObjectResult(data);
        }
    }
}