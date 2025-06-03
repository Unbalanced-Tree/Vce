using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Vce
{
    public static class CollectionValidator
    {
        public static bool IsNullOrEmpty<T>([NotNullWhen(false)] this List<T> collection)
        {
            return collection == null || collection.Count == 0;
        }
    }
}
