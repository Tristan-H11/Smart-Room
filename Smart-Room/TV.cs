namespace Functions
{
    class TV
    {
        public static void On()
        {
            Handler.SpeechOutputHandler.Say("Du schaltest den Fernseher an");
            //TV einschalten, Samsung wifi?
        }
        public static void Off()
        {
            Handler.SpeechOutputHandler.Say("Du schaltest den Fernseher aus");
            //obvious
        }
    }
}
