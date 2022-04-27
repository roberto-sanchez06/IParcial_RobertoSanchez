using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Ciudad;

namespace Domain.interfaces
{
    interface ApiConectionRepos
    {
         City GetWeather(string ciudad);
    }
}
