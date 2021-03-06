using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.interfaces
{
    public interface IWeatherRepository : IRepository<Weather>
    {
        List<Weather> GetWeatherByCity(string city);
    }
}
