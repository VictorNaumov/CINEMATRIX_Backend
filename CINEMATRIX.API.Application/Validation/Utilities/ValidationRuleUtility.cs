using System;

namespace CINEMATRIX.API.Application.Validation.Utilities
{
    public static class ValidationRuleUtility
    {
        public static bool InNotNullOrWhitespace(string value)
            => !string.IsNullOrWhiteSpace(value);

        public static bool IsPositiveNumber(decimal value)
            => value > 0;

        public static bool IsPositiveNumber(long value)
            => value > 0;

        public static bool IsPositiveNumber(int value)
            => value > 0;

        public static bool IsValidDateTime(DateTime value) =>
         DateTime.Now.AddYears(-100).Date <= value && value <= DateTime.Now.Date.AddYears(1);
    }
}
