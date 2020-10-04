using System;
using Microsoft.Azure.Devices.Client;
using SharedLibrary.Models;
using SharedLibrary.Services;

namespace ConsoleApp
{
    class Program

    {
        private static readonly string _conn = "HostName=Ec-win20-iothubb.azure-devices.net;DeviceId=ConsoleApp;SharedAccessKey=qiiSQ+s181UJHhWvDJduKI5jAXAhHJIFgzzvxpz6L2c=";
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);
         static void Main(string[] args)
        {

            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();

           DeviceService.RecieveMessageAsync(deviceClient).GetAwaiter();

            Console.ReadKey();
        }
            
        
    }
}
