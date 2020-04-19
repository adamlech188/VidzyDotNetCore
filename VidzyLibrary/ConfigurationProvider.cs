﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace VidzyApp
{
    public static class AppConfigurationProvider
    {
        public static IConfiguration BuildConfigurtions()
        {
            return new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
        }
    }
}
