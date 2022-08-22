using System;
using System.Collections.Generic;
using System.Linq;

namespace CINEMATRIX.API.Application.Queries.Extensions
{
    public static class QueryFilterExtensions
    {
        public static string[] GetFilterValues(this IEnumerable<string> values)
        {
            return values == null
                ? Array.Empty<string>()
                : values.Select(v => v.ToUpper().Trim()).Distinct().ToArray();
        }
    }
}
