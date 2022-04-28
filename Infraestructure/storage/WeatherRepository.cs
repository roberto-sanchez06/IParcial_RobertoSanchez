using Domain.Entities;
using Domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.storage
{
    public class WeatherRepository : IWeatherRepository
    {
        private RAFContext Context;
        private const int SIZE = 120;
        public WeatherRepository()
        {
            Context = new RAFContext("weather", SIZE);
        }
        public void Add(Weather t)
        {
            try
            {
                Context.Create<Weather>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Weather> GetAll()
        {
            try
            {
                return Context.GetAll<Weather>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Weather> GetWeatherByCity(string city)
        {
            try
            {
                return Context.Find<Weather>(x=>x.TimeZone==city);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
