using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;

namespace FunctionAppSerialization
{
    public class Function1
    {
        public Function1() { }

        [FunctionName("Function1")]
        public async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "func")] HttpRequest req,
            ILogger log,
            [DurableClient] IDurableOrchestrationClient starter)
        {
            await starter.StartNewAsync("ProcessDataOrchestrator");
            return new OkResult();
        }
    }
}
