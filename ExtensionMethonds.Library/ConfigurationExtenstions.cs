using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace ExtensionMethonds.Library
{
    public static class ConfigurationExtenstions
    {
        public static bool IsLoaded(this IConfiguration config)
        {
            return config !=null && config.AsEnumerable().Any();
        }
    }
}
