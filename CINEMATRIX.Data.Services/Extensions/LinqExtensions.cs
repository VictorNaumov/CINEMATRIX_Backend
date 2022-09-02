using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CINEMATRIX.Data.Services.Extensions
{
    public static class LinqExtensions
    {
        public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source, string propertyName)
        {
            return source.OrderBy(ToLambda<T>(propertyName));
        }

        public static List<T> OrderBy<T>(this List<T> source, string propertyName)
        {
            return source.OrderBy(o => o.GetType()
                                        .GetProperty(propertyName)
                                        .GetValue(o)).ToList();
        }

        public static IOrderedQueryable<T> OrderByDescending<T>(this IQueryable<T> source, string propertyName)
        {
            return source.OrderByDescending(ToLambda<T>(propertyName));
        }

        public static List<T> OrderByDescending<T>(this List<T> source, string propertyName)
        {
            return source.OrderByDescending(o => o.GetType()
                                        .GetProperty(propertyName)
                                        .GetValue(o)).ToList();
        }

        private static Expression<Func<T, object>> ToLambda<T>(string propertyName)
        {
            var parameter = Expression.Parameter(typeof(T));
            var property = Expression.Property(parameter, propertyName);
            var propAsObject = Expression.Convert(property, typeof(object));

            return Expression.Lambda<Func<T, object>>(propAsObject, parameter);
        }

        public static IQueryable<T> Page<T>(this IQueryable<T> source, int pageSize, int page)
        {
            return source.Skip(page * pageSize).Take(pageSize);
        }
    }
}
