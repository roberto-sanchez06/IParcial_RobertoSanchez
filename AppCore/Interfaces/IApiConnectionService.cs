using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IApiConnectionService
    {
        WeatherConsult GetWeather(string ciudad, long unixtime);
        string GetImage(Weather w);
    }
}
