using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IWeatherService : IService<Weather>
    {
        List<Weather> GetWeatherByCity(string city);
    }
}
