using System;

namespace Handler
{
    class SpeechInputHandler
    {
        public static void recognizeInput(String input)
        {
            input = input.ToLower();
            Console.WriteLine(input);
            if (input.Contains("licht") && (input.Contains("einschalten") || input.Contains("an") || input.Contains("anschalten")))
            {
                Functions.Light.On();
            }
            else if (input.Contains("licht") && (input.Contains("ausschalten") || input.Contains("aus")))
            {
                Functions.Light.Off();
            }
            else if ((input.Contains("tv") || input.Contains("fernseher")) && (input.Contains("einschalten") || input.Contains("an") || input.Contains("anschalten")))
            {
                Functions.TV.On();
            }
            else if ((input.Contains("tv") || input.Contains("fernseher")) && (input.Contains("ausschalten") || input.Contains("aus")))
            {
                Functions.TV.Off();
            }
            else if (input.Contains("wetterbericht") || input.Contains("welches wetter") || (input.Contains("wie ist") && input.Contains("wetter")) )
            {
                Functions.WeatherCheck.Check();
            }
            if (input.Contains("steckdose") && (input.Contains("einschalten") || input.Contains("an") || input.Contains("anschalten")))
            {
                Functions.Plug.On();
            }
            else if (input.Contains("steckdose") && (input.Contains("ausschalten") || input.Contains("aus")))
            {
                Functions.Plug.Off();
            }
        }
    }
}
