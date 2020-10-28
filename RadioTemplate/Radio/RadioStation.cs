using RadioTemplate.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioTemplate.Radio
{
    public class RadioStation
    {
        public event EventHandler<RadioMessage> OnRadioBroadcast;

        private string currentModerator;

        public RadioStation()
        {
            ;
        }

        public void BroadcastMessage(RadioMessageType messageType, string message)
        {
            if (!hasRadioMoneyToBroadcast())
            {
                // todo throw exception
            }

            // todo invoke event
        }

        private bool hasRadioMoneyToBroadcast()
        {
            Random random = new Random();
            return random.Next(0, 10) == 0;
        }
    }
}
