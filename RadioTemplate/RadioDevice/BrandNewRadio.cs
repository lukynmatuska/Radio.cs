using RadioTemplate.Radio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioTemplate.RadioDevice
{
    public class BrandNewRadio : IRadioDevice
    {
        private List<RadioMessage> messageHistory;
        private RadioStation station;

        public BrandNewRadio(RadioStation radioStation)
        {
            this.station = radioStation;
        }

        public IEnumerable<RadioMessage> RadioSavedNews()
        {
            return messageHistory.FindAll(ms => ms.MessageType == RadioMessageType.News);
        }

        public IEnumerable<RadioMessage> RadioSavedMusic()
        {
            return messageHistory.FindAll(ms => ms.MessageType == RadioMessageType.Music);
        }

        public void TurnOffRadio()
        {
            station.OnRadioBroadcast += Station_OnRadioBroadcast;
        }

        public void TurnOnRadio()
        {
            station.OnRadioBroadcast -= Station_OnRadioBroadcast;
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
