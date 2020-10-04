using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SharedLibrary.Models;
using SharedLibrary.Services;
using Microsoft.Azure.Devices;

namespace AzureFunction
{
    public static class SendMessageToDevice_Upp3
    {
        private static readonly ServiceClient serviceClient = ServiceClient.CreateFromConnectionString(Environment.GetEnvironmentVariable("IothubConnection"));

        [FunctionName("SendMessageToDevice")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string targetdevice = req.Query["targetdevice"];
            string message = req.Query["message"];
           





            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var data = JsonConvert.DeserializeObject<BodymessageM>(requestBody);
            targetdevice = targetdevice ?? data?.TargetDevice;

            message = message ?? data?.TargetMessage;

            DeviceService.SendMessageToDevicAsync(serviceClient, targetdevice, message);


            return new OkResult();
        }
    }
}
