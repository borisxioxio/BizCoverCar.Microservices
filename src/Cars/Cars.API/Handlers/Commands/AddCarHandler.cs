using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BizCover.Repository.Cars;
using Cars.API.Commands;
using Cars.API.Events;
using Cars.Data;
using MediatR;
namespace Cars.API.Handlers.Commands
{
    public class AddCarHandler : IRequestHandler<AddCarCommand, AddCarResponse>
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public AddCarHandler(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        public async Task<AddCarResponse> Handle(AddCarCommand request, CancellationToken cancellationToken)
        {
            Car car = mapper.Map<Car>(request);
            try
            {
                var Id = await BizCoverHelper.AddCar(car);
                await mediator.Publish(new RefreshCarListCacheEvent());
                return new AddCarResponse
                {
                    Success = true,
                    Id = Id
                };
            }
            catch
            {
                return new AddCarResponse
                {
                    Success = false
                };
            }
        }
    }
}
