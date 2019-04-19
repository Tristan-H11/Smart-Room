using System;
using System.Speech.Recognition;

namespace Smart_Room
{
    class Program
    {
        static void Main()
        {
            Handler.SpeechInputHandler SpeechInputHandler = new Handler.SpeechInputHandler();
            
            //Spracherkennung auf Deutsch stellen
            using (
            SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("de-DE")))
            {


                // Grammar  
                recognizer.LoadGrammar(new DictationGrammar());

                // Sprach event handler hinzufügen
                recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                // default mikrofon 
                recognizer.SetInputToDefaultAudioDevice();

                // Asynchron erkennen 
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                // Konsole offen lassen
                while (true)
                {
                    Console.ReadLine();
                }
            }
        }

        // Spracherkennungsevent 
        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            Console.WriteLine("Recognized text: " + e.Result.Text);

            Handler.SpeechInputHandler.recognizeInput(e.Result.Text); //Erkannten Text an den SpeechInputHandler weitergeben
        }
    }
}