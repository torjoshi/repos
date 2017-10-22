using System;
using System.Collections.Generic;
using System.Linq;

namespace UsefulLibrary
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Has more than one elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool HasMany<T>(this IEnumerable<T> source) => source?.Take(1).Any() ?? false;

        /// <summary>
        /// HasMany matching a predicate.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>

        public static bool HasMany<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            //Add check for the predicate.
            return HasMany(source.Where(e => predicate(e)));
        }
    }
}