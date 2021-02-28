using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BizCover.Repository.Cars;
using Cars.API.Queries;
using Cars.Data;
using MediatR;
using AutoMapper;
using Cars.API.DTO;

namespace Cars.API.Handlers.Queries
{
    public class GetAllCarsHandler : IRequestHandler<GetAllCarsQuery, List<CarDto>>
    {
        private readonly IMapper _mapper;
        
        public GetAllCarsHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<List<CarDto>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            List<Car> cars = await BizCoverHelper.GetAllCars();
            return  _mapper.Map<List<CarDto>>(cars);
        }
    }
}
