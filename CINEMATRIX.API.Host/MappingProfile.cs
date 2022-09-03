using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.TMDB;
using CINEMATRIX.Data.Domain.Models;
using System.Collections.Generic;
using System.Linq;

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

            CreateMap<Profile, ProfileDTO>();
            CreateMap<Profile, FoundProfileDTO>();
            CreateMap<ProfileDTO, Profile>();

            CreateMap<MovieByIdResponse, FoundMovieDTO>()
                .ForMember(dest => dest.Videos, opts => opts.MapFrom(src => src.Videos.Results))
                .ForMember(dest => dest.Images, opts => opts.MapFrom(src => src.Images.Backdrops))
                .ForMember(dest => dest.Credits, opts => opts.MapFrom(src => src.Credits.Crew.Concat(src.Credits.Cast)));

            CreateMap<PersonByIdResponse, FoundPersonDTO>()
                .ForMember(dest => dest.Images, opts => opts.MapFrom(src => src.Images.Profiles))
                .ForMember(dest => dest.Credits, opts => opts.MapFrom(src => src.Credits.Crew.Concat(src.Credits.Cast)));

            CreateMap<PagedMoviesResponse, PagedResponse<FoundMovieDTO>>()
                .ForMember(dest => dest.Items, opts => opts.MapFrom(src => src.Results))
                .ForMember(dest => dest.TotalCount, opts => opts.MapFrom(src => src.TotalResults));

            CreateMap<PagedPeopleResponse, PagedResponse<FoundPersonDTO>>()
                .ForMember(dest => dest.Items, opts => opts.MapFrom(src => src.Results))
                .ForMember(dest => dest.TotalCount, opts => opts.MapFrom(src => src.TotalResults));
        }
    }
}
