using FunctionAppSerialization.DomainEvents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using System.Threading.Tasks;

namespace FunctionAppSerialization
{
    public class ProcessDataActivity
    {
        [FunctionName("ProcessDataActivity")]
        public void RunAsync([ActivityTrigger] DoThingEvent evt)
        {
            var i = 1;
        }
    }
}
