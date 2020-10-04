using System;
using Xunit;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using DeviceApp1.Service;
using System.Text;
using Microsoft.Azure.Devices;
using SharedLibrary.Servicec;

namespace DeviceAppTests
{
    public class IvokeMethodTest
    {

      [Theory]
      [InlineData("DeviceApp1", "SetTelementryInterval", "10", "200")]

        public void TelementryInterval_CouldChangeTelementryInterval(string deviceTarget, string methodName, string payload, string expected)
        {

            
            string connectstring = "HostName=Ec-win20-iothubb.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=eSZmlrnE6XGEFfTVtMvUMBFAYkBqCPxsGkT8aw9uNQw=";
            var service = new Serviceclient(connectstring);

            var actual = service.InvokeMethod(deviceTarget, methodName, payload);

            Assert.Equal(expected, actual.Result.Status.ToString());



        }

        [Fact]

        public void Test1()
        {
            string connectstring = "HostName=Ec-win20-iothubb.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=eSZmlrnE6XGEFfTVtMvUMBFAYkBqCPxsGkT8aw9uNQw=";
            var service = new Serviceclient(connectstring);

            var expected = "200";

            var actual = service.InvokeMethod("DeviceApp1", "SetTelementryInterval", "10");



            Assert.Equal(expected, actual.Result.Status.ToString());

        }

      
    }

    






}
