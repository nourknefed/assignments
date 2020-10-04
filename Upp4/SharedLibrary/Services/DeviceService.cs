using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MAD = Microsoft.Azure.Devices;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using SharedLibrary.Models;


namespace SharedLibrary.Services
{
    public static class DeviceService
    {
        private static readonly Random rnd = new Random();
        public  static async Task SendMessageAsync(DeviceClient deviceClient)
        {
            while (true)
            {
                var data = new TemperatureModel
                {
                    Temperature = rnd.Next(20, 30),
                    Humidity = rnd.Next(30, 40)
                };

                var json = JsonConvert.SerializeObject(data);
                var payload = new Message(Encoding.UTF8.GetBytes(json));

                await deviceClient.SendEventAsync(payload);

                Console.WriteLine($"Message sent:{json}");

                await Task.Delay(10 * 1000);
            }

           

        }
        public static async Task RecieveMessageAsync(DeviceClient deviceClient)
        {
            while (true)
            {
                var payload = await deviceClient.ReceiveAsync();
                if (payload == null)
                    continue;

                Console.WriteLine($"Message Recieved:{Encoding.UTF8.GetString(payload.GetBytes())}");
            }
        }


        public static async Task SendMessageToDevicAsync (MAD.ServiceClient serviceClient, string targetdevice, string message)
        {
            var payload = new MAD.Message(Encoding.UTF8.GetBytes(message));
            await serviceClient.SendAsync(targetdevice, payload);
        }

    }
}
