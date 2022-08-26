﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CINEMATRIX.API.Application.Validation.Utilities
{
    public static class ValidationUtility
    {
        public static bool InNotNullOrWhitespace(string value)
            => !string.IsNullOrWhiteSpace(value);

        public static bool IsPositiveNumber(decimal value)
            => value > 0;

        public static bool IsPositiveNumber(long value)
            => value > 0;

        public static bool IsValidDateTime(DateTime value) =>
         DateTime.Now.AddYears(-100).Date <= value && value <= DateTime.Now.Date;
    }
}