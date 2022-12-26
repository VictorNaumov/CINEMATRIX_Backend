﻿using System;
using System.Collections.Generic;

namespace CINEMATRIX.Data.Domain.Models
{
    public class MovieComment : KeyedEntityBase
    {
        public long? ParentCommentId { get; set; }
        public long MovieId { get; set; }
        public long UserId { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsDeleted { get; set; }
        public User User { get; set; }
        public MovieComment ParentComment { get; set; }
        public ICollection<MovieComment> Replies { get; set; }
    }
}
