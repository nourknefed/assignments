using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;

namespace DeviceApp1.Service
{

    public class DeviceService
    {

        private static int _telementryInterval = 5;
        private static Random rnd = new Random();


        public static async Task<MethodResponse> SetTelementryInterval(MethodRequest request, object userContext)
        {
            var payload = SetTInterval(Convert.ToInt32(request.DataAsJson));

            Console.WriteLine($"Interval set to: {_telementryInterval} seconds.");

            return await Task.FromResult(new MethodResponse(Encoding.UTF8.GetBytes(request.DataAsJson), 200));
           
        }

        public static bool SetTInterval(int telementryInterval)
        {
            try
            {
                 _telementryInterval = telementryInterval;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static  async Task SendMessageasync(DeviceClient deviceClient)
        {
            while (true)
            {
                double temp = 10 + rnd.NextDouble() * 15;
                double hum = 40 + rnd.NextDouble() * 20;

                var data = new
                {
                    temperature = temp,
                    humididty = hum
                };

                var json = JsonConvert.SerializeObject(data);

                var payload = new Message(Encoding.UTF8.GetBytes(json));

                payload.Properties.Add("TemperatureAlert", (temp > 30) ? "true" : "false");

                await deviceClient.SendEventAsync(payload);

                Console.WriteLine($" Message sent {json}");

                await Task.Delay(_telementryInterval * 1000);
            }




        }

       
    }
}
