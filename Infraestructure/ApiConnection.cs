using Common;
using Domain.Entities;
using Domain.interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Domain.Ciudad;

namespace Infraestructure
{
    public class ApiConnection : IApiConnection
    {
        public WeatherHistory GetWeather(string ciudad, long unixtime)
        {
            List<City> city = GetCoord(ciudad);
            using (WebClient web = new WebClient())
            {
                //string url = $"{AppSettings.ApiUrl}{city.First().Lat}&lon={city.First().Lon}&dt={unixtime}&appid={AppSettings.Token}";
                string url = $"{AppSettings.ApiUrl}{city.First().Lat}&lon={city.First().Lon}&dt={unixtime}&appid={AppSettings.Token}&units={AppSettings.Unit}&lang=es";
                //string url = $"http://api.openweathermap.org/data/2.5/onecall/timemachine?lat=60.99&lon=30.9&dt={unixtime}&appid=0f995113ea7931bbc41724930f2ae37e";
                var json = web.DownloadString(url);
                WeatherHistory w =JsonConvert.DeserializeObject<WeatherHistory>(json);
                return w;
            }
        }
        public List<City> GetCoord(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = $"{AppSettings.ApiGeocoding}{city}&limit=1&appid={AppSettings.Token}";
                var json = web.DownloadString(url);
                return JsonConvert.DeserializeObject<List<City>>(json);
            }
        }
        public string GetImage(Weather w)
        {
            string imageLocation = $"{AppSettings.ImageLocation}{w.Icon}.png";
            return imageLocation;
        }
    }
}
