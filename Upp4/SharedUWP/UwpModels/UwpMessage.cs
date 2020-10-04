using System;
using System.Collections.Generic;
using System.Text;
using Windows.Devices.I2c;

namespace SharedLibraryUWP.Models
{
    public class Message_Body
    {
        public string TargetDevice { get; set; }
        public string TargetMessage { get; set; }

        public Message_Body(string message)
        {
            
            TargetMessage = message;
        }
    }
}
