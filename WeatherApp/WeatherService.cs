using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace WinFormsApp
{
    public class WeatherService
    {
        private readonly string _apiKey;

        public WeatherService(string apiKey)
        {
            _apiKey = apiKey;
        }

        public WeatherData GetWeather(string city)
        {

            var client = new RestClient("https://api.openweathermap.org/data/2.5/");

            // Создаем запрос (GET /weather)
            var request = new RestRequest("weather", Method.Get);

            // Добавляем параметры:
            request.AddParameter("q", city);             // Город
            request.AddParameter("appid", _apiKey);     // API-ключ
            request.AddParameter("units", "metric");    // Градусы Цельсия
            request.AddParameter("lang", "ru");         // Язык ответа



            // Отправляем запрос и получаем ответ
            var response = client.Execute(request);


            if (response.IsSuccessful)
            {

                return JsonConvert.DeserializeObject<WeatherData>(response.Content);
            }
            throw new Exception($"Ошибка: {response.StatusCode} - {response.ErrorMessage}");
        }
    }
    public class WeatherData
    {
        public MainData Main { get; set; }
        public Weather[] Weather { get; set; }
        public string Name { get; set; }
    }

    public class MainData//температура и влажность
    {
        public float Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class Weather//город и описание погоды
    {
        public string Main { get; set; }
        public string Description { get; set; }
    }


}
