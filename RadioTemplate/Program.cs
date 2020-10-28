using RadioTemplate.Radio;
using RadioTemplate.RadioDevice;
using System;
using System.Threading.Tasks;

namespace RadioTemplate
{
    public class Program
    {
        private static RadioStation radioStation = new RadioStation();

        public static async Task Main(string[] args)
        {
            radioStation.changeModerator("Leos Mares");

            BrandNewRadio radio = new BrandNewRadio(radioStation);
            OldGrandmaRadio gRadio = new OldGrandmaRadio(radioStation);

            radio.TurnOnRadio();
            radioStation.changeModerator("Lukyno Bartolino");
            gRadio.TurnOnRadio();
            radioStation.changeModerator("Patrick Netik");
            // radio.TurnOffRadio();
            // gRadio.TurnOffRadio();
            await WorldTick();
        }

        private static void RadioBroadcast()
        {
            try
            {
                Random random = new Random();

                RadioMessageType messageType = (RadioMessageType)random.Next(0, 3);

                switch (messageType)
                {
                    case RadioMessageType.Music: radioStation.BroadcastMessage(messageType, "Macky Gee - Tour"); break;
                    case RadioMessageType.News: radioStation.BroadcastMessage(messageType, "Covidem už jsou nakaženi úplně všichni!"); break;
                    case RadioMessageType.Ads: radioStation.BroadcastMessage(messageType, "Navštěvuje Vaše žena souseda příliš často? Kupte modré tablety za pouhých 99,- *vedlejší účinky zanedbatelné... Radim Uzel doporučuje."); break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region ignore
        private static async Task WorldTick()
        {
            while (true)
            {
                RadioBroadcast();
                Console.WriteLine("Radio broadcasted!");
                await Task.Delay(1000);
            }
        }
        #endregion
    }
}
