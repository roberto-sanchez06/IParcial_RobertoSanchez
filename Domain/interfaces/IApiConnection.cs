using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Ciudad;

namespace Domain.interfaces
{
    public interface IApiConnection
    {
        WeatherConsult GetWeather(string ciudad, long unixtime);
        string GetImage(Weather w);
    }
}
