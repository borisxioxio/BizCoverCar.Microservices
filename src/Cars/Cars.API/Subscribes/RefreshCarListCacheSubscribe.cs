using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Cars.API.Caching;
using Cars.API.Events;
using MediatR;
namespace Cars.API.Subscribes
{
    public class RefreshCarListCacheSubscribe : INotificationHandler<RefreshCarListCacheEvent>
    {
        public Task Handle(RefreshCarListCacheEvent notification, CancellationToken cancellationToken)
        {
            MyCacheKeys.GetAllCarsCachingKey = DateTime.Now.ToString();
            return Task.CompletedTask;
        }

        
    }
}
