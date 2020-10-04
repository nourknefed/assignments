using Microsoft.Azure.Devices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;

namespace SharedLibrary.Servicec
{
    public class Serviceclient
    {
        private  ServiceClient serviceClient; 

        public Serviceclient(string connectstring)
        {
            serviceClient = ServiceClient.CreateFromConnectionString(connectstring);
            InvokeMethod("DeviceApp1", "SetTelementryInterval", "20").GetAwaiter();
        }
     
        public   async Task<CloudToDeviceMethodResult> InvokeMethod(string deviceId, string methodName, string payload)
        {
            var methodinvokation = new CloudToDeviceMethod(methodName);

            methodinvokation.SetPayloadJson(payload);

            var response = await serviceClient.InvokeDeviceMethodAsync(deviceId, methodinvokation);


            Console.WriteLine($"Response status : {response.Status}");

            Console.WriteLine(response.GetPayloadAsJson());

            return response;

            

        }

      
    }
}  
