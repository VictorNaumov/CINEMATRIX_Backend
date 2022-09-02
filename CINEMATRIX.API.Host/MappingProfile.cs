using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.TMDB;
using CINEMATRIX.Data.Domain.Models;

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

            CreateMap<MovieByIdResponse, FoundMovieDTO>()
                .ForMember(dest => dest.Videos, opts => opts.MapFrom(src => src.Videos.Results))
                .ForMember(dest => dest.Images, opts => opts.MapFrom(src => src.Images.Backdrops));

            CreateMap<PagedMoviesResponse, PagedResponse<FoundMovieDTO>>()
                .ForMember(dest => dest.Items, opts => opts.MapFrom(src => src.Results))
                .ForMember(dest => dest.TotalCount, opts => opts.MapFrom(src => src.TotalResults));
        }
    }
}
