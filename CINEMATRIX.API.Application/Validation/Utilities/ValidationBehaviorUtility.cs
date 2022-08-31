using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CINEMATRIX.API.Application.Validation.Utilities
{
    public static class ValidationBehaviorUtility
    {
        public static async Task<IEnumerable<T>> WhenAll<T>(this IEnumerable<Task<T>> tasks)
        {
            return await Task.WhenAll(tasks);
        }
    }
}
