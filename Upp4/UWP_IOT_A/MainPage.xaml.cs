using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Azure.Devices.Client;
using Services;
//using Microsoft.Azure.Devices;
using SharedLibraryUWP.Models;





// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_IOT_A
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static string _conn = "HostName=Ec-win20-iothubb.azure-devices.net;DeviceId=UWP_IOT_A;SharedAccessKey=YOiqoTR4KOFu5BCcvGq89CC5YkwqgyIpNnXLqCLpRdg=";
        private static DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);


        

        public MainPage()
        {
            this.InitializeComponent();
        }

        

        private async void Weather_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                DataContext = DeviceServiceUWP.SendMessageAsync(deviceClient).GetAwaiter();

                var recieved = await DeviceServiceUWP.RecieveMessageAsync(deviceClient);

                lv_RecievedMessage.Items.Add(recieved.ToString());
              
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
          


        }


    }
}
