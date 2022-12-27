namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundFavoriteMovieDTO
    {
        public long Id { get; set; }
        public long ProfileId { get; set; }
        public long MovieId { get; set; }
        public int Rating { get; set; }
        public FoundProfileDTO Profile { get; set; }
        public FoundMovieDTO Movie { get; set; }
    }
}
