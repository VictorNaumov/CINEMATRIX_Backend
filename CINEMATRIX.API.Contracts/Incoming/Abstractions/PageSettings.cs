using System.ComponentModel;

namespace CINEMATRIX.API.Contracts.Incoming.Abstractions
{
    public class PageSettings
    {
        /// <summary>
        ///     Gets the number of items to retrieve.
        /// </summary>
        [DefaultValue(20)]
        public int PageSize { get; set; }

        /// <summary>
        ///     Gets the page that should be retrieved and thus how many items will be skipped.
        /// </summary>
        [DefaultValue(0)]
        public int Page { get; set; }
    }
}
