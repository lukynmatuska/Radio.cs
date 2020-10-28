using RadioTemplate.Radio;
using RadioTemplate.RadioDevice;
using System;
using System.Threading.Tasks;

namespace RadioTemplate
{
    public class Program
    {
        private static RadioStation radioStation = new RadioStation();

        public static void Main(string[] args)
        {
            WorldTick();

            BrandNewRadio radio = new BrandNewRadio(radioStation);

            // todo logika radia
        }

        private static void RadioBroadcast()
        {
            // todo try catch blok

            Random random = new Random();

            RadioMessageType messageType = (RadioMessageType)random.Next(0, 3);

            switch (messageType)
            {
                case RadioMessageType.Music: radioStation.BroadcastMessage(messageType, "Macky Gee - Tour"); break;
                case RadioMessageType.News: radioStation.BroadcastMessage(messageType, "Covidem už jsou nakaženi úplně všichni!"); break;
                case RadioMessageType.Ads: radioStation.BroadcastMessage(messageType, "Navštěvuje Vaše žena souseda příliš často? Kupte modré tablety za pouhých 99,- *vedlejší účinky zanedbatelné... Radim Uzel doporučuje."); break;
            }
        }

        #region ignore
        private static async void WorldTick()
        {
            while (true)
            {
                RadioBroadcast();
                await Task.Delay(1000);
            }
        }
        #endregion
    }
}
