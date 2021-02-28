using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.API.Caching
{
    public static class MyCacheKeys
    {
        public static string GetAllCarsCachingKey { get; set; } = DateTime.Now.ToString();
    }
}
