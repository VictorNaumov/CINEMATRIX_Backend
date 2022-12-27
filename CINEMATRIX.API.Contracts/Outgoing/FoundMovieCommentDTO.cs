using System;
using System.Collections.Generic;

namespace CINEMATRIX.API.Contracts.Outgoing
{
    public class FoundMovieCommentDTO
    {
        public long? ParentCommentId { get; set; }
        public long MovieId { get; set; }
        public long ProfileId { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsDeleted { get; set; }
        public FoundProfileDTO Profile { get; set; }
        public FoundMovieCommentDTO ParentComment { get; set; }
        public ICollection<FoundMovieCommentDTO> Replies { get; set; }
    }
}
