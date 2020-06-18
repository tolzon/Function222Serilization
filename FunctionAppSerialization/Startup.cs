using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

[assembly: FunctionsStartup(typeof(FunctionAppSerialization.Startup))]

namespace FunctionAppSerialization
{

    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IMessageSerializerSettingsFactory, MessageSerializerSettingsFactory>();
        }
    }

    public class MessageSerializerSettingsFactory : IMessageSerializerSettingsFactory
    {
        public JsonSerializerSettings CreateJsonSerializerSettings() => new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        };
    }
}
