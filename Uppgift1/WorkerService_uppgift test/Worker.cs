using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace WorkerService_uppgift_test
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private string url = "https://api.openweathermap.org/data/2.5/onecall?lat=59.27412&lon=15.2066&exclude=current-daily-hourly&appid=bea7b0cf12273cc11febf06fd50ac80f";
        private HttpClient client;
       
        

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
     
            _logger.LogInformation("The service has been started.");

            return base.StartAsync(cancellationToken);
        }
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("The service has been stopped.");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                 client = new HttpClient();
                var response = await client.GetAsync(url);

                
                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Requst message information \n\n" + response.RequestMessage + "\n");
                        var result = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<Rootobject>(result);


                        _logger.LogInformation("Tempretaure is: {temp}",data.current.temp);

                        double Tem;
                        Tem = data.current.temp;

                                            

                        if (Tem >= 300)
                        {
                            Console.WriteLine("The temperature is so high");
                        
                        }
                        else
                        {
                            Console.WriteLine("The temperature is normal");
                        }

                    }
                }
                catch (Exception ex)
                {
                    _logger.LogInformation($"{ex.Message}");
                }

               

                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(60*1000, stoppingToken);
            }
        }
    }
}
