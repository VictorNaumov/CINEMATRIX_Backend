namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class ConfirmEmailDTO
    {
        public long UserId { get; set; }
        public string Token { get; set; }
    }
}
