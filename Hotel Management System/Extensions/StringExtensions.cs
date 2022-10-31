using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Extensions
{
    public static class StringExtensions
    {
        public static string ValueOrNull(this string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            return value;
        }

        public static string ValueOrProvided(this string value, string defaultValue)
        {
            return ValueOrNull(value) ?? defaultValue;
        }
    }
}
