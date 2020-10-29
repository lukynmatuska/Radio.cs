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
            radioStation.changeModerator("Leos Mares");
            WorldTick();

            BrandNewRadio radio = new BrandNewRadio(radioStation);
            OldGrandmaRadio gRadio = new OldGrandmaRadio(radioStation);

            radio.TurnOnRadio();
            foreach (RadioMessage music in radio.RadioSavedMusic())
            {
                Console.WriteLine(music);
            }

            foreach (RadioMessage news in radio.RadioSavedNews()) {
                Console.WriteLine(news);
            }
            radioStation.changeModerator("Lukyno Bartolino");
            //Console.WriteLine(radioStation.)
            gRadio.TurnOnRadio();
            radioStation.changeModerator("Patrick Netik");
            // radio.TurnOffRadio();
            // gRadio.TurnOffRadio();
            Console.ReadLine();
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
