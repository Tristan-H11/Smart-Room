

namespace Handler
{
    class WeatherHandler
    {
        
        private string city;
        private string temperature;
        //private string temperatureMax;    Abweichung nach oben und unten. Vorerst unwichtig
        //private string temperatureMin;
        private int conditionId;

        public WeatherHandler(string City) //Konstruktor setzt die entsprechende Stadt
        {
            this.city = City;
        }

        //Getter und Setter für alle Variablen
        public string Temperature { get => temperature; set => temperature = value; }
        //public string TempMax { get => temperatureMax; set => temperatureMax = value; }
        //public string TempMin { get => temperatureMin; set => temperatureMin = value; }
        public int ConditionId { get => conditionId; set => conditionId = value; }

        public void CheckWeather()
        {
            WeatherAPI API = new WeatherAPI(city);
            temperature = API.GetTemp();
            //temperatureMax = API.GetTempMax();
            //temperatureMin = API.GetTempMin();
            conditionId = API.GetCondition();
        }
    }
}
