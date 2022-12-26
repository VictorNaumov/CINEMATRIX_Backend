
using CINEMATRIX.API.Contracts.Incoming.Abstractions;
using System;
using System.ComponentModel;

namespace CINEMATRIX.API.Contracts.Incoming.SearchConditions
{
    public class MovieCommentSearchCondition : PagedDTOBase
    {
        public long[] ParentCommentIds { get; set; }
        public long[] MovieIds { get; set; }
        public long[] UserIds { get; set; }
        public string[] Text { get; set; }
        public DateTime StartDateTime { get; set; } = DateTime.MinValue;
        public DateTime EndDateTime { get; set; } = DateTime.MaxValue;
        public bool IsDeleted { get; set; }
    }
}
