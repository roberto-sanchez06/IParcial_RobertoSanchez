using AppCore.Interfaces;
using Domain.Entities;
using Domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class ApiConnectionService : IApiConnectionService
    {
        private IApiConnection connection;

        public ApiConnectionService(IApiConnection connection)
        {
            this.connection = connection;
        }

        public string GetImage(Weather w)
        {
            return connection.GetImage(w);
        }

        public WeatherConsult GetWeather(string ciudad, long unixtime)
        {
            return connection.GetWeather(ciudad, unixtime);
        }
    }
}
