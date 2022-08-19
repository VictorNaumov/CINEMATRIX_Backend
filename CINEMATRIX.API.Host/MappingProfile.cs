using AutoMapper;
using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Domain.Models;

namespace CINEMATRIX.API.Host
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Food, FoodDTO>();
            CreateMap<Food, FoundFoodDTO>();
            CreateMap<FoodDTO, Food>();

            CreateMap<SeatType, SeatTypeDTO>();
            CreateMap<SeatType, FoundSeatTypeDTO>();
            CreateMap<SeatTypeDTO, SeatType>();
        }
    }
}
