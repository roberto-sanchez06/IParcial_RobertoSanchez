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
        public void Add(WeatherConsult t)
        {
            try
            {
                //if (Context.Find<WeatherHistory>(x => x.Equals(t)).Count > 0)
                //{
                //    throw new Exception();
                //}
                Context.Create<WeatherConsult>(t);
            }
            catch (IOException)
            {
                throw;
            }
        }

        public List<WeatherConsult> GetAll()
        {
            try
            {
                return Context.GetAll<WeatherConsult>();
            }
            catch (IOException)
            {
                throw;
            }
        }
    }
}
