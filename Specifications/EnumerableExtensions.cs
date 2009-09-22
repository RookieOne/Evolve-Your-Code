using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Specifications
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> FilterBySpec<T>(this IEnumerable<T> items, Spec<T> spec)
        {
            foreach(var item in items)
            {
                
            }
        }
    }
}
