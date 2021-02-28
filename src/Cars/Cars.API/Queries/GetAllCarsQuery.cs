using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.API.Caching;
using Cars.API.DTO;
using MediatR;

namespace Cars.API.Queries
{
    public class GetAllCarsQuery : IRequest<List<CarDto>>, ICacheable
    {
        public string CacheKey => MyCacheKeys.GetAllCarsCachingKey;

    }
}
