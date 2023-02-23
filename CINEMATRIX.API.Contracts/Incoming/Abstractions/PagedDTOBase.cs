using System.ComponentModel;

namespace CINEMATRIX.API.Contracts.Incoming.Abstractions
{
    public class PagedDTOBase : PageSettings
    {
        /// <summary>
        ///     Gets the direction in which the result should be sorted (asc or desc). Prefer <c>ListSortDirection</c> for
        ///     type-safety.
        /// </summary>
        [DefaultValue("asc")]
        public string SortDirection { get; set; } = "asc";

        /// <summary>
        ///     Gets the property on which the result should be sorted.
        /// </summary>
        [DefaultValue("id")]
        public string SortProperty { get; set; } = "id";
    }
}
