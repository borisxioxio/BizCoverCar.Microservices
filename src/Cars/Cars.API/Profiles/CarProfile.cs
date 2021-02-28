using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BizCover.Repository.Cars;
using Cars.API.Commands;

namespace Cars.API.DTO
{
    public class CarProfile: Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarDto>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.make, opt => opt.MapFrom(src => src.Make))
                .ForMember(dest => dest.model, opt => opt.MapFrom(src => src.Model))
                .ForMember(dest => dest.year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.countryManufactured, opt => opt.MapFrom(src => src.CountryManufactured))
                .ForMember(dest => dest.colour, opt => opt.MapFrom(src => src.Colour))
                .ForMember(dest => dest.price, opt => opt.MapFrom(src => src.Price))
                .ReverseMap();


            CreateMap<Car, AddCarCommand>()
                .ForMember(dest => dest.make, opt => opt.MapFrom(src => src.Make))
                .ForMember(dest => dest.model, opt => opt.MapFrom(src => src.Model))
                .ForMember(dest => dest.year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.countryManufactured, opt => opt.MapFrom(src => src.CountryManufactured))
                .ForMember(dest => dest.colour, opt => opt.MapFrom(src => src.Colour))
                .ForMember(dest => dest.price, opt => opt.MapFrom(src => src.Price))
                .ReverseMap();

        }
    }
}
