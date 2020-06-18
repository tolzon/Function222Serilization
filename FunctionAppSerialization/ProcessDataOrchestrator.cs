using FunctionAppSerialization.DomainEvents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using System.Threading.Tasks;

namespace FunctionAppSerialization
{
    public class ProcessDataOrchestrator
    {
        [FunctionName("ProcessDataOrchestrator")]
        public async Task RunAsync([OrchestrationTrigger] IDurableOrchestrationContext orchestrationContext)
        {
            for (int i = 0; i < 10; i++)
            {
                await orchestrationContext.CallActivityAsync("ProcessDataActivity", new DoThingEvent());
            }
        }
    }
}
