namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class FavoriteMovieDTO
    {
        public long ProfileId { get; set; }
        public long MovieId { get; set; }
        public int Rating { get; set; }
    }
}
