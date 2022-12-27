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

        public static string GetSortProperty(this Type type, string inputPropertyName)
        {
            var properties = type.GetProperties().ToList();
            var propertyNames = properties.Select(p => p.Name.ToString()).ToList();
            inputPropertyName = inputPropertyName.Trim().ToLowerInvariant();

            var result = propertyNames.FirstOrDefault(pn => pn.Trim().ToLowerInvariant().Equals(inputPropertyName)) ??
                         propertyNames.FirstOrDefault(pn => pn.Trim().ToLowerInvariant().Equals("id")) ??
                         propertyNames.FirstOrDefault();

            return result;
        }
    }
}
