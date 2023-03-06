using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace WeatherMapAPI;
class Program
{
    static void Main(string[] args)
    {
        var client = new HttpClient();

        var weatherMapULR = "https://api.openweathermap.org/data/2.5/weather?q=Lexington&appid=d87febb8b61e578895f096b3f7ef5a7e&units=imperial";

        var weatherMapResponse = client.GetStringAsync(weatherMapULR).Result;

        var weatherMap = JObject.Parse(weatherMapResponse);

        Console.WriteLine(weatherMap["main"]);
    }
}

