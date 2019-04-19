using System;
using System.Speech.Synthesis;

namespace Handler
{
    class SpeechOutputHandler
    {
        static SpeechSynthesizer synth = new SpeechSynthesizer();
        
        public static void Say(String text, int vol =60)
        {
            Console.WriteLine("Output:  " + text);
            synth.Volume = vol;
            synth.SpeakAsync(text);
        }
    }
}
