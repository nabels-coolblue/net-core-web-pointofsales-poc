using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_core_web_pointofsales_poc.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<IEnumerable<T>> Split<T>(this List<T> enumerable, int size)
        {
            for (var i = 0; i < (float)enumerable.Count / size; i++)
            {
                yield return enumerable.Skip(i * size).Take(size);
            }
        }

        public static IEnumerable<IEnumerable<T>> Split<T>(this T[] enumerable, int size)
        {
            for (var i = 0; i < (float)enumerable.Length / size; i++)
            {
                yield return enumerable.Skip(i * size).Take(size);
            }
        }
    }
}
