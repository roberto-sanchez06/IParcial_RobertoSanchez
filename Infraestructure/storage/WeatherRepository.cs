using Domain;
using Domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.storage
{
    class WeatherRepository : IWeatherRepository
    {
        private RAFContext Context;
        private const int SIZE = 300;
        public void Add(Weather t)
        {

        }

        public List<Weather> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
