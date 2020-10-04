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
using SharedLibrary.Models;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_iot
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static readonly string _conn = "HostName=Ec-win20-iothubb.azure-devices.net;DeviceId=ConsoleApp;SharedAccessKey=qiiSQ+s181UJHhWvDJduKI5jAXAhHJIFgzzvxpz6L2c=";
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);
        public MainPage()
        {
            this.InitializeComponent();

          

        }

        private void Weather_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);
                DataContext = DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
               

            }
            catch(Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

           
           




        }
    }
}
