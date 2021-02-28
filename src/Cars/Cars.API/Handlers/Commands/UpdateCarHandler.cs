using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using BizCover.Repository.Cars;
using Cars.API.Commands;
using Cars.API.DTO;
using Cars.API.Events;
using Cars.API.Queries;
using Cars.Data;
using MediatR;
namespace Cars.API.Handlers.Commands
{
    public class UpdateCarHandler : IRequestHandler<UpdateCarCommand, UpdateCarResponse>
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;
        public UpdateCarHandler(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        public async Task<UpdateCarResponse> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {

            GetAllCarsQuery getAllCarsQuery = new GetAllCarsQuery();
            List<CarDto> cars = await mediator.Send<List<CarDto>>(getAllCarsQuery);
            bool hasCar = cars.Exists(r => r.id == request.id);
            if (hasCar)
            {
                Car car = mapper.Map<Car>(request);
                try
                {
                    await BizCoverHelper.UpdateCar(car);
                    await mediator.Publish(new RefreshCarListCacheEvent());
                    return new UpdateCarResponse
                    {
                        Success = true
                    };
                }
                catch
                {
                    return new UpdateCarResponse
                    {
                        Success = false
                    };
                }
            }
            else
            {
                return new UpdateCarResponse
                {
                    Success = false,
                    Message = "Car is not exisiting"
                };
            }
            
           
        }
    }
}
