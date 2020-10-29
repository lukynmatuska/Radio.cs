using RadioTemplate.Radio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadioTemplate.RadioDevice
{
    public class BrandNewRadio : IRadioDevice
    {
        private List<RadioMessage> messageHistory;
        private RadioStation station;

        public BrandNewRadio(RadioStation radioStation)
        {
            station = radioStation;
            messageHistory = new List<RadioMessage>();
        }

        public IEnumerable<RadioMessage> RadioSavedNews()
        {
            return messageHistory.Where(ms => ms.MessageType == RadioMessageType.News);
        }

        public IEnumerable<RadioMessage> RadioSavedMusic()
        {
            return messageHistory.Where(ms => ms.MessageType == RadioMessageType.Music);
        }

        public void TurnOffRadio()
        {
            station.OnRadioBroadcast -= Station_OnRadioBroadcast;
            station.OnModeratorChange -= Station_OnModeratorChange;
        }

        public void TurnOnRadio()
        {
            station.OnRadioBroadcast += Station_OnRadioBroadcast;
            station.OnModeratorChange += Station_OnModeratorChange;
        }

        private void Station_OnModeratorChange(object sender, string e)
        {
            Console.WriteLine($"[BrandNewRadio] New moderator: {e}");
        }

        private void Station_OnRadioBroadcast(object sender, RadioMessage e)
        {
            if(e.MessageType == RadioMessageType.News || e.MessageType == RadioMessageType.Music)
            {
                messageHistory.Add(e);
            }
            Console.WriteLine($"[BrandNewRadio] [{e.MessageType}] {e.Moderator}: {e.Message}");
        }
    }
}
