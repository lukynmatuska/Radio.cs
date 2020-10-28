using RadioTemplate.Radio;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioTemplate.RadioDevice
{
    public class OldGrandmaRadio : IRadioDevice
    {
        private RadioStation station;

        public OldGrandmaRadio(RadioStation station)
        {
            this.station = station;
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
            // todo radio listen logic

            throw new NotImplementedException();
        }
    }
}
