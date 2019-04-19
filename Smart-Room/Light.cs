using System;
namespace Functions
{
    class Light
    {
        public static void On()
        {
            Handler.SpeechOutputHandler.Say("Du schaltest das Licht ein");
            Console.WriteLine("Licht");
        }
        //Später Rückgabewerte true und false als Rückmeldung. GGf spezielle Lampen ansprechen?
        //Wenn keine spezielle Lampe angesprochen, alle anschalten
        public static void Off()
        {
            Handler.SpeechOutputHandler.Say("Du schaltest das Licht aus");
        }
    }
}
