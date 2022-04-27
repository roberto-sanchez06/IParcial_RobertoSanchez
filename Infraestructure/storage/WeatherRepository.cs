using Domain;
using Domain.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.storage
{
    class WeatherRepository : IWeatherRepository
    {
        private RAFContext Context;
        private const int SIZE = 300;
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
            catch (IOException)
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
            catch (IOException)
            {
                throw;
            }
        }
    }
}
