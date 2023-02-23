using CINEMATRIX.API.Contracts.IncomingOutgoing;
using CINEMATRIX.API.Contracts.Outgoing;
using CINEMATRIX.API.Contracts.Outgoing.Abstractions;
using CINEMATRIX.API.Contracts.Outgoing.TMDB;
using CINEMATRIX.Data.Domain.Models;
using System.Linq;

namespace CINEMATRIX.API.Host
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {

            #region DatabaseMapping
            CreateMap<Cinema, CinemaDTO>().ReverseMap();
            CreateMap<Cinema, FoundCinemaDTO>();

            CreateMap<Food, FoodDTO>().ReverseMap();
            CreateMap<Food, FoundFoodDTO>();

            CreateMap<Hall, HallDTO>().ReverseMap();
            CreateMap<Hall, FoundHallDTO>();

            CreateMap<Profile, ProfileDTO>().ReverseMap();
            CreateMap<Profile, FoundProfileDTO>();

            CreateMap<Seat, SeatDTO>().ReverseMap();
            CreateMap<Seat, FoundSeatDTO>();

            CreateMap<SeatType, SeatTypeDTO>().ReverseMap();
            CreateMap<SeatType, FoundSeatTypeDTO>();

            CreateMap<Session, SessionDTO>().ReverseMap();
            CreateMap<Session, FoundSessionDTO>();

            CreateMap<Ticket, TicketDTO>().ReverseMap();
            CreateMap<Ticket, FoundTicketDTO>();

            CreateMap<FAQ, FAQDTO>().ReverseMap();
            CreateMap<FAQ, FoundFAQDTO>();

            CreateMap<Profile, ProfileDTO>();
            CreateMap<Profile, FoundProfileDTO>();
            CreateMap<ProfileDTO, Profile>();

            CreateMap<FavoriteMovie, FavoriteMovieDTO>();
            CreateMap<FavoriteMovie, FoundFavoriteMovieDTO>();
            CreateMap<FavoriteMovieDTO, FavoriteMovie>();

            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, FoundUserDTO>();

            CreateMap<MovieComment, MovieCommentDTO>().ReverseMap();
            CreateMap<MovieComment, FoundMovieCommentDTO>();
            #endregion

            #region TMDBMapping

            //TMDB
            CreateMap<MovieCreditResponse, FoundMovieCreditDTO>().ReverseMap();
            CreateMap<MovieDetailByIdResponse, FoundMovieDTO>().ReverseMap();
            CreateMap<MovieResponse, FoundMovieDTO>().ReverseMap();
            CreateMap<PersonCreditResponse, FoundPersonCreditDTO>().ReverseMap();
            CreateMap<PersonDetailByIdResponse, FoundPersonCreditDTO>().ReverseMap();
            CreateMap<ImageResponse, FoundImageDTO>().ReverseMap();
            CreateMap<VideoResponse, FoundVideoDTO>().ReverseMap();

            CreateMap<MovieDetailByIdResponse, FoundMovieDTO>()
                .ForMember(dest => dest.Videos, opts => opts.MapFrom(src => src.Videos.Results))
                .ForMember(dest => dest.Images, opts => opts.MapFrom(src => src.Images.Backdrops))
                .ForMember(dest => dest.Credits, opts => opts.MapFrom(src => src.Credits.Crew.Concat(src.Credits.Cast)));

            CreateMap<PersonDetailByIdResponse, FoundPersonDTO>()
                .ForMember(dest => dest.Images, opts => opts.MapFrom(src => src.Images.Profiles))
                .ForMember(dest => dest.Credits, opts => opts.MapFrom(src => src.Credits.Crew.Concat(src.Credits.Cast)));

            CreateMap<PagedMoviesResponse, PagedResponse<FoundMovieDTO>>()
                .ForMember(dest => dest.Items, opts => opts.MapFrom(src => src.Results))
                .ForMember(dest => dest.TotalCount, opts => opts.MapFrom(src => src.TotalResults));

            CreateMap<PagedPeopleResponse, PagedResponse<FoundPersonDTO>>()
                .ForMember(dest => dest.Items, opts => opts.MapFrom(src => src.Results))
                .ForMember(dest => dest.TotalCount, opts => opts.MapFrom(src => src.TotalResults));

            #endregion
        }
    }
}
