using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.Data.Domain.Models;
using CINEMATRIX.Data.Domain.Models.TMDB;

namespace CINEMATRIX.API.Host
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<Food, FoodDTO>();
            CreateMap<Food, FoundFoodDTO>();
            CreateMap<FoodDTO, Food>();

            CreateMap<SeatType, SeatTypeDTO>();
            CreateMap<SeatType, FoundSeatTypeDTO>();
            CreateMap<SeatTypeDTO, SeatType>();

            CreateMap<Data.Domain.Models.Profile, ProfileDTO>();
            CreateMap<Data.Domain.Models.Profile, FoundProfileDTO>();
            CreateMap<ProfileDTO, Data.Domain.Models.Profile>();

            CreateMap<Genre, FoundGenreDTO>();
        }
    }
}
