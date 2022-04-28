using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class WeatherHistory
    {
        public class Current
        {
            public int Dt { get; set; }
            public int Sunrise { get; set; }
            public int Sunset { get; set; }
            public double Temp { get; set; }
            public double Feels_like { get; set; }
            public int Pressure { get; set; }
            public int Humidity { get; set; }
            public double Dew_point { get; set; }
            public double Uvi { get; set; }
            public int Clouds { get; set; }
            public int Visibility { get; set; }
            public double Wind_speed { get; set; }
            public int Wind_deg { get; set; }
            public double Wind_gust { get; set; }
            public List<Weather> Weather { get; set; }
        }

        public class Hourly
        {
            public int Dt { get; set; }
            public double Temp { get; set; }
            public double Feels_like { get; set; }
            public int Pressure { get; set; }
            public int Humidity { get; set; }
            public double Dew_point { get; set; }
            public double Uvi { get; set; }
            public int Clouds { get; set; }
            public int Visibility { get; set; }
            public double Wind_speed { get; set; }
            public int Wind_deg { get; set; }
            public double Wind_gust { get; set; }
            public List<Weather> Weather { get; set; }
        }

        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Timezone { get; set; }
        public int Timezone_offset { get; set; }
        public Current current { get; set; }
        public List<Hourly> hourly { get; set; }
    }
}
