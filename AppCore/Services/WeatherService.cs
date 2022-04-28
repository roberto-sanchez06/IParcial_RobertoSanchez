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
    public class WeatherService : IWeatherService
    {
        private IWeatherRepository weatherRepository;

        public WeatherService(IWeatherRepository weatherRepository)
        {
            this.weatherRepository = weatherRepository;
        }

        public void Add(Weather t)
        {
            weatherRepository.Add(t);
        }

        public List<Weather> GetAll()
        {
            return weatherRepository.GetAll();
        }

        public List<Weather> GetWeatherByCity(string city)
        {
            return weatherRepository.GetWeatherByCity(city);
        }
    }
}
