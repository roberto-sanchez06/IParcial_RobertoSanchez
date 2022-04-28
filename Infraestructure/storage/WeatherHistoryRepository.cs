using Domain;
using Domain.Entities;
using Domain.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.storage
{
    public class WeatherHistoryRepository : IWeatherHistoryRepository
    {
        private RAFContext Context;
        private const int SIZE = 300;
        public WeatherHistoryRepository()
        {
            Context = new RAFContext("weatherHistory", SIZE);
        }
        public void Add(WeatherHistory t)
        {
            try
            {
                Context.Create<WeatherHistory>(t);
            }
            catch (IOException)
            {
                throw;
            }
        }

        public List<WeatherHistory> GetAll()
        {
            try
            {
                return Context.GetAll<WeatherHistory>();
            }
            catch (IOException)
            {
                throw;
            }
        }
    }
}
