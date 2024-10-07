﻿using System.Collections.Generic;

namespace Vce
{
    public static class CollectionValidatior
    {
        public static bool IsNullOrEmpty<T>(this List<T> collection)
        {
            return collection == null || collection.Count == 0;
        }
    }
}
