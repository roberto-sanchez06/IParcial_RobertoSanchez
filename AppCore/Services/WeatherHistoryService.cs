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
    public class WeatherHistoryService : IWeatherHistoryService
    {
        private IWeatherHistoryRepository WeatherHistory;

        public WeatherHistoryService(IWeatherHistoryRepository weatherHistory)
        {
            WeatherHistory = weatherHistory;
        }

        public void Add(WeatherConsult t)
        {
            WeatherHistory.Add(t);
        }

        public List<WeatherConsult> GetAll()
        {
            return WeatherHistory.GetAll();
        }
    }
}
