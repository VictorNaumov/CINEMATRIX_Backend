using System;

namespace CINEMATRIX.API.Contracts.IncomingOutgoing
{
    public class MovieCommentDTO
    {
        public long? ParentCommentId { get; set; }
        public long MovieId { get; set; }
        public long ProfileId { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
