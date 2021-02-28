using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Cars.API.Caching;
using MediatR;
using Microsoft.Extensions.Caching.Memory;

namespace Cars.API.Behaviors
{
    public class CachingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : ICacheable
    {
        private readonly IMemoryCache cache;
        public CachingBehaviour(IMemoryCache cache)
        {
            this.cache = cache;
        }
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var requestName = request.GetType();

            // Check to see if the item is inside the cache
            TResponse response;
            if (cache.TryGetValue(request.CacheKey, out response))
            {
                return response;
            }

            // Item is not in the cache, execute request and add to cache
            response = await next();
            cache.Set(request.CacheKey, response);
            return response;
        }
    }
}
