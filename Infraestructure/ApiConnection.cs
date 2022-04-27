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
        //private double lon;
        //private double lat;
        public WeatherForecast GetWeather(string ciudad, long unixtime)
        {
            List<City> city = GetCoord(ciudad);
            using (WebClient web = new WebClient())
            {
                //string url = $"{AppSettings.ApiUrl}{city.Lat}&lon={city.Lon}&dt={unixtime}&appid={AppSettings.Token}";
                string url = $"{AppSettings.ApiUrl}{city.First().Lat}&lon={city.First().Lon}&dt={unixtime}&appid={AppSettings.Token}&units={AppSettings.Unit}";
                var json = web.DownloadString(url);
                WeatherForecast w =JsonConvert.DeserializeObject<WeatherForecast>(json);
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
    }
}
