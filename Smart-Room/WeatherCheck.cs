namespace Functions
{
    class WeatherCheck
    {
        private static string Temperature = "0";
        private static int id;
        private const string id_zuhause = "secret";
        private static string Gewitter = $"Aktuell gewittert es bei {Temperature} Grad Celsius";
        private static string Nieseln = $"Aktuell nieselt es bei {Temperature} Grad Celsius";
        private static string Regen = $"Aktuell regnet es bei {Temperature} Grad Celsius";
        private static string Schnee = $"Aktuell schneit es bei {Temperature} Grad Celsius";
        private static string Klar = $"Das Wetter ist Klar. Die Temperatur beträgt" + Temperature + "Grad Celsius";
        private static string W11 = $"Das Wetter weist aktuell einen Bewölkungsgrad von 11 bis 24 % auf. Die Temperatur beträgt {Temperature} Grad Celsius";
        private static string W25 = $"Das Wetter weist aktuell einen Bewölkungsgrad von 25 bis 50 % auf. Die Temperatur beträgt {Temperature} Grad Celsius";
        private static string W51 = $"Das Wetter weist aktuell einen Bewölkungsgrad von 51 bis 84 % auf. Die Temperatur beträgt {Temperature} Grad Celsius";
        private static string W85 = $"Das Wetter weist aktuell einen Bewölkungsgrad von 85 bis 100 % auf. Die Temperatur beträgt {Temperature} Grad Celsius";

        public static void Check() //Parameter später Datum/Uhrzeit. Ort festgelegt auf Zuhause
        {
            
            Handler.WeatherHandler handler = new Handler.WeatherHandler(id_zuhause);
            handler.CheckWeather();
            Temperature = handler.Temperature;
            id = handler.ConditionId;
            System.Console.WriteLine(Temperature);

            if (200 <= id && id <= 232) Handler.SpeechOutputHandler.Say(Gewitter);

            else if (300 <= id && id <= 321) Handler.SpeechOutputHandler.Say(Nieseln);

            else if (500 <= id && id <= 531) Handler.SpeechOutputHandler.Say(Regen);

            else if (600 <= id && id <= 622) Handler.SpeechOutputHandler.Say(Schnee);

            else if (id == 800) Handler.SpeechOutputHandler.Say(Klar);

            else if (id == 801) Handler.SpeechOutputHandler.Say(W11);

            else if (id == 802) Handler.SpeechOutputHandler.Say(W25);

            else if (id == 803) Handler.SpeechOutputHandler.Say(W51);

            else if (id == 804) Handler.SpeechOutputHandler.Say(W85);



        }
    }
}
