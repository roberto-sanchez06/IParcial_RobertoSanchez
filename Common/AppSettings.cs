﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class AppSettings
    {
        public static string ApiUrl { get => ConfigurationManager.AppSettings.Get("ApiUrl"); }
        public static string Token { get => ConfigurationManager.AppSettings.Get("Token"); }
        public static string Unit { get => ConfigurationManager.AppSettings.Get("Units"); }
        public static string ApiGeocoding { get => ConfigurationManager.AppSettings.Get("ApiGeocoding"); }
        public static string ImageLocation { get => ConfigurationManager.AppSettings.Get("ImageLocation"); }
    }
}
