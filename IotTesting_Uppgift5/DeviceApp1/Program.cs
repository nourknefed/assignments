using System;
using Microsoft.Azure.Devices.Client;
using DeviceApp1.Service;
using SharedLibrary.Servicec;
using System.Threading.Tasks;

namespace DeviceApp1
{
    class Program
    {
        private static  DeviceClient deviceClient = DeviceClient.CreateFromConnectionString("HostName=Ec-win20-iothubb.azure-devices.net;DeviceId=DeviceApp1;SharedAccessKey=mUah0sMqm03UZ2SLqL5J0PlJKfYCcTZGCV79fXmgfzU=", TransportType.Mqtt);
    
        static void Main(string[] args)
        {

            deviceClient.SetMethodHandlerAsync("SetTelementryInterval", DeviceService.SetTelementryInterval, null).Wait();
            DeviceService.SendMessageasync(deviceClient).GetAwaiter();
            Console.ReadKey();
        }
    }
}
