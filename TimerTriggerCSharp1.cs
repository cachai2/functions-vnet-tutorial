using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class TimerTriggerCSharp1
    {
        [FunctionName("TimerTriggerCSharp1")]
        [return: ServiceBus("queue", Connection = "SERVICEBUS_CONNECTION")]
        public static string ServiceBusOutput([TimerTrigger("* 0/5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            string output = $"C# Timer trigger function executed at: {DateTime.Now}";
            log.LogInformation(output);
            return output;
        }
    }
}
