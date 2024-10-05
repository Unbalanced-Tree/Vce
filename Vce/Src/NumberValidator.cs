namespace Vce
{
    public static class NumberValidator
    {

        // Optimized methods for common types
        public static bool IsNullOrZero(this short? value)
        {
            return value == null || value == 0;
        }
        public static bool IsNullOrZero(this int? value)
        {
            return value == null || value == 0;
        }
        public static bool IsNullOrZero(this long? value)
        {
            return value == null || value == 0;
        }

        public static bool IsNullOrZero(this decimal? value)
        {
            return value == null || value == 0; 
        }
        public static bool IsNullOrZero(this float? value)
        {
            return value == null || value == 0;
        }
        public static bool IsNullOrZero(this double? value)
        {
            return value == null || value == 0;
        }
    }
}
