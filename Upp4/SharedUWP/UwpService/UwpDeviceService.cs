using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MAD = Microsoft.Azure.Devices;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using SharedLibrary.Models;
using System.Collections.ObjectModel;
using SharedLibraryUWP.Models;

namespace Services
{
    public  class DeviceServiceUWP:ObservableCollection<Message_Body>
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

        public static async Task<string> RecieveMessageAsync(DeviceClient deviceClient)
        {
            while (true)
            {
                var payload = await deviceClient.ReceiveAsync();
                if (payload == null)
                    continue;

                string m = $"Message Recieved {Encoding.UTF8.GetString(payload.GetBytes())}";

                await deviceClient.CompleteAsync(payload);
                return m;
                
            }
        }
       

        public static async Task SendMessageToDevicAsync(MAD.ServiceClient serviceClient, string targetdevice, string message)
        {
            var payload = new MAD.Message(Encoding.UTF8.GetBytes(message));
            await serviceClient.SendAsync(targetdevice, payload);
        }
    }
}
