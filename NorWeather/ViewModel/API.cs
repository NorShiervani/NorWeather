using Newtonsoft.Json;
using NorWeather.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NorWeather.ViewModel
{
    class API
    {
        public const string WEATHER_API_KEY = "";
        public const string RESOURCE_URL = "http://dataservice.accuweather.com/forecasts/v1/daily/5day/{0}?apikey={1}";

        public async Task<AccuWeather> GetWeatherDataAsync(string locationkey)
        {
            AccuWeather weatherData = new AccuWeather();
            string url = string.Format(RESOURCE_URL, locationkey, WEATHER_API_KEY);

            using(HttpClient client = new HttpClient())
            {
                var apiresponse = await client.GetAsync(url);
                string json = await apiresponse.Content.ReadAsStringAsync();

                weatherData = JsonConvert.DeserializeObject<AccuWeather>(json);
            }

            return weatherData;
        }
    }
}
