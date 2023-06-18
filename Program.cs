using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace WeatherApp
{
    class Program
    {
        public static void Main(string[] args) 
        {
            var client = new HttpClient();

            var key = "";
            var city = " Los Angeles ";

            var weatherURL = $"https://openweathermap.org/city/5368361";
            var response = client.GetAsync(weatherURL).Result;
        }
    }
}