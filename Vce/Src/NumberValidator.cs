using System.Diagnostics.CodeAnalysis;

namespace Vce
{
    public static class NumberValidator
    {

        // Optimized methods for common types
        public static bool IsNullOrZero([NotNullWhen(false)] this short? value)
        {
            return value == null || value == 0;
        }
        public static bool IsNullOrZero([NotNullWhen(false)] this int? value)
        {
            return value == null || value == 0;
        }
        public static bool IsNullOrZero([NotNullWhen(false)] this long? value)
        {
            return value == null || value == 0;
        }

        public static bool IsNullOrZero([NotNullWhen(false)] this decimal? value)
        {
            return value == null || value == 0;
        }
        public static bool IsNullOrZero([NotNullWhen(false)] this float? value)
        {
            return value == null || value == 0;
        }
        public static bool IsNullOrZero([NotNullWhen(false)] this double? value)
        {
            return value == null || value == 0;
        }
    }
}
