using System.Net;
using System.Xml;

namespace Handler
{
    class WeatherAPI
    {
        /*************************
         * Abruf der Wetterdaten *
         *************************/

        private const string APIKEY = "secret"; //OpenWeatherMap API Key
        private string CurrentURL; //URL um später XML abzurufen
        private XmlDocument xmlDocument;
        public WeatherAPI(string city) //Konstruktor setzt die Stadt für die URL
        {
            SetCurrentURL(city);
            xmlDocument = GetXML(CurrentURL);
        }

        private void SetCurrentURL(string Loc) // URL mit Stadt und Key kombinieren
        {
            CurrentURL = "http://api.openweathermap.org/data/2.5/weather?id="
                        + Loc + "&mode=xml&units=metric&APPID=" + APIKEY;

        }

        private XmlDocument GetXML(string CurrentURL) //XML herunterladen und speichern
        {
            using (var webClient = new WebClient())
            {
                var xmlContent = webClient.DownloadString(CurrentURL);
                var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlContent);
                return xmlDocument;
            }
        }

        /***********************
         * Wetterdatenrückgabe *
         ***********************/

        public int GetCondition()
        {
            XmlNode temp_node = xmlDocument.SelectSingleNode("//weather");
            XmlAttribute temp_value = temp_node.Attributes["number"];
            return int.Parse(temp_value.Value);
        }

        public string GetTemp()
        {
            XmlNode temp_node = xmlDocument.SelectSingleNode("//temperature");
            XmlAttribute temp_value = temp_node.Attributes["value"];
            return temp_value.Value;
        }

        /*public string GetTempMax()
        {
            XmlNode temp_node = xmlDocument.SelectSingleNode("//temperature");
            XmlAttribute temp_value = temp_node.Attributes["max"];
            return temp_value.Value;
        }

        public string GetTempMin()
        {
            XmlNode temp_node = xmlDocument.SelectSingleNode("//temperature");
            XmlAttribute temp_value = temp_node.Attributes["max"];
            return temp_value.Value;
        }*/
    }
}
