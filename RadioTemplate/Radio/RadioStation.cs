using RadioTemplate.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioTemplate.Radio
{
    public class RadioStation
    {
        public event EventHandler<RadioMessage> OnRadioBroadcast;
        public event EventHandler<string> OnModeratorChange;

        private string currentModerator;

        public RadioStation()
        {
            ;
        }

        public void changeModerator(string newModerator)
        {
            currentModerator = newModerator;
            OnModeratorChange?.Invoke(this, currentModerator);
        }

        public void BroadcastMessage(RadioMessageType messageType, string message)
        {
            if (!hasRadioMoneyToBroadcast())
            {
                throw new RadioBankruptException();
            }

            if (currentModerator == null)
            {
                throw new RadioNoModeratorException();
            }

            OnRadioBroadcast?.Invoke(this, new RadioMessage(messageType, message, currentModerator));
        }

        private bool hasRadioMoneyToBroadcast()
        {
            Random random = new Random();
            return random.Next(0, 10) == 0;
        }
    }
}
