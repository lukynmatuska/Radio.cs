using RadioTemplate.Radio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioTemplate.RadioDevice
{
    public class BrandNewRadio : IRadioDevice
    {
        private List<RadioMessage> messageHistory;

        public BrandNewRadio(RadioStation radioStation)
        {
            ;
        }

        public IEnumerable<RadioMessage> RadioSavedNews()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RadioMessage> RadioSavedMusic()
        {
            throw new NotImplementedException();
        }

        public void TurnOffRadio()
        {
            throw new NotImplementedException();
        }

        public void TurnOnRadio()
        {
            throw new NotImplementedException();
        }
    }
}
