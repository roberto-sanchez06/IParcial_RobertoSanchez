using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Domain.Ciudad;

namespace Infraestructure
{
    public class HttpApiConection
    {
        public City GetWeather(string ciudad)
        {
            using (WebClient web = new WebClient())
            {
                string url = $"{AppSettings.ApiUrl}{ciudad}&appid={AppSettings.Token}";
                var json = web.DownloadString(url);
                return JsonConvert.DeserializeObject<City>(json);
            }
        }
    }
}
