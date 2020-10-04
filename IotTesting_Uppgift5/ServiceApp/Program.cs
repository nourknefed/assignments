using System;
using Microsoft.Azure.Devices.Client;
using DeviceApp1.Service;
using SharedLibrary.Servicec;
using System.Threading.Tasks;
using Microsoft.Azure.Devices;

namespace ServiceApp
{
    class Program
    {
        public ServiceClient serviceClient = ServiceClient.CreateFromConnectionString("HostName=Ec-win20-iothubb.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=eSZmlrnE6XGEFfTVtMvUMBFAYkBqCPxsGkT8aw9uNQw=");

        static void Main(string[] args)
        {

            

            Console.ReadKey();
        }
    }
    
}
