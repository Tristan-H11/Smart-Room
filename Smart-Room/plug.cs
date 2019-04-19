namespace Functions
{
    class Plug
    {
        public static void On()
        {
            Handler.SpeechOutputHandler.Say("Du schaltest die Funksteckdose ein");
        }
        //Später Rückgabewerte true und false als Rückmeldung. 
        public static void Off()
        {
            Handler.SpeechOutputHandler.Say("Du schaltest die Funksteckdose aus");
        }
    }
}
